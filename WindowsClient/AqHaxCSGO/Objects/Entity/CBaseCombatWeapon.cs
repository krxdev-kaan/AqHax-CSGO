using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;
using AqHaxCSGO.Objects.Structs;
using static AqHaxCSGO.Objects.GlobalLists;

namespace AqHaxCSGO.Objects
{
    class WeaponList
    {
        private CBaseCombatWeapon[] weapons = new CBaseCombatWeapon[16];

        public WeaponList()
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i] = new CBaseCombatWeapon(i);
            }
        }

        public CBaseCombatWeapon this[int index]
        {
            get
            {
                try
                {
                    return weapons[index];
                }
                catch
                {
                    return null;
                }
            }
        }

        public CBaseCombatWeapon ActiveWeapon
        {
            get
            {
                return new CBaseCombatWeapon((IntPtr)CBasePlayer.ActiveWeaponIndex);
            }
        }
    }

    class CBaseCombatWeapon
    {
        public int Index { get; private set; }

        public CBaseCombatWeapon(int index)
        {
            this.Index = index;
        }

        public CBaseCombatWeapon(IntPtr ptr) 
        {
            this.Ptr = (int)ptr;
        }

        private int _Ptr = -1;
        private int Ptr
        {
            get
            {
                if (_Ptr != -1) return _Ptr;
                return Memory.Read<int>(CBasePlayer.LocalPlayerPtr + m_hMyWeapons + Index * 0x4) & 0xFFF;
            }
            set
            {
                _Ptr = value;
            }
        }

        public int Base
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwEntityList + (Ptr - 1) * 0x10);
            }
        }

        #region SkinSDK
        public int ItemDefinitionIndex
        {
            get
            {
                return Memory.Read<short>(Base + m_iItemDefinitionIndex);
            }
            set
            {
                Memory.Write<short>(Base + m_iItemDefinitionIndex, value);
            }

        }

        public int AccountID
        {
            get
            {
                return Memory.Read<int>(Base + m_iAccountID);
            }
            set
            {
                Memory.Write<int>(Base + m_iAccountID, value);
            }
        }

        public int XuIDLow
        {
            get
            {
                return Memory.Read<int>(Base + m_OriginalOwnerXuidLow);
            }
            set
            {
                Memory.Write<int>(Base + m_OriginalOwnerXuidLow, value);
            }
        }

        public int ItemIDHigh
        {
            get
            {
                return Memory.Read<int>(Base + m_iItemIDHigh);
            }
            set
            {
                Memory.Write<int>(Base + m_iItemIDHigh, value);
            }
        }

        public int PaintKit
        {
            get
            {
                return Memory.Read<int>(Base + m_nFallbackPaintKit);
            }
            set
            {
                Memory.Write<int>(Base + m_nFallbackPaintKit, value);
            }
        }

        public float Wear
        {
            get
            {
                return Memory.Read<float>(Base + m_flFallbackWear);
            }
            set
            {
                Memory.Write<float>(Base + m_flFallbackWear, value);
            }
        }

        public int StatTrak
        {
            get
            {
                return Memory.Read<int>(Base + m_nFallbackStatTrak);
            }
            set
            {
                Memory.Write<int>(Base + m_nFallbackStatTrak, value);
            }
        }

        public int Seed
        {
            get
            {
                return Memory.Read<int>(Base + m_nFallbackSeed);
            }
            set
            {
                Memory.Write<int>(Base + m_nFallbackSeed, value);
            }
        }

        public string CustomName
        {
            set
            {
                Memory.Write<char[]>(Base + m_szCustomName, value.ToCharArray());
            }
        }

        public int EntityQuality 
        {
            set 
            {
                Memory.Write<int>(Base + m_iEntityQuality, value);
            }
        }
        #endregion

        #region KnifeSDK
        public int ViewModelIndex
        {
            get
            {
                return Memory.Read<int>(Base + m_iViewModelIndex);
            }
            set
            {
                Memory.Write<int>(Base + m_iViewModelIndex, value);
            }
        }

        private int ViewModelBase
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwEntityList + (CBasePlayer.GetViewModelIndex(0) - 1) * 0x10);
            }
        }

        /**
         * USE ONLY ON ACTIVE WEAPON !!!
         */
        public int ViewModelEntityModelIndex
        {
            get
            {
                return Memory.Read<int>(ViewModelBase + m_nModelIndex);
            }
            set
            {
                Memory.Write<int>(ViewModelBase + m_nModelIndex, value);
            }
        }

        public int Sequence 
        { 
            get 
            {
                return Memory.Read<int>(ViewModelBase + m_nSequence);
            }
            set 
            {
                Memory.Write<int>(ViewModelBase + m_nSequence, value);
            }
        }

        public int ModelIndex
        {
            get
            {
                return Memory.Read<int>(Base + m_nModelIndex);
            }
            set
            {
                Memory.Write<int>(Base + m_nModelIndex, value);
            }
        }
        #endregion

        public float NextPrimaryAttack
        {
            get
            {
                return Memory.Read<float>(Base + m_flNextPrimaryAttack);
            }
        }

        public bool CanFire
        {
            get
            {
                return NextPrimaryAttack <= 0 || NextPrimaryAttack < Memory.Read<int>(Memory.clientBase + m_nTickBase);
            }
        }

        public int Ammo
        {
            get
            {
                return Memory.Read<int>(Base + m_iClip1);
            }
        }

        #region Checks 
        public bool IsKnife()
        {
            int index = ItemDefinitionIndex;
            return index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_T ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_BAYONET ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_GUT ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_KARAMBIT ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_FLIP ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_BUTTERFLY ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_TACTICAL ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_FALCHION ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_M9_BAYONET ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_SURVIVAL_BOWIE ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_PUSH ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_URSUS ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_GYPSY_JACKKNIFE ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_STILETTO ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_WIDOWMAKER ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_CSS ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_CORD ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_CANIS ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_SKELETON ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_KNIFE_OUTDOOR;
        }
        public bool IsGrenade()
        {
            int index = ItemDefinitionIndex;
            return index == (int)Structs.ItemDefinitionIndex.WEAPON_FLASHBANG ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_HEGRENADE ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_INCGRENADE ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_SMOKEGRENADE;
        }

        public bool IsSniper()
        {
            int index = ItemDefinitionIndex;
            return index == (int)Structs.ItemDefinitionIndex.WEAPON_AWP ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_SSG08;
        }

        public bool IsAutoSniper()
        {
            int index = ItemDefinitionIndex;
            return index == (int)Structs.ItemDefinitionIndex.WEAPON_SCAR20 ||
                index == (int)Structs.ItemDefinitionIndex.WEAPON_G3SG1;
        }

        public bool IsC4()
        {
            int index = ItemDefinitionIndex;
            return index == (int)Structs.ItemDefinitionIndex.WEAPON_C4;
        }
        #endregion
    }
}
