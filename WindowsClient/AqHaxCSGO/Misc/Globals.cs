using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AqHaxCSGO.Objects.Structs;
using AqHaxCSGO.Misc;

namespace AqHaxCSGO.Objects
{
    static class Globals
    {
        public static bool WallHackEnabled = false;
        public static bool WallHackFullEnabled = false;
        public static bool WallHackGlowOnly = false;
        public static Color WallHackEnemy = Color.Red;
        public static Color WallHackTeammate = Color.Green;

        public static bool RenderEnabled = false;
        public static bool RenderEnemyOnly = false;
        public static Color RenderColor = Color.Red;

        public static bool RadarEnabled = false;

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
        public static HitboxGroup AimPosition = HitboxGroup.ENTITY_HEAD;

        public static bool TriggerEnabled = false;
        public static bool TriggerPressOnlyEnabled = false;

        public static bool AntiFlashEnabled = false;
        public static bool BunnyHopEnabled = false;

        public static bool SkinChangerEnabled = false;
        public static bool KnifeChangerEnabled = false;
        public static bool ManualLoadEnabled = false;





        private static int _BunnyHopDelay = 1;
        public static int BunnyHopAccuracy {
            get 
            {
                return _BunnyHopDelay;
            }
            set 
            {
                _BunnyHopDelay = 5 - value;
            }
        }

        private static int _IdleWait = 10;
        public static int IdleWait
        {
            get
            {
                return _IdleWait;
            }
            set
            {
                _IdleWait = 50 - (value * 10);
            }
        }

        private static int _UsageDelay = 1;
        public static int UsageDelay
        {
            get
            {
                return _UsageDelay;
            }
            set
            {
                _UsageDelay = 5 - value;
            }
        }
        public static int TriggerKey = 16;



        public static Dictionary<string, SkinObj> CsgoSkinList = new Dictionary<string, SkinObj>();
        public static List<Skin> LoadedPresets = new List<Skin>();
    }

    static class GlobalLists
    {
        public static EntityList entityList = new EntityList();
        public static WeaponList weaponList = new WeaponList();
    }
}
