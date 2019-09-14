using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects
{
    static class LocalPlayer
    {
        public static int LocalPlayerPtr
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwLocalPlayer);
            }
        }

        public static int GetViewModelIndex(int index)
        {
            return Memory.Read<int>(LocalPlayerPtr + 0x32F8 + index * 0x4) & 0xFFF; //0x32F8 = DT_BasePlayer -> hViewModel[0]
        }

        public static int Team
        {
            get
            {
                return Memory.Read<int>(LocalPlayerPtr + m_iTeamNum);
            }
        }

        public static int Flags
        {
            get
            {
                return Memory.Read<int>(LocalPlayerPtr + m_fFlags);
            }
        }

        public static int CrosshairID
        {
            get
            {
                return Memory.Read<int>(LocalPlayerPtr + m_iCrosshairId);
            }
        }

        public static Vector3 VectorOrigin
        {
            get
            {
                return Memory.Read<Vector3>(LocalPlayerPtr + m_vecOrigin);
            }
        }

        public static Vector3 VectorEyeLevel
        {
            get
            {
                return Memory.Read<Vector3>(LocalPlayerPtr + m_vecViewOffset);
            }
        }

        public static Angle ViewPunchAngle
        {
            get
            {
                return Memory.Read<Angle>(LocalPlayerPtr + m_aimPunchAngle);
            }
        }

        public static Angle ViewAngle
        {
            get
            {
                return Memory.Read<Angle>(Engine.ClientStatePtr + dwClientState_ViewAngles);
            }
        }

        public static int ActiveWeaponPtr
        {
            get
            {
                return Memory.Read<int>(LocalPlayerPtr + m_hActiveWeapon) & 0xFFF;
            }
        }

        public static float FlashAlpha
        {
            set
            {
                Memory.Write<float>(LocalPlayerPtr + m_flFlashMaxAlpha, value);
            }
        }

        public static int ShotsFired
        {
            get
            {
                return Memory.Read<int>(LocalPlayerPtr + m_iShotsFired);
            }
        }
    }
}
