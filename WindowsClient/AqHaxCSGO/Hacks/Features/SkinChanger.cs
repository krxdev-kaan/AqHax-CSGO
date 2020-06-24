using AqHaxCSGO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static AqHaxCSGO.Objects.GlobalLists;
using AqHaxCSGO.Misc;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AqHaxCSGO.Hacks.Features
{
    static class SkinChanger
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetAsyncKeyState(
            int vKey
        );

        public static void SkinChangerThread() 
        {
            while (true) 
            {
                if (!Globals.SkinChangerEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                for (var i = 0; i < 8; i++)
                {
                    CBaseCombatWeapon currentWeapon = weaponList[i];

                    bool contin = false;
                    Skin selected = null;
                    try
                    {
                        foreach (Skin s in Globals.LoadedPresets)
                        {
                            if (Convert.ToInt32(s.WeaponID) == currentWeapon.ItemDefinitionIndex)
                            {
                                contin = true;
                                selected = s;
                                break;
                            }
                        }
                    }
                    catch { continue; }

                    if (!contin) continue;
                    if (currentWeapon.IsKnife()) continue;

                    if (currentWeapon.PaintKit != Convert.ToInt32(selected.PaintKit) &&
                        currentWeapon.ItemDefinitionIndex == Convert.ToInt32(selected.WeaponID))
                    {
                        currentWeapon.ItemIDHigh = -1;
                        currentWeapon.PaintKit = selected.PaintKit;
                        if (selected.Seed != -1) currentWeapon.Seed = selected.Seed;
                        currentWeapon.Wear = selected.Wear;
                        currentWeapon.AccountID = currentWeapon.XuIDLow;
                        if (selected.CustomName != null && selected.CustomName != "") currentWeapon.CustomName = selected.CustomName;

                        if (!Globals.ManualLoadEnabled)
                        {
                            if (EngineDLL.ForceReload != -1) EngineDLL.ForceReload = -1;
                        }
                        else
                        {
                            if ((GetAsyncKeyState((int)Keys.P) & 0x8000) > 0)
                            {
                                if (EngineDLL.ForceReload != -1) EngineDLL.ForceReload = -1;
                            }
                        }
                    }
                }

                Thread.Sleep(Globals.UsageDelay);
            }
        }
    }
}
