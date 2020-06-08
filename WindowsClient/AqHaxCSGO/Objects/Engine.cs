using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects
{
    static class Engine
    {
        public static int ClientStatePtr
        {
            get
            {
                return Memory.Read<int>(Memory.engineBase + dwClientState);
            }
        }

        public static int MaxPlayer
        {
            get
            {
                return Memory.Read<int>(ClientStatePtr + dwClientState_MaxPlayer);
            }
        }

        public static bool InGame
        {
            get
            {
                return Memory.Read<int>(ClientStatePtr + dwClientState_State) == 6;
            }
        }

        public static int ForceReload
        {
            get
            {
                return Memory.Read<int>(ClientStatePtr + clientstate_delta_ticks);
            }
            set
            {
                Memory.Write<int>(ClientStatePtr + clientstate_delta_ticks, value);
            }
        }

        public static bool SendPackets
        {
            get
            {
                return Memory.Read<byte>(Memory.engineBase + dwbSendPackets) == 1;
            }
            set
            {
                Memory.Write<byte>(Memory.engineBase + dwbSendPackets, value ? (byte)0x1 : (byte)0x0, true);
            }
        }

        public static void ClientCMD_Execute(string command)
        {
            byte[] t = Encoding.UTF8.GetBytes(command + "\0");
            IntPtr commandPointer = Memory.VirtualAllocEx(Memory.m_pProcessHandle, IntPtr.Zero, (IntPtr)(t.Length), 0x00002000 | 0x00001000, 0x40);
            IntPtr th;
            int a;
            Memory.WriteProcessMemory((int)Memory.m_pProcessHandle, (int)commandPointer, t, t.Length, out a);
            IntPtr hThread = Memory.CreateRemoteThread(Memory.m_pProcessHandle, IntPtr.Zero, 0, IntPtr.Add(new IntPtr(Memory.engineBase), dwClientCmd), commandPointer, 0, out th);
            Memory.WaitForSingleObject(hThread, 0xFFFFFFFF);
            Memory.VirtualFreeEx(Memory.m_pProcessHandle, commandPointer, (UIntPtr)t.Length, 0x00008000);
            Memory.CloseHandle(hThread);
        }
    }
}
