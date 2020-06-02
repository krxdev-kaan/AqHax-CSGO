using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AqHaxCSGO.Hacks;

namespace AqHaxCSGO
{
    static class Threads
    {
        static Thread bunnyThread = new Thread(Others.BunnyThread);
        static Thread antiFlashThread = new Thread(Others.FlashThread);
        static Thread wallThread = new Thread(WallHack.WallHackThread);
        static Thread renderThread = new Thread(WallHack.RenderColorThread);
        static Thread aimThread = new Thread(Aimbot.AimbotThread);
        static Thread triggerThread = new Thread(Aimbot.TriggerThread);
        static Thread radarThread = new Thread(WallHack.RadarThread);

        public static void InitAll()
        {
            Console.WriteLine("threads starting");

            bunnyThread.IsBackground = true;
            antiFlashThread.IsBackground = true;
            wallThread.IsBackground = true;
            renderThread.IsBackground = true;
            aimThread.IsBackground = true;
            triggerThread.IsBackground = true;
            radarThread.IsBackground = true;

            bunnyThread.Start();
            antiFlashThread.Start();
            wallThread.Start();
            renderThread.Start();
            aimThread.Start();
            triggerThread.Start();
            radarThread.Start();
        }
    }
}
