using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AqHaxCSGO.Hacks;
using AqHaxCSGO.Hacks.Features;

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
        static Thread chatBotThread = new Thread(ChatBot.ChatBotThread);

        public static void InitAll()
        {
            bunnyThread.IsBackground = true;
            antiFlashThread.IsBackground = true;
            wallThread.IsBackground = true;
            renderThread.IsBackground = true;
            aimThread.IsBackground = true;
            triggerThread.IsBackground = true;
            radarThread.IsBackground = true;
            chatBotThread.IsBackground = true;

            bunnyThread.Start();
            antiFlashThread.Start();
            wallThread.Start();
            renderThread.Start();
            aimThread.Start();
            triggerThread.Start();
            radarThread.Start();
            chatBotThread.Start();
        }
    }
}
