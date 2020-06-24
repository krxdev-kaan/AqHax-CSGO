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
    class KnifeObj 
    {
        public ItemDefinitionIndex itemDefinitionIndex;
        public string modelName;

        public KnifeObj(ItemDefinitionIndex i, string m) 
        {
            this.itemDefinitionIndex = i;
            this.modelName = m;
        }
    }

    static class Constants 
    {
        public static Dictionary<string, KnifeObj> KnifeList = InitializeList();

        private static Dictionary<string, KnifeObj> InitializeList() 
        {
            Dictionary<string, KnifeObj> res = new Dictionary<string, KnifeObj>();

            string[] listNames = {  "Bayonet",
                                    "Flip Knife",
                                    "Gut Knife",
                                    "Karambit",
                                    "M9 Bayonet",
                                    "Huntsman Knife",
                                    "Falchion Knife",
                                    "Bowie Knife",
                                    "Butterfly Knife",
                                    "Shadow Daggers",
                                    "Ursus Knife",
                                    "Navaja Knife",
                                    "Stiletto Knife",
                                    "Talon Knife",
                                    "Classic Knife",
                                    "Paracord Knife",
                                    "Survival Knife",
                                    "Nomad Knife",
                                    "Skeleton Knife" };

            string[] itemDefNames = {"WEAPON_KNIFE_BAYONET",
                                    "WEAPON_KNIFE_FLIP",
                                    "WEAPON_KNIFE_GUT",
                                    "WEAPON_KNIFE_KARAMBIT",
                                    "WEAPON_KNIFE_M9_BAYONET",
                                    "WEAPON_KNIFE_TACTICAL",
                                    "WEAPON_KNIFE_FALCHION",
                                    "WEAPON_KNIFE_SURVIVAL_BOWIE",
                                    "WEAPON_KNIFE_BUTTERFLY",
                                    "WEAPON_KNIFE_PUSH",
                                    "WEAPON_KNIFE_URSUS",
                                    "WEAPON_KNIFE_GYPSY_JACKKNIFE",
                                    "WEAPON_KNIFE_STILETTO",
                                    "WEAPON_KNIFE_WIDOWMAKER",
                                    "WEAPON_KNIFE_CSS",
                                    "WEAPON_KNIFE_CORD",
                                    "WEAPON_KNIFE_CANIS",
                                    "WEAPON_KNIFE_OUTDOOR",
                                    "WEAPON_KNIFE_SKELETON" };

            string[] knifeModels = {"models/weapons/v_knife_bayonet.mdl",
                                    "models/weapons/v_knife_flip.mdl",
                                    "models/weapons/v_knife_gut.mdl",
                                    "models/weapons/v_knife_karam.mdl",
                                    "models/weapons/v_knife_m9_bay.mdl",
                                    "models/weapons/v_knife_tactical.mdl",
                                    "models/weapons/v_knife_falchion_advanced.mdl",
                                    "models/weapons/v_knife_survival_bowie.mdl",
                                    "models/weapons/v_knife_butterfly.mdl",
                                    "models/weapons/v_knife_push.mdl",
                                    "models/weapons/v_knife_ursus.mdl",
                                    "models/weapons/v_knife_gypsy_jackknife.mdl",
                                    "models/weapons/v_knife_stiletto.mdl",
                                    "models/weapons/v_knife_widowmaker.mdl",
                                    "models/weapons/v_knife_css.mdl",
                                    "models/weapons/v_knife_cord.mdl",
                                    "models/weapons/v_knife_canis.mdl",
                                    "models/weapons/v_knife_outdoor.mdl",
                                    "models/weapons/v_knife_skeleton.mdl" };

            for (int i = 0; i < 19; i++) 
            {
                res.Add(listNames[i], new KnifeObj( (ItemDefinitionIndex)Enum.Parse(typeof(ItemDefinitionIndex), itemDefNames[i]), knifeModels[i]));
                Console.WriteLine((int)((ItemDefinitionIndex)Enum.Parse(typeof(ItemDefinitionIndex), itemDefNames[i])));
            }

            return res;
        } 
    }

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
        public static bool KnifeChangerAnimFixEnabled = false;
        public static bool ManualLoadEnabled = false;
        public static string SelectedKnife = "Bayonet";





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
