using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Diagnostics;

namespace AqHaxCSGO.Memory
{
    public static class Memory
    {
        public static Process m_Process;
        public static IntPtr m_pProcessHandle;

        public static int m_iNumberOfBytesRead = 0;
        public static int m_iNumberOfBytesWritten = 0;

        public static bool Init(string ProcessName)
        {

            // Check if csgo.exe is running
            if (Process.GetProcessesByName(ProcessName).Length > 0)
                m_Process = Process.GetProcessesByName(ProcessName)[0];
            else
            {
                return false;
            }
            m_pProcessHandle = OpenProcess(0x0008 | 0x0010 | 0x0020, false, m_Process.Id); // Sets Our ProcessHandle
            return true;
        }

        public static int GetModuleAdress(string ModuleName)
        {
            try
            {
                foreach (ProcessModule ProcMod in m_Process.Modules)
                {
                    if (!ModuleName.Contains(".dll"))
                        ModuleName = ModuleName.Insert(ModuleName.Length, ".dll");

                    if (ModuleName == ProcMod.ModuleName)
                    {
                        return (int)ProcMod.BaseAddress;
                    }
                }
            }
            catch
            {

            }
            return -1;
        }

        public static int GetModuleSize(string ModuleName)
        {
            try
            {
                foreach (ProcessModule ProcMod in m_Process.Modules)
                {
                    if (!ModuleName.Contains(".dll"))
                        ModuleName = ModuleName.Insert(ModuleName.Length, ".dll");

                    if (ModuleName == ProcMod.ModuleName)
                    {
                        return (int)ProcMod.ModuleMemorySize;
                    }
                }
            }
            catch
            {

            }

            return -1;
        }

        public static T Read<T>(int Adress) where T : struct
        {
            int ByteSize = Marshal.SizeOf(typeof(T)); // Get ByteSize Of DataType
            byte[] buffer = new byte[ByteSize]; // Create A Buffer With Size Of ByteSize
            ReadProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, ref m_iNumberOfBytesRead); // Read Value From Memory

            return ByteArrayToStructure<T>(buffer); // Transform the ByteArray to The Desired DataType
        }

        public static string ReadString(Int32 address, int bufferSize, Encoding enc)
        {
            byte[] buffer = new byte[bufferSize];
            UInt32 nBytesRead = 0;
            bool success = ReadProcessMemory((int)m_pProcessHandle, address, buffer, bufferSize, ref m_iNumberOfBytesRead);
            string text = enc.GetString(buffer);
            if (text.Contains('\0'))
                text = text.Substring(0, text.IndexOf('\0'));
            return text;
        }

        public static float[] ReadMatrix<T>(int Adress, int MatrixSize) where T : struct
        {
            int ByteSize = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[ByteSize * MatrixSize]; // Create A Buffer With Size Of ByteSize * MatrixSize
            ReadProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, ref m_iNumberOfBytesRead);

            return ConvertToFloatArray(buffer); // Transform the ByteArray to A Float Array (PseudoMatrix ;P)
        }

        public static void Write<T>(int Adress, object Value)
        {
            byte[] buffer = StructureToByteArray(Value); // Transform Data To ByteArray 

            WriteProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, out m_iNumberOfBytesWritten);
        }

        public static void Write<T>(int Adress, byte Value, bool isByte)
        {
            byte[] buffer = StructureToByteArray(Value);

            WriteProcessMemory((int)m_pProcessHandle, Adress, buffer, sizeof(byte), out m_iNumberOfBytesWritten);
        }

        public static void Write<T>(int Adress, char[] Value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(Value);

            WriteProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, out m_iNumberOfBytesWritten);
        }

        public static void WriteProtectedMemory<T>(int Adress, object ob)
        {
            uint oldFlag;
            uint nvm;

            byte[] Value = StructureToByteArray(ob);

            if (VirtualProtectEx(m_pProcessHandle, (IntPtr)Adress, (UIntPtr)Value.Length, 0x40, out oldFlag))
            {
                WriteProcessMemory((int)m_pProcessHandle, Adress, Value, Value.Length, out m_iNumberOfBytesWritten);

                if (VirtualProtectEx(m_pProcessHandle, (IntPtr)Adress, (UIntPtr)Value.Length, oldFlag, out nvm))
                {
                    Console.WriteLine("Full Success");
                }
                else
                {
                    Console.WriteLine("Half Successful");
                }
            }
            else
            {
                Console.WriteLine("Insuccessful");
            }
        }

        #region Transformation
        public static float[] ConvertToFloatArray(byte[] bytes)
        {
            if (bytes.Length % 4 != 0)
                throw new ArgumentException();

            float[] floats = new float[bytes.Length / 4];

            for (int i = 0; i < floats.Length; i++)
                floats[i] = BitConverter.ToSingle(bytes, i * 4);

            return floats;
        }

        private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }

        private static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }
        #endregion

        #region DllImports

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(
            int dwDesiredAccess, 
            bool bInheritHandle, 
            int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(
            int hProcess, 
            int lpBaseAddress, 
            byte[] buffer, 
            int size, 
            ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(
            int hProcess, 
            int lpBaseAddress, 
            byte[] buffer, 
            int size, 
            out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern bool VirtualProtectEx(
            IntPtr hProcess, 
            IntPtr lpAddress, 
            UIntPtr dwSize, 
            uint flNewProtect,
            out uint lpflOldProtect);
        #endregion
    }
}
