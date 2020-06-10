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
        private CBaseEntity[] entities = new CBaseEntity[4096];

        public EntityList()
        {
            for (int i = 0; i < entities.Length; i++)
            {
                entities[i] = new CBaseEntity(i);
            }
        }
        
        public CBaseEntity this[int index]
        {
            get
            {
                try
                {
                    return entities[index];
                }
                catch 
                {
                    return null;
                }
            }
        }
    }

    class CBaseEntity 
    {
        protected int index;

        public CBaseEntity(int index)
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

        protected int GlowIndex
        {
            get
            {
                return Memory.Read<int>(Base + m_iGlowIndex);
            }
        }

        public Vector3 VectorOrigin
        {
            get
            {
                return Memory.Read<Vector3>(Base + m_vecOrigin);
            }
        }
    }
}
