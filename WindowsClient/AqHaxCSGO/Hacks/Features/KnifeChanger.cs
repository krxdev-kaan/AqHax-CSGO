using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AqHaxCSGO.Objects;

namespace AqHaxCSGO.Hacks.Features
{
    static class KnifeChanger
    {
        public static void KnifeChangerThread()
        {
            while (true)
            {
                if (!Globals.KnifeChangerEnabled)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }
                if (!EngineDLL.InGame)
                {
                    Thread.Sleep(Globals.IdleWait);
                    continue;
                }

                //IMPLEMENT TOMORROW

                Thread.Sleep(Globals.IdleWait);
            }
        }
    }
}
