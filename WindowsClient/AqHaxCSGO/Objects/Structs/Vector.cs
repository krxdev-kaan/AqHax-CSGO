using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using System.Threading.Tasks;

namespace AqHaxCSGO.Objects
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //IMPLEMENT LATER
        //IMPLEMENT LATER 
        //IMPLEMENT LATER
        //Not enough time for finding the window size
        /*public bool PointOnScreen(out Vector2 OUT)
        {
            float[] ViewMatrix = Client.ViewMatrix;

            OUT = new Vector2();
            var w = 0.0f;

            OUT.x = ViewMatrix[0] * this.x + ViewMatrix[1] * this.y + ViewMatrix[2] * this.z + ViewMatrix[3];
            OUT.y = ViewMatrix[4] * this.x + ViewMatrix[5] * this.y + ViewMatrix[6] * this.z + ViewMatrix[7];
            w = ViewMatrix[12] * this.x + ViewMatrix[13] * this.y + ViewMatrix[14] * this.z + ViewMatrix[15];

            if (w < 0.01f)
                return false;

            var invw = 1.0f / w;
            OUT.x *= invw;
            OUT.y *= invw;

            var width = window.Width;
            var height = window.Height;

            float x = width / 2;
            float y = height / 2;

            x += 0.5f * OUT.x * width + 0.5f;
            y -= 0.5f * OUT.y * height + 0.5f;

            OUT.x = x;
            OUT.y = y;
            return true;
        }*/

        public static Vector3 Zero
        {
            get
            {
                return new Vector3(0f, 0f, 0f);
            }
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        public static Vector3 operator /(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
        }

        public static float Distance3D(Vector3 v1, Vector3 v2)
        {
            return (float)Sqrt(Pow(v1.x - v2.x, 2) + Pow(v1.y - v2.y, 2) + Pow(v1.z - v2.z, 2));
        }
    }

    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }

        public static Vector2 operator *(Vector2 v1, float v2)
        {
            return new Vector2(v1.x * v2, v1.y * v2);
        }

        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x * v2.x, v1.y * v2.y);
        }

        public static Vector2 operator /(Vector2 v1, float v2)
        {
            return new Vector2(v1.x / v2, v1.y / v2);
        }

        public static Vector2 operator /(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x / v2.x, v1.y / v2.y);
        }

        public static float Distance2D(Vector2 v1, Vector2 v2)
        {
            return (float)Sqrt(Pow(v1.x - v2.x, 2) + Pow(v1.y - v2.y, 2));
        }
    }
}
