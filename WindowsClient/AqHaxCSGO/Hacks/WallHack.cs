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
            Console.WriteLine("wallhack init");
            while (true)
            {
                if (!Globals.WallHackEnabled)
                {
                    Thread.Sleep(10);
                    continue;
                }
                if (!Engine.InGame)
                {
                    Thread.Sleep(10);
                    continue;
                }

                int mp = Engine.MaxPlayer;
                for (int i = 0; i < mp; i++)
                {
                    if (entityList[i].Dormant) continue;
                    if (entityList[i].Health <= 0) continue;

                    if (entityList[i].Team != LocalPlayer.Team)
                    {
                        GlowObject glowObject = entityList[i].GlowObject;
                        glowObject.r = Globals.WallHackEnemy.R / 255;
                        glowObject.g = Globals.WallHackEnemy.G / 255;
                        glowObject.b = Globals.WallHackEnemy.B / 255;
                        glowObject.a = 0.7f;
                        glowObject.m_bFullBloom = Globals.WallHackFullEnabled;
                        glowObject.m_nGlowStyle = Globals.WallHackGlowOnly ? 1 : 0;
                        glowObject.m_bRenderWhenOccluded = false;
                        glowObject.m_bRenderWhenUnoccluded = true;

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
                        glowObject.m_bRenderWhenOccluded = false;
                        glowObject.m_bRenderWhenUnoccluded = true;

                        entityList[i].GlowObject = glowObject;
                    }
                }

                Thread.Sleep(3);
            }
        }

        public static void RenderColorThread()
        {
            while (true)
            {
                if (!Globals.RenderEnabled)
                {
                    Thread.Sleep(10);
                    continue;
                }
                if (!Engine.InGame)
                {
                    Thread.Sleep(10);
                    continue;
                }

                int mp = Engine.MaxPlayer;
                for (int i = 0; i < mp; i++)
                {
                    if (entityList[i].Dormant) continue;
                    if (entityList[i].Health <= 0) continue;

                    if (entityList[i].Team != LocalPlayer.Team)
                    {
                        RenderColor rco = new RenderColor();
                        rco.r = Globals.RenderColor.R;
                        rco.g = Globals.RenderColor.G;
                        rco.b = Globals.RenderColor.B;
                        rco.a = 255;
                        entityList[i].RenderColor = rco;
                    }

                    if (Globals.RenderEnemyOnly) continue;

                    RenderColor rc = new RenderColor();
                    rc.r = Globals.RenderColor.R;
                    rc.g = Globals.RenderColor.G;
                    rc.b = Globals.RenderColor.B;
                    rc.a = 255;
                    entityList[i].RenderColor = rc;
                }

                Thread.Sleep(3);
            }
        }
    }
}
