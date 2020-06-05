using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqHaxCSGO.MemoryManagers
{
    static class SigScanner
    {
        public static int FindPattern(byte[] pattern, string mask, int moduleBase, int moduleSize)
        {
            byte[] moduleBytes = new byte[moduleSize];

            if (Memory.ReadBytes(moduleBase, ref moduleBytes))
            {
                for (int i = 0; i < moduleSize; i++)
                {
                    bool found = true;

                    for (int l = 0; l < mask.Length; l++)
                    {
                        found = mask[l] == '?' || moduleBytes[l + i] == pattern[l];

                        if (!found)
                            break;
                    }

                    if (found)
                        return i;
                }
            }

            return 0;
        }

        public static Int32 ClientSigScan(byte[] sig)
        {
            return FindPattern(sig, GetFullfilledMask(sig), Memory.clientBase, Memory.clientSize);
        }

        public static Int32 EngineSigScan(byte[] sig)
        {
            return FindPattern(sig, GetFullfilledMask(sig), Memory.engineBase, Memory.engineSize);
        }

        public static Int32 ClientSigScan(string sig, int offset = 0, int extra = 0)
        {
            return SigScan(sig, offset, extra, Memory.clientBase, Memory.clientSize);
        }

        public static Int32 EngineSigScan(string sig, int offset = 0, int extra = 0)
        {
            return SigScan(sig, offset, extra, Memory.engineBase, Memory.engineSize);
        }

        private static Int32 SigScan(string sig, int offset, int extra, Int32 module, Int32 moduleSize)
        {
            byte[] moduleDump = new byte[moduleSize];

            if (Memory.ReadBytes(module, ref moduleDump))
            {
                byte[] pattern = SignatureToPattern(sig);
                string mask = GetSignatureMask(sig);
                IntPtr address = IntPtr.Zero;

                for (int i = 0; i < moduleSize; i++)
                {
                    if (address == IntPtr.Zero && pattern.Length + i < moduleSize)
                    {
                        bool isSuccess = true;

                        for (int k = 0; k < pattern.Length; k++)
                        {
                            if (mask[k] == '?')
                                continue;


                            if (pattern[k] != moduleDump[i + k])
                                isSuccess = false;
                        }

                        if (!isSuccess) continue;

                        if (address == IntPtr.Zero)
                            return BitConverter.ToInt32(Memory.ReadBytes(module + i + offset, 4), 0) + extra - module;
                    }
                }
            }

            return -1;
        }

        private static byte[] SignatureToPattern(string sig)
        {
            string[] parts = sig.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] patternArray = new byte[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "?")
                {
                    patternArray[i] = 0;
                    continue;
                }

                if (!byte.TryParse(parts[i], System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.DefaultThreadCurrentCulture, out patternArray[i]))
                {
                    throw new Exception();
                }
            }

            return patternArray;
        }

        private static string GetSignatureMask(string sig)
        {
            string[] parts = sig.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string mask = "";

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "?")
                {
                    mask += "?";
                }
                else
                {
                    mask += "x";
                }
            }

            return mask;
        }

        private static string GetFullfilledMask(byte[] buffer)
        {
            string result = "";
            for (int i = 0; i < buffer.Length; i++) 
            {
                result += "x";
            }
            Console.WriteLine("Result: " + result);
            return result;
        }
    }
}
