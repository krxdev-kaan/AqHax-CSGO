using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AqHaxCSGO.Objects;
using static AqHaxCSGO.Objects.GlobalLists;
using AqHaxCSGO.Misc;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AqHaxCSGO.Objects.Structs;

namespace AqHaxCSGO.Hacks.Features
{
    static class KnifeChanger
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetAsyncKeyState(
            int vKey
        );

        public static void KnifeChangerThread()
        {
            bool shouldReloadModelIndex = true;
            RuntimeGlobals.selectedKnifeModelIndex = 0;
            int selectedKnifeIndex = 0;

            while (true)
            {
                if (!Globals.KnifeChangerEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    shouldReloadModelIndex = true;
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    shouldReloadModelIndex = true;
                    continue;
                }

                if (shouldReloadModelIndex || selectedKnifeIndex != (int)Constants.KnifeList[Globals.SelectedKnife].itemDefinitionIndex) 
                {
                    RuntimeGlobals.selectedKnifeModelIndex = EngineDLL.GetModelIndexByName(Constants.KnifeList[Globals.SelectedKnife].modelName);
                    selectedKnifeIndex = (int)Constants.KnifeList[Globals.SelectedKnife].itemDefinitionIndex;
                    shouldReloadModelIndex = false;
                }

                for (var i = 0; i < 12; i++)
                {
                    CBaseCombatWeapon currentWeapon = weaponList[i];

                    if (currentWeapon.IsKnife()) 
                    {
                        currentWeapon.ItemDefinitionIndex = (int)Constants.KnifeList[Globals.SelectedKnife].itemDefinitionIndex;
                        currentWeapon.EntityQuality = 3;
                        currentWeapon.ModelIndex = RuntimeGlobals.selectedKnifeModelIndex;
                        currentWeapon.ViewModelIndex = RuntimeGlobals.selectedKnifeModelIndex;
                    }
                }

                for (int i = 0; i < 10; i++) //Seems to be making it more stable
                    if (weaponList.ActiveWeapon.IsKnife()) weaponList.ActiveWeapon.ViewModelEntityModelIndex = RuntimeGlobals.selectedKnifeModelIndex;

                Thread.Sleep(Globals.UsageDelay);
            }
        }
    }
}
