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
            int lastLoadedModelIndexForSkin = 0;

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

                bool anythingChanged = false;
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
                    if (currentWeapon.IsKnife()) 
                    {
                        if (selected.WeaponID == (int)Constants.KnifeList[Globals.SelectedKnife].itemDefinitionIndex) 
                        {
                            if ((currentWeapon.PaintKit != selected.PaintKit || lastLoadedModelIndexForSkin != RuntimeGlobals.selectedKnifeModelIndex))
                            {
                                currentWeapon.ItemIDHigh = -1;
                                currentWeapon.PaintKit = selected.PaintKit;
                                currentWeapon.Wear = 0.0001f;
                                lastLoadedModelIndexForSkin = RuntimeGlobals.selectedKnifeModelIndex;

                                if (!Globals.ManualLoadEnabled) EngineDLL.ForceReload = -1;
                                anythingChanged = true;
                            }
                        }
                        continue; 
                    }

                    if (currentWeapon.PaintKit != selected.PaintKit &&
                        currentWeapon.ItemDefinitionIndex == selected.WeaponID)
                    {
                        currentWeapon.ItemIDHigh = -1;
                        currentWeapon.PaintKit = selected.PaintKit;
                        if (selected.Seed != -1) currentWeapon.Seed = selected.Seed;
                        currentWeapon.Wear = selected.Wear;
                        currentWeapon.AccountID = currentWeapon.XuIDLow;
                        if (selected.CustomName != null && selected.CustomName != "") currentWeapon.CustomName = selected.CustomName;

                        if(!Globals.ManualLoadEnabled) EngineDLL.ForceReload = -1;
                        anythingChanged = true;
                    }
                }
                if (Globals.ManualLoadEnabled && (GetAsyncKeyState((int)Keys.P) & 0x8000) > 0) EngineDLL.ForceReload = -1;

                Thread.Sleep(TimeSpan.FromMilliseconds(0.1));
            }
        }
    }
}
