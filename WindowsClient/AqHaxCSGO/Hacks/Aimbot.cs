using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using AqHaxCSGO.Objects;
using AqHaxCSGO.Objects.Structs;
using static AqHaxCSGO.Objects.GlobalLists;

namespace AqHaxCSGO.Hacks
{
    static class Aimbot
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetAsyncKeyState(
            int vKey
        );

        public static void TriggerThread()
        {
            while (true)
            {
                if (!Globals.TriggerEnabled)
                {
                    Thread.Sleep(10);
                    continue;
                }
                if (!Engine.InGame)
                {
                    Thread.Sleep(10);
                    continue;
                }

                if (Globals.TriggerPressOnlyEnabled)
                {
                    if ((GetAsyncKeyState((int)Keys.ShiftKey) & 0x8000) > 0)
                    {
                        if (LocalPlayer.CrosshairID > 0 && LocalPlayer.CrosshairID < Engine.MaxPlayer + 2)
                        {
                            if (entityList[LocalPlayer.CrosshairID - 1].Team != LocalPlayer.Team)
                            {
                                Thread.Sleep(1);
                                Client.ForceAttack(true);
                                Thread.Sleep(5);
                                Client.ForceAttack(false);
                            }
                        }
                    }
                }
                else
                {
                    if (LocalPlayer.CrosshairID > 0 && LocalPlayer.CrosshairID < Engine.MaxPlayer + 2)
                    {
                        if (entityList[LocalPlayer.CrosshairID - 1].Team != LocalPlayer.Team)
                        {
                            Thread.Sleep(1);
                            Client.ForceAttack(true);
                            Thread.Sleep(5);
                            Client.ForceAttack(false);
                        }
                    }
                }

                Thread.Sleep(2);
            }
        }

        public static void AimbotThread()
        {
            while (true)
            {

            }
        }
    }
}
