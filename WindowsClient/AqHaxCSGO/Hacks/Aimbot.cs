using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using AqHaxCSGO.Objects;
using AqHaxCSGO.Objects.Structs;
using static System.Math;
using static AqHaxCSGO.Objects.GlobalLists;

namespace AqHaxCSGO.Hacks
{
    static class Aimbot
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetAsyncKeyState(
            int vKey
        );

        public static void TriggerThread()
        {
            while (true)
            {
                if (!Globals.TriggerEnabled && !Globals.AimShootOnCollide)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                if (Globals.TriggerPressOnlyEnabled && !Globals.AimShootOnCollide)
                {
                    if ((GetAsyncKeyState(Globals.TriggerKey) & 0x8000) > 0)
                    {
                        if (CBasePlayer.CrosshairID > 0 && CBasePlayer.CrosshairID < EngineDLL.MaxPlayer + 2)
                        {
                            CCSPlayer crossEntity = entityList[CBasePlayer.CrosshairID - 1] as CCSPlayer;
                            if (crossEntity == null) continue; // TRIGGER BOT CRASH FIX
                            if (crossEntity != null && crossEntity.Team != CBasePlayer.Team)
                            {
                                Thread.Sleep(1);
                                ClientDLL.ForceAttack(true);
                                Thread.Sleep(5);
                                ClientDLL.ForceAttack(false);
                            }
                        }
                    }
                }
                else
                {
                    if (CBasePlayer.CrosshairID > 0 && CBasePlayer.CrosshairID < EngineDLL.MaxPlayer + 2)
                    {
                        CCSPlayer crossEntity = entityList[CBasePlayer.CrosshairID - 1] as CCSPlayer;
                        if (crossEntity == null) continue;
                        if (crossEntity != null && crossEntity.Team != CBasePlayer.Team)
                        {
                            Thread.Sleep(1);
                            ClientDLL.ForceAttack(true);
                            Thread.Sleep(5);
                            ClientDLL.ForceAttack(false);
                        }
                    }
                }

                Thread.Sleep(2);
            }
        }

        public static void AimbotThread()
        {
            while (true)
            {
                if (!Globals.AimEnabled)
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
                Rectangle screen = Misc.GetWindowRect();
                Vector2 screenOrigin = new Vector2(screen.Width / 2, screen.Height / 2);
                double latestDistance = screen.Width;
                Vector3 closestEntityPos = new Vector3(99999f, 0f, 0f);
                for (int i = 0; i < mp; i++)
                {
                    CCSPlayer entity = entityList[i] as CCSPlayer;
                    if (entity == null) continue;
                    if (entity.Dormant) continue;
                    if (entity.Health <= 0) continue;
                    if (entity.Team == CBasePlayer.Team) continue;

                    Vector3 entSelectedPos = entity.GetBonePosition((int)Globals.AimPosition);
                    Vector2 entPosOnScreen;
                    if (entSelectedPos.PointOnScreen(out entPosOnScreen))
                    {
                        if (entPosOnScreen.x > screen.Width || entPosOnScreen.x < 0 || entPosOnScreen.y > screen.Height || entPosOnScreen.y < 0)
                        {
                            continue;
                        }
                    }
                    else continue;

                    double dist = Sqrt(Pow(screenOrigin.x - entPosOnScreen.x, 2) + Pow(screenOrigin.y - entPosOnScreen.y, 2));
                    if (dist < latestDistance)
                    {
                        latestDistance = dist;
                        closestEntityPos = entSelectedPos;
                    }
                }

                if (closestEntityPos.x != 99999f && (GetAsyncKeyState(Globals.TriggerKey) & 0x8000) > 0)
                {
                    Angle AimAt = CalcAngle(CBasePlayer.VectorEyeLevel, closestEntityPos);

                    if (Globals.AimRecoil)
                    {
                        Angle Punch = CBasePlayer.ViewPunchAngle * 2.0f;
                        AimAt.x -= Punch.x;
                        AimAt.y -= Punch.y;
                    }

                    CBasePlayer.ViewAngle = AimAt;

                    if (!Globals.AimShootOnCollide)
                    {
                        if (weaponList.ActiveWeapon.IsSniper())
                        {
                            ClientDLL.ForceRightAttack(true);
                            Thread.Sleep(2);
                            ClientDLL.ForceAttack(true);
                            Thread.Sleep(5);
                            ClientDLL.ForceRightAttack(false);
                            ClientDLL.ForceAttack(false);
                        }
                        else
                        {
                            Thread.Sleep(1);
                            ClientDLL.ForceAttack(true);
                            Thread.Sleep(5);
                            ClientDLL.ForceAttack(false);
                        }
                    }
                }

                Thread.Sleep(Globals.UsageDelay);
            }
        }

        static Angle CalcAngle(Vector3 src, Vector3 dst)
        {

            Angle angles;
            Vector3 e = new Vector3(dst.x - src.x, dst.y - src.y, dst.z - src.z);
            float eh = (float)Sqrt(e.x * e.x + e.y * e.y);

            angles.x = (float)(Atan2(-e.z, eh) * 180 / PI);
            angles.y = (float)(Atan2(e.y, e.x) * 180 / PI);

            return angles;
        }
    }
}
