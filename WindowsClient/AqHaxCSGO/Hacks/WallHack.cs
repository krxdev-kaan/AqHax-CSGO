using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AqHaxCSGO.Objects;
using AqHaxCSGO.Objects.Structs;
using static AqHaxCSGO.Objects.GlobalLists;

namespace AqHaxCSGO.Hacks
{
    static class WallHack
    {
        public static void WallHackThread()
        {
            while (true)
            {
                if (!Globals.WallHackEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                int mp = EngineDLL.MaxPlayer;
                for (int i = 0; i < mp; i++)
                {
                    CCSPlayer entity = entityList[i] as CCSPlayer;
                    if (entity == null) continue;
                    if (entity.Dormant) continue;
                    if (entity.Health <= 0) continue;

                    if (entity.Team != CBasePlayer.Team)
                    {
                        GlowObject glowObject = entityList[i].GlowObject;
                        glowObject.r = Globals.WallHackEnemy.R / 255;
                        glowObject.g = Globals.WallHackEnemy.G / 255;
                        glowObject.b = Globals.WallHackEnemy.B / 255;
                        glowObject.a = 0.7f;
                        glowObject.m_bFullBloom = Globals.WallHackFullEnabled;
                        glowObject.m_nGlowStyle = Globals.WallHackGlowOnly ? 1 : 0;
                        glowObject.m_bRenderWhenOccluded = true;
                        glowObject.m_bRenderWhenUnoccluded = false;

                        entityList[i].GlowObject = glowObject;
                    }
                    else
                    {
                        GlowObject glowObject = entityList[i].GlowObject;
                        glowObject.r = 0 / 255;
                        glowObject.g = 255 / 255;
                        glowObject.b = 0 / 255;
                        glowObject.a = 0.7f;
                        glowObject.m_bFullBloom = Globals.WallHackFullEnabled;
                        glowObject.m_nGlowStyle = Globals.WallHackGlowOnly ? 1 : 0;
                        glowObject.m_bRenderWhenOccluded = true;
                        glowObject.m_bRenderWhenUnoccluded = false;

                        entityList[i].GlowObject = glowObject;
                    }
                }

                Thread.Sleep(Globals.UsageDelay);
            }
        }

        public static void RenderColorThread()
        {
            while (true)
            {
                if (!Globals.RenderEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                int mp = EngineDLL.MaxPlayer;
                for (int i = 0; i < mp; i++)
                {
                    CCSPlayer entity = entityList[i] as CCSPlayer;
                    if (entity == null) continue;
                    if (entity.Dormant) continue;
                    if (entity.Health <= 0) continue;

                    if (entity.Team != CBasePlayer.Team)
                    {
                        RenderColor rco = new RenderColor();
                        rco.r = Globals.RenderColor.R;
                        rco.g = Globals.RenderColor.G;
                        rco.b = Globals.RenderColor.B;
                        rco.a = 255;
                        entity.RenderColor = rco;
                    }

                    if (Globals.RenderEnemyOnly) continue;

                    RenderColor rc = new RenderColor();
                    rc.r = Globals.RenderColor.R;
                    rc.g = Globals.RenderColor.G;
                    rc.b = Globals.RenderColor.B;
                    rc.a = 255;
                    entity.RenderColor = rc;
                }

                Thread.Sleep(Globals.UsageDelay);
            }
        }

        public static void RadarThread() 
        {
            while (true) 
            {
                if (!Globals.RadarEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                int mp = EngineDLL.MaxPlayer;
                for (int i = 0; i < mp; i++)
                {
                    CCSPlayer entity = entityList[i] as CCSPlayer;
                    if (entity == null) continue;
                    if (entity.Dormant) continue;
                    if (entity.Team == CBasePlayer.Team) continue;

                    if (!entity.Spotted) entity.Spotted = true;
                }

                Thread.Sleep(Globals.UsageDelay);
            }
        }
    }
}
