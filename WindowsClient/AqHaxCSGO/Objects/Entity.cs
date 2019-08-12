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
    class EntityList
    {
        private Entity[] entities = new Entity[64];

        public EntityList()
        {
            for (int i = 0; i < entities.Length; i++)
            {
                entities[i] = new Entity(i);
            }
        }

        public Entity this[int index]
        {
            get
            {
                return entities[index];
            }
        }
    }

    class Entity
    {
        private int index;

        public Entity(int index)
        {
            this.index = index;
        }

        public int Base
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwEntityList + index * 0x10);
            }
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

        public Vector3 VectorOrigin
        {
            get
            {
                return Memory.Read<Vector3>(Base + m_vecOrigin);
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

        public GlowObject GlowObject
        {
            get
            {
                return Memory.Read<GlowObject>(GlowObject.Ptr + GlowIndex * 0x38);
            }
            set
            {
                Memory.Write<GlowObject>(GlowObject.Ptr + GlowIndex * 0x38, value);
            }
        }

        public RenderColor RenderColor
        {
            set
            {
                Memory.Write<RenderColor>(Base + m_clrRender, value);
            }
        }

        private int GlowIndex
        {
            get
            {
                return Memory.Read<int>(Base + m_iGlowIndex);
            }
        }
    }
}
