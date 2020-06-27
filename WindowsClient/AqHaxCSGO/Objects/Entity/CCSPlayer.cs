using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using AqHaxCSGO.Objects.Structs;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects
{
    class CCSPlayer : CBaseEntity
    {
        public CCSPlayer(int index) : base(index)
        {
        }

        public CCSPlayer(CBaseEntity baseEnt) : base(baseEnt.index)
        { 
        }

        public int Team
        {
            get
            {
                return Memory.Read<int>(Base + m_iTeamNum);
            }
        }

        public int Health
        {
            get
            {
                return Memory.Read<int>(Base + m_iHealth);
            }
        }

        public bool Dormant
        {
            get
            {
                return Memory.Read<int>(Base + m_bDormant) == 1;
            }
        }

        public bool Spotted
        {
            get
            {
                return Memory.Read<int>(Base + m_bSpotted) == 1;
            }

            set
            {
                Memory.Write<int>(Base + m_bSpotted, value ? 1 : 0);
            }
        }

        public Vector3 GetBonePosition(int boneIndex)
        {
            int matrix = Memory.Read<int>(Base + m_dwBoneMatrix);

            Vector3 bonePos = new Vector3();

            bonePos.x = Memory.Read<float>(matrix + (0x30 * boneIndex) + 0x0C);
            bonePos.y = Memory.Read<float>(matrix + (0x30 * boneIndex) + 0x1C);
            bonePos.z = Memory.Read<float>(matrix + (0x30 * boneIndex) + 0x2C);

            return bonePos;
        }

        public RenderColor RenderColor
        {
            set
            {
                Memory.Write<RenderColor>(Base + m_clrRender, value);
            }
        }
    }
}
