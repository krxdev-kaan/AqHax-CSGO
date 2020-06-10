using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.MemoryManagers
{
    static class OffsetManager
    {
        /**
         * Loads Offsets from a save file if you have a file like that
         */
        public static void LoadOffsets()
        {
            try
            {
                string[] contentsOfFile = File.ReadAllLines("Offsets.data"); //Read the offset save file
                foreach (string line in contentsOfFile)
                {
                    string[] props = line.Split(' '); //Split with ' ' since file is formatted like this: "offset_name offset_int32"
                    try
                    {
                        typeof(Offsets).GetField(props[0], BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty).SetValue(null, Convert.ToInt32(props[1])); //Get the variable field with offsets name and set it's value
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Field Of Offset Missing: " + props[0]); //If we got an error this means we found a offset name which doesn't confront any of the variables name
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("IO Error. Restarting the Program is recommended.");
            }
        }

        /**
         * Downloads the offsets from frk1/hazedumper repo and makes a save file out of it
         */
        public static void DownloadOffsets()
        {
            try
            {
                //StreamWriter sw = new StreamWriter(File.OpenWrite("Offsets.data"));  //Uncomment to gather all the offsets as a file
                //TextWriter tw = sw; //Uncomment to gather all the offsets as a file
                string offsetJSON = (new WebClient()).DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json"); //Download the JSON containing updated offsets (Thanks to frk1/hazedumper :))
                FieldInfo currentField = null;
                JsonTextReader reader = new JsonTextReader(new StringReader(offsetJSON)); //Init JSON Reader
                while (reader.Read()) //Starting reading and loop through
                {
                    if (reader.Value != null)
                    {
                        if (reader.TokenType == JsonToken.PropertyName) //If the type is PropertyName this means we found a offset name so let's set currentField to appropriate variable field
                        {
                            try
                            {
                                currentField = typeof(Offsets).GetField(reader.Value.ToString(), BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);
                                //Uncomment to gather all the offsets as a file
                                //if (reader.Value.ToString() != "signatures" && reader.Value.ToString() != "netvars") tw.Write(reader.Value.ToString() + " ");
                                Console.WriteLine("Prop: " + reader.Value.ToString());
                            }
                            catch
                            {
                                Console.WriteLine("Unknown Field Of Offset: {0}", reader.Value.ToString());
                            }
                        }
                        else if (reader.TokenType == JsonToken.Integer) //If we found an integer it's the value of the variable which we previously set the currentField to be
                        {
                            if (currentField != null)
                            {
                                try
                                {
                                    currentField.SetValue(null, Convert.ToInt32(reader.Value.ToString()));
                                    //tw.WriteLine(reader.Value.ToString()); //Uncomment to gather all the offsets as a file
                                    Console.WriteLine("Val: " + reader.Value);
                                }
                                catch
                                {
                                    MessageBox.Show("Could Not Access The Field: {0}", reader.Value.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Field Of Offset Is Null: {0}", reader.Value.ToString());
                                //tw.WriteLine(); //Uncomment to gather all the offsets as a file
                            }
                        }
                    }
                }

                //tw.Close(); //Uncomment to gather all the offsets as a file
                //sw.Close(); //Uncomment to gather all the offsets as a file
            }
            catch
            {
                MessageBox.Show("FATAL ERROR");
            }
        }

        /**
         * Scans the offsets by using SigScanner and NetvarManager
         */
        public static void ScanOffsets()
        {
            dwClientState = SigScanner.EngineSigScan("A1 ? ? ? ? 33 D2 6A 00 6A 00 33 C9 89 B0", 1, 0, true);
            dwClientState_GetLocalPlayer = SigScanner.EngineSigScan("8B 80 ? ? ? ? 40 C3", 2, 0, false);
            dwClientState_IsHLTV = SigScanner.EngineSigScan("80 BF ? ? ? ? ? 0F 84 ? ? ? ? 32 DB", 2, 0, false);
            dwClientState_Map = SigScanner.EngineSigScan("05 ? ? ? ? C3 CC CC CC CC CC CC CC A1", 1, 0, false);
            dwClientState_MapDirectory = SigScanner.EngineSigScan("B8 ? ? ? ? C3 05 ? ? ? ? C3", 7, 0, false);
            dwClientState_MaxPlayer = SigScanner.EngineSigScan("A1 ? ? ? ? 8B 80 ? ? ? ? C3 CC CC CC CC 55 8B EC 8A 45 08", 7, 0, false);
            dwClientState_PlayerInfo = SigScanner.EngineSigScan("8B 89 ? ? ? ? 85 C9 0F 84 ? ? ? ? 8B 01", 2, 0, false);
            dwClientState_State = SigScanner.EngineSigScan("83 B8 ? ? ? ? ? 0F 94 C0 C3", 2, 0, false);
            dwClientState_ViewAngles = SigScanner.EngineSigScan("F3 0F 11 80 ? ? ? ? D9 46 04 D9 05", 4, 0, false);
            dwClientState_ModelPrecacheTable = SigScanner.EngineSigScan("0C 3B 81 ? ? ? ? 75 11 8B 45 10 83 F8 01 7C 09 50 83", 3, 0, false);
            clientstate_delta_ticks = SigScanner.EngineSigScan("C7 87 ? ? ? ? ? ? ? ? FF 15 ? ? ? ? 83 C4 08", 2, 0, false);
            clientstate_last_outgoing_command = SigScanner.EngineSigScan("8B 8F ? ? ? ? 8B 87 ? ? ? ? 41", 2, 0, false);
            clientstate_choked_commands = SigScanner.EngineSigScan("8B 87 ? ? ? ? 41", 2, 0, false);
            clientstate_net_channel = SigScanner.EngineSigScan("8B 8F ? ? ? ? 8B 01 8B 40 18", 2, 0, false);
            dwEntityList = SigScanner.ClientSigScan("BB ? ? ? ? 83 FF 01 0F 8C ? ? ? ? 3B F8", 1, 0, true);
            dwForceAttack = SigScanner.ClientSigScan("89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 0, true);
            dwForceAttack2 = SigScanner.ClientSigScan("89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 12, true);
            dwForceBackward = SigScanner.ClientSigScan("55 8B EC 51 53 8A 5D 08", 287, 0, true);
            dwForceForward = SigScanner.ClientSigScan("55 8B EC 51 53 8A 5D 08", 245, 0, true);
            dwForceJump = SigScanner.ClientSigScan("8B 0D ? ? ? ? 8B D6 8B C1 83 CA 02", 2, 0, true);
            dwForceLeft = SigScanner.ClientSigScan("55 8B EC 51 53 8A 5D 08", 465, 0, true);
            dwForceRight = SigScanner.ClientSigScan("55 8B EC 51 53 8A 5D 08", 512, 0, true);
            dwGameDir = SigScanner.EngineSigScan("68 ? ? ? ? 8D 85 ? ? ? ? 50 68 ? ? ? ? 68", 1, 0, true);
            dwGameRulesProxy = SigScanner.ClientSigScan("A1 ? ? ? ? 85 C0 0F 84 ? ? ? ? 80 B8 ? ? ? ? ? 74 7A", 1, 0, true);
            dwGetAllClasses = SigScanner.ClientSigScan("A1 ? ? ? ? C3 CC CC CC CC CC CC CC CC CC CC A1 ? ? ? ? B9", 1, 0, true);
            dwGlobalVars = SigScanner.EngineSigScan("68 ? ? ? ? 68 ? ? ? ? FF 50 08 85 C0", 1, 0, true);
            dwGlowObjectManager = SigScanner.ClientSigScan("A1 ? ? ? ? A8 01 75 4B", 1, 4, true);
            dwInput = SigScanner.ClientSigScan("B9 ? ? ? ? F3 0F 11 04 24 FF 50 10", 1, 0, true);
            dwInterfaceLinkList = SigScanner.ClientSigScan("8B 35 ? ? ? ? 57 85 F6 74 ? 8B 7D 08 8B 4E 04 8B C7 8A 11 3A 10", 0, 0, true);
            dwLocalPlayer = SigScanner.ClientSigScan("8D 34 85 ? ? ? ? 89 15 ? ? ? ? 8B 41 08 8B 48 04 83 F9 FF", 3, 4, true);
            dwMouseEnable = SigScanner.ClientSigScan("B9 ? ? ? ? FF 50 34 85 C0 75 10", 1, 48, true);
            dwMouseEnablePtr = SigScanner.ClientSigScan("B9 ? ? ? ? FF 50 34 85 C0 75 10", 1, 0, true);
            dwPlayerResource = SigScanner.ClientSigScan("8B 3D ? ? ? ? 85 FF 0F 84 ? ? ? ? 81 C7", 2, 0, true);
            dwRadarBase = SigScanner.ClientSigScan("A1 ? ? ? ? 8B 0C B0 8B 01 FF 50 ? 46 3B 35 ? ? ? ? 7C EA 8B 0D", 1, 0, true);
            dwSensitivity = SigScanner.ClientSigScan("81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 18 35 ? ? ? ? 89 44 24 0C EB 0B", 2, 44, true);
            dwSensitivityPtr = SigScanner.ClientSigScan("81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 18 35 ? ? ? ? 89 44 24 0C EB 0B", 2, 0, true);
            dwSetClanTag = SigScanner.EngineSigScan("53 56 57 8B DA 8B F9 FF 15", 0, 0, true);
            dwViewMatrix = SigScanner.ClientSigScan("0F 10 05 ? ? ? ? 8D 85 ? ? ? ? B9", 3, 176, true);
            dwWeaponTable = SigScanner.ClientSigScan("B9 ? ? ? ? 6A 00 FF 50 08 C3", 1, 0, true);
            dwWeaponTableIndex = SigScanner.ClientSigScan("39 86 ? ? ? ? 74 06 89 86 ? ? ? ? 8B 86", 2, 0, false);
            dwYawPtr = SigScanner.ClientSigScan("81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 1C 35 ? ? ? ? 89 44 24 18 EB 0B 8B 01 8B 40 30 FF D0 D9 5C 24 18 F3 0F 10 06", 2, 0, true);
            dwZoomSensitivityRatioPtr = SigScanner.ClientSigScan("81 F9 ? ? ? ? 75 1A F3 0F 10 05 ? ? ? ? F3 0F 11 45 ? 8B 45 F4 35 ? ? ? ? 89 45 FC EB 0A 8B 01 8B 40 30 FF D0 D9 5D FC A1", 2, 0, true);
            dwbSendPackets = SigScanner.EngineSigScan("B3 01 8B 01 8B 40 10 FF D0 84 C0 74 0F 80 BF ? ? ? ? ? 0F 84", 0, 1, true);
            dwppDirect3DDevice9 = SigScanner.ClientSigScan("A1 ? ? ? ? 50 8B 08 FF 51 0C", 1, 0, true);
            m_pStudioHdr = SigScanner.ClientSigScan("8B B6 ? ? ? ? 85 F6 74 05 83 3E 00 75 02 33 F6 F3 0F 10 44 24", 2, 0, false);
            m_yawClassPtr = SigScanner.ClientSigScan("81 F9 ? ? ? ? 75 16 F3 0F 10 05 ? ? ? ? F3 0F 11 45 ? 81 75 ? ? ? ? ? EB 0A 8B 01 8B 40 30 FF D0 D9 5D 0C 8B 55 08", 2, 0, true);
            m_pitchClassPtr = SigScanner.ClientSigScan("A1 ? ? ? ? 89 74 24 28", 1, 0, true);
            interface_engine_cvar = SigScanner.ClientSigScan("8B 0D ? ? ? ? C7 05", 2, 0, true);
            convar_name_hash_table = SigScanner.ClientSigScan("8B 3C 85", 3, 0, true);
            m_bDormant = SigScanner.ClientSigScan("8A 81 ? ? ? ? C3 32 C0", 2, 8, false);
            model_ambient_min = SigScanner.EngineSigScan("F3 0F 10 0D ? ? ? ? F3 0F 11 4C 24 ? 8B 44 24 20 35 ? ? ? ? 89 44 24 0C", 4, 0, true);
            set_abs_angles = SigScanner.ClientSigScan("55 8B EC 83 E4 F8 83 EC 64 53 56 57 8B F1 E8", 0, 0, true);
            set_abs_origin = SigScanner.ClientSigScan("55 8B EC 83 E4 F8 51 53 56 57 8B F1 E8", 0, 0, true);
            is_c4_owner = SigScanner.ClientSigScan("56 8B F1 85 F6 74 31", 0, 0, true);
            force_update_spectator_glow = SigScanner.ClientSigScan("74 07 8B CB E8 ? ? ? ? 83 C7 10", 0, 0, true);
            //dwClientCmd = SigScanner.EngineSigScan("55 8B EC 8B 0D ? ? ? ? 81 F9 ? ? ? ? 75 0C A1 ? ? ? ? 35 ? ? ? ? EB 05 8B 01 FF 50 34 50", 0, 0, true);
            //Console.WriteLine(dwClientCmd);
            
            GC.Collect();



            m_ArmorValue = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_ArmorValue");
            m_Collision = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_Collision");
            m_CollisionGroup = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_CollisionGroup");
            m_Local = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_Local");
            m_MoveType = 1 + NetvarManager.GetOffsetByName("DT_CSPlayer", "m_nRenderMode");
            m_OriginalOwnerXuidHigh = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_OriginalOwnerXuidHigh");
            m_OriginalOwnerXuidLow = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_OriginalOwnerXuidLow");
            m_aimPunchAngle = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_aimPunchAngle");
            m_aimPunchAngleVel = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_aimPunchAngleVel");
            m_bGunGameImmunity = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bGunGameImmunity");
            m_bHasDefuser = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bHasDefuser");
            m_bHasHelmet = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bHasHelmet");
            m_bInReload = 109 + NetvarManager.GetOffsetByName("DT_BaseCombatWeapon", "m_flNextPrimaryAttack");
            m_bIsDefusing = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bIsDefusing");
            m_bIsScoped = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bIsScoped");
            m_bSpotted = NetvarManager.GetOffsetByName("DT_BaseEntity", "m_bSpotted");
            m_bSpottedByMask = NetvarManager.GetOffsetByName("DT_BaseEntity", "m_bSpottedByMask");
            m_dwBoneMatrix = 28 + NetvarManager.GetOffsetByName("DT_BaseAnimating", "m_nForceBone");
            m_fAccuracyPenalty = NetvarManager.GetOffsetByName("DT_WeaponCSBase", "m_fAccuracyPenalty");
            m_fFlags = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_fFlags");
            m_flFallbackWear = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_flFallbackWear");
            m_flFlashDuration = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flFlashDuration");
            m_flFlashMaxAlpha = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flFlashMaxAlpha");
            m_flNextPrimaryAttack = NetvarManager.GetOffsetByName("DT_BaseCombatWeapon", "m_flNextPrimaryAttack");
            m_hActiveWeapon = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_hActiveWeapon");
            m_hMyWeapons = -256 + NetvarManager.GetOffsetByName("DT_BasePlayer", "m_hActiveWeapon");
            m_hObserverTarget = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_hObserverTarget");
            m_hOwner = NetvarManager.GetOffsetByName("DT_PredictedViewModel", "m_hOwner");
            m_hOwnerEntity = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_hOwnerEntity");
            m_iAccountID = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_iAccountID");
            m_iClip1 = NetvarManager.GetOffsetByName("DT_BaseCombatWeapon", "m_iClip1");
            m_iCompetitiveRanking = NetvarManager.GetOffsetByName("DT_CSPlayerResource", "m_iCompetitiveRanking");
            m_iCompetitiveWins = NetvarManager.GetOffsetByName("DT_CSPlayerResource", "m_iCompetitiveWins");
            m_iCrosshairId = 92 + NetvarManager.GetOffsetByName("DT_CSPlayer", "m_bHasDefuser");
            m_iEntityQuality = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_iEntityQuality");
            m_iFOVStart = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_iFOVStart");
            m_iFOV = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_iFOV");
            m_iGlowIndex = 24 + NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flFlashDuration");
            m_iHealth = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_iHealth");
            m_iItemDefinitionIndex = NetvarManager.GetOffsetByName("DT_BaseCombatWeapon", "m_iItemDefinitionIndex");
            m_iItemIDHigh = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_iItemIDHigh");
            m_iObserverMode = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_iObserverMode");
            m_iShotsFired = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_iShotsFired");
            m_iState = NetvarManager.GetOffsetByName("DT_BaseCombatWeapon", "m_iState");
            m_iTeamNum = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_iTeamNum");
            m_lifeState = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_lifeState");
            m_nFallbackPaintKit = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_nFallbackPaintKit");
            m_nFallbackSeed = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_nFallbackSeed");
            m_nFallbackStatTrak = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_nFallbackStatTrak");
            m_nForceBone = NetvarManager.GetOffsetByName("DT_BaseAnimating", "m_nForceBone");
            m_nTickBase = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_nTickBase");
            m_rgflCoordinateFrame = -48 + NetvarManager.GetOffsetByName("DT_CSPlayer", "m_CollisionGroup");
            m_szCustomName = NetvarManager.GetOffsetByName("DT_BaseAttributableItem", "m_szCustomName");
            m_szLastPlaceName = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_szLastPlaceName");
            m_vecOrigin = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_vecOrigin");
            m_vecVelocity = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_vecVelocity[0]");
            m_vecViewOffset = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_vecViewOffset[0]");
            m_viewPunchAngle = NetvarManager.GetOffsetByName("DT_BasePlayer", "m_viewPunchAngle");
            m_thirdPersonViewAngles = 4 + NetvarManager.GetOffsetByName("DT_CSPlayer", "deadflag");
            m_clrRender = NetvarManager.GetOffsetByName("DT_BaseEntity", "m_clrRender");
            m_flC4Blow = NetvarManager.GetOffsetByName("DT_PlantedC4", "m_flC4Blow");
            m_flTimerLength = NetvarManager.GetOffsetByName("DT_PlantedC4", "m_flTimerLength");
            m_flDefuseLength = NetvarManager.GetOffsetByName("DT_PlantedC4", "m_flDefuseLength");
            m_flDefuseCountDown = NetvarManager.GetOffsetByName("DT_PlantedC4", "m_flDefuseCountDown");
            cs_gamerules_data = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "cs_gamerules_data");
            m_SurvivalRules = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_SurvivalRules");
            m_SurvivalGameRuleDecisionTypes = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_SurvivalGameRuleDecisionTypes");
            m_bIsValveDS = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_bIsValveDS");
            m_bFreezePeriod = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_bFreezePeriod");
            m_bBombPlanted = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_bBombPlanted");
            m_bIsQueuedMatchmaking = NetvarManager.GetOffsetByName("DT_CSGameRulesProxy", "m_bIsQueuedMatchmaking");
            m_flSimulationTime = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flSimulationTime");
            m_flLowerBodyYawTarget = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flLowerBodyYawTarget");
            m_angEyeAnglesX = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_angEyeAngles[0]");
            m_angEyeAnglesY = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_angEyeAngles[1]");
            m_flNextAttack = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_flNextAttack");
            m_iMostRecentModelBoneCounter = 4 + NetvarManager.GetOffsetByName("DT_CSPlayer", "m_nForceBone");
            m_flLastBoneSetupTime = 104 + NetvarManager.GetOffsetByName("DT_BaseAnimating", "m_nSequence");
            m_bStartedArming = NetvarManager.GetOffsetByName("DT_WeaponC4", "m_bStartedArming");
            /* m_bUseCustomBloomScale = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_bUseCustomBloomScale");             // I MAY ADD THESE IF I NEED
            m_bUseCustomAutoExposureMin = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_bUseCustomAutoExposureMin");      // I MAY ADD THESE IF I NEED
            m_bUseCustomAutoExposureMax = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_bUseCustomAutoExposureMax");      // I MAY ADD THESE IF I NEED
            m_flCustomBloomScale = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_flCustomBloomScale");                    // I MAY ADD THESE IF I NEED
            m_flCustomAutoExposureMin = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_flCustomAutoExposureMin");          // I MAY ADD THESE IF I NEED
            m_flCustomAutoExposureMax = NetvarManager.GetOffsetByName("DT_EnvTonemapController", "m_flCustomAutoExposureMax"); */       // I MAY ADD THESE IF I NEED
            m_iViewModelIndex = NetvarManager.GetOffsetByName("DT_WeaponCSBase", "m_iViewModelIndex");
            m_iWorldModelIndex = NetvarManager.GetOffsetByName("DT_WeaponCSBase", "m_iWorldModelIndex");
            m_iWorldDroppedModelIndex = NetvarManager.GetOffsetByName("DT_WeaponCSBase", "m_iWorldDroppedModelIndex");
            m_hViewModel = NetvarManager.GetOffsetByName("DT_CSPlayer", "m_hViewModel[0]");
            m_nModelIndex = NetvarManager.GetOffsetByName("DT_BaseViewModel", "m_nModelIndex");
        }
    }
}
