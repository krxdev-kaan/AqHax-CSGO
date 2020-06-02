using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using AqHaxCSGO.Objects;

namespace AqHaxCSGO.Hacks
{
    static class Others
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetAsyncKeyState(
            int vKey
        );

        public static void FlashThread()
        {
            while (true)
            {
                if (!Globals.AntiFlashEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!Engine.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                LocalPlayer.FlashAlpha = 0.0f;
                Thread.Sleep(5);
            }
        }

        public static void BunnyThread()
        {
            while (true)
            {
                if (!Globals.BunnyHopEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!Engine.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                if ((GetAsyncKeyState((int)Keys.Space) & 0x8000) > 0)
                {
                    if (LocalPlayer.Flags == 257)
                    {
                        Client.ForceJump(true);
                        Thread.Sleep(10);
                        Client.ForceJump(false);
                    }
                }

                Thread.Sleep(Globals.BunnyHopAccuracy);
            }
        }
    }
}
