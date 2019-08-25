using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;
using AqHaxCSGO.Objects.Structs;

namespace AqHaxCSGO.Objects
{
    class WeaponList
    {
        private Weapon[] weapons = new Weapon[16];

        public WeaponList()
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i] = new Weapon(i);
            }
        }

        public Weapon this[int index]
        {
            get
            {
                return weapons[index];
            }
        }

        public Weapon ActiveWeapon
        {
            get
            {
                return new Weapon((IntPtr)(LocalPlayer.ActiveWeaponPtr));
            }
        }
    }

    class Weapon
    {
        public int Index { get; private set; }

        public Weapon(int index)
        {
            this.Index = index;
        }

        public Weapon(IntPtr ptr)
        {
            Ptr = (int)ptr;
        }

        private int _Ptr = -1;
        private int Ptr
        {
            get
            {
                if (_Ptr != -1) return _Ptr;
                return Memory.Read<int>(LocalPlayer.LocalPlayerPtr + m_hMyWeapons + Index * 0x4) & 0xFFF;
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
        public short ItemDefinitionIndex
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

        public string Name
        {
            set
            {
                Memory.Write<char[]>(Base + m_szCustomName, value.ToCharArray());
            }
        }
        #endregion

        #region KnifeSDK
        public int UnchangableItemDefinitionIndex
        {
            get
            {
                return Memory.Read<int>(Base + 0x3220); //0x3220 = iViewModelIndex? (which always equals to unchanged ItemDefinitionIndex)
            }
        }

        private int ViewModelBase
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwEntityList + (LocalPlayer.GetViewModelIndex(Index) - 1) * 0x10);
            }
        }

        public int ViewModelIndex
        {
            get
            {
                return Memory.Read<int>(ViewModelBase + 0x258); //0x258 = modelIndex?
            }
            set
            {
                Memory.Write<int>(ViewModelBase + 0x258, value);
            }
        }
        #endregion

        public float NextPrimaryAttack
        {
            get
            {
                return Memory.Read<float>(Ptr + m_flNextPrimaryAttack);
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
                return Memory.Read<int>(Ptr + m_iClip1);
            }
        }

        #region Checks 
        public bool IsKnife()
        {
            int index = ItemDefinitionIndex;
            return index == 41 || //WEAPON_KNIFEGG ? (not sure so not included in enum WeaponType)
                index == (int)WeaponType.WEAPON_KNIFE ||
                index == (int)WeaponType.WEAPON_KNIFE_T ||
                index == (int)WeaponType.WEAPON_KNIFE_BAYONET ||
                index == (int)WeaponType.WEAPON_KNIFE_GUT ||
                index == (int)WeaponType.WEAPON_KNIFE_KARAMBIT ||
                index == (int)WeaponType.WEAPON_KNIFE_FLIP ||
                index == (int)WeaponType.WEAPON_KNIFE_BUTTERFLY ||
                index == (int)WeaponType.WEAPON_KNIFE_TACTICAL ||
                index == (int)WeaponType.WEAPON_KNIFE_FALCHION ||
                index == (int)WeaponType.WEAPON_KNIFE_M9_BAYONET ||
                index == (int)WeaponType.WEAPON_KNIFE_SURVIVAL_BOWIE ||
                index == (int)WeaponType.WEAPON_KNIFE_PUSH ||
                index == (int)WeaponType.WEAPON_KNIFE_URSUS ||
                index == (int)WeaponType.WEAPON_KNIFE_GYPSY_JACKKNIFE ||
                index == (int)WeaponType.WEAPON_KNIFE_STILETTO ||
                index == (int)WeaponType.WEAPON_KNIFE_WIDOWMAKER;
        }
        public bool IsGrenade()
        {
            int index = ItemDefinitionIndex;
            return index == (int)WeaponType.WEAPON_FLASHBANG ||
                index == (int)WeaponType.WEAPON_HEGRENADE ||
                index == (int)WeaponType.WEAPON_INCGRENADE ||
                index == (int)WeaponType.WEAPON_SMOKEGRENADE;
        }

        public bool IsSniper()
        {
            int index = ItemDefinitionIndex;
            return index == (int)WeaponType.WEAPON_AWP ||
                index == (int)WeaponType.WEAPON_SSG08;
        }

        public bool IsAutoSniper()
        {
            int index = ItemDefinitionIndex;
            return index == (int)WeaponType.WEAPON_SCAR20 ||
                index == (int)WeaponType.WEAPON_G3SG1;
        }

        public bool IsC4()
        {
            int index = ItemDefinitionIndex;
            return index == (int)WeaponType.WEAPON_C4;
        }
        #endregion
    }
}
