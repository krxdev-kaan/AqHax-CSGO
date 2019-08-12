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
                int matrix = Memory.Read<int>(LocalPlayerPtr + m_dwBoneMatrix);

                Vector3 headPos = new Vector3();

                headPos.x = Memory.Read<float>(matrix + (0x30 * 8) + 0x0C);
                headPos.y = Memory.Read<float>(matrix + (0x30 * 8) + 0x1C);
                headPos.z = Memory.Read<float>(matrix + (0x30 * 8) + 0x2C);

                return headPos;
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
    }
}
