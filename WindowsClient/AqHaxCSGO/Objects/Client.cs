using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects
{
    static class Client
    {
        public static float[] ViewMatrix
        {
            get
            {
                return Memory.ReadMatrix<float>(Memory.clientBase + dwViewMatrix, 16);
            }
        }

        public static void ForceAttack(bool shoot) => Memory.Write<int>(Memory.clientBase + dwForceAttack, shoot ? 5 : 4);

        public static void ForceRightAttack(bool trigger) => Memory.Write<int>(Memory.clientBase + dwForceAttack2, trigger ? 5 : 4);

        public static void ForceJump(bool jump) => Memory.Write<int>(Memory.clientBase + dwForceJump, jump ? 5 : 4);

        public static byte ForceUpdateSpectatorGlow 
        {
            get 
            {
                return Memory.Read<byte>(Memory.clientBase + force_update_spectator_glow);
            }
            set 
            {
                Memory.Write<byte>(Memory.clientBase + force_update_spectator_glow, value);
            }
        }
    }
}
