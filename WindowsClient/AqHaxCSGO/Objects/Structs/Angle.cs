using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqHaxCSGO.Objects
{
    public struct Angle
    {
        public float x;
        public float y;

        public Angle(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Angle operator *(Angle v1, float v2)
        {
            return new Angle(v1.x * v2, v1.y * v2);
        }
    }
}
