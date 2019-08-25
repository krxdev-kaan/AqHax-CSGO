using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AqHaxCSGO.Objects.Structs;

namespace AqHaxCSGO.Objects
{
    static class Globals
    {
        public static bool WallHackEnabled = false;
        public static bool WallHackFullEnabled = false;
        public static bool WallHackGlowOnly = false;
        public static Color WallHackEnemy = Color.Red;

        public static bool RenderEnabled = false;
        public static bool RenderEnemyOnly = false;
        public static Color RenderColor = Color.Red;

        public static bool ESPEnabled = false;
        public static bool ESPSkeletonEnabled = false;
        public static bool ESPHealthEnabled = false;
        public static bool ESPName = false;
        public static bool ESPDebugSkeleton = false;

        public static bool AimEnabled = false;
        public static bool AimRecoil = false;
        public static bool AimShootOnCollide = false;
        public static bool AimSilent = false;
        public static bool AimAutoBot = false;
        public static Hitbox AimPosition = Hitbox.ENTITY_HEAD;

        public static bool TriggerEnabled = false;
        public static bool TriggerPressOnlyEnabled = false;

        public static bool AntiFlashEnabled = false;

        public static bool BunnyHopEnabled = false;
    }
}
