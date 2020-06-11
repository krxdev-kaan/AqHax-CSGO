using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqHaxCSGO.Misc
{
    class Skin
    {
        public int WeaponID;
        public int PaintKit;
        public int Seed;
        public float Wear;
        public string CustomName;

        public Skin(int i, int p, int s, float w, string c) 
        {
            this.WeaponID = i;
            this.PaintKit = p;
            this.Seed = s;
            this.Wear = w;
            this.CustomName = c;
        }
    }

    class SkinObj 
    {
        public int SkinID;
        public string SkinName;

        public SkinObj(int i, string n) 
        {
            this.SkinID = i;
            this.SkinName = n;
        }
    }
}
