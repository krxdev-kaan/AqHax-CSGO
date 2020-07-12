using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects.Entity
{
    class CEnvTonemapController : CBaseEntity
    {
        public CEnvTonemapController(int index) : base(index)
        {
        }

        public CEnvTonemapController(CBaseEntity baseEnt) : base(baseEnt.index)
        {
        }

        public byte UseCustomAutoExposureMin
        {
            get 
            {
                return Memory.Read<byte>(Base + m_bUseCustomAutoExposureMin);
            }
            set 
            {
                Memory.Write<byte>(Base + m_bUseCustomAutoExposureMin, value);
            }
        }

        public byte UseCustomAutoExposureMax
        {
            get
            {
                return Memory.Read<byte>(Base + m_bUseCustomAutoExposureMax);
            }
            set
            {
                Memory.Write<byte>(Base + m_bUseCustomAutoExposureMax, value);
            }
        }

        public bool UseCustomBloomScale
        {
            get
            {
                return Memory.Read<byte>(Base + m_bUseCustomBloomScale) == 1 ? true : false;
            }
            set
            {
                Memory.Write<byte>(Base + m_bUseCustomBloomScale, value ? (byte)1 : (byte)0);
            }
        }

        public float CustomAutoExposureMin 
        {
            get 
            {
                return Memory.Read<float>(Base + m_flCustomAutoExposureMin);
            }
            set 
            {
                Memory.Write<float>(Base + m_flCustomAutoExposureMin, value);
            }
        }

        public float CustomAutoExposureMax
        {
            get
            {
                return Memory.Read<float>(Base + m_flCustomAutoExposureMax);
            }
            set
            {
                Memory.Write<float>(Base + m_flCustomAutoExposureMax, value);
            }
        }

        public float CustomBloomScale
        {
            get
            {
                return Memory.Read<float>(Base + m_flCustomBloomScale);
            }
            set
            {
                Memory.Write<float>(Base + m_flCustomBloomScale, value);
            }
        }
    }
}
