using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using AqHaxCSGO.MemoryManagers;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.Objects.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct GlowObject
    {
        [FieldOffset(0x00)]
        public int NextFreeSlot;
        [FieldOffset(0x04)]
        public int EntityPointer;
        [FieldOffset(0x08)]
        public float r;
        [FieldOffset(0x0C)]
        public float g;
        [FieldOffset(0x10)]
        public float b;
        [FieldOffset(0x14)]
        public float a;

        [FieldOffset(0x18)]
        public int unk1;
        [FieldOffset(0x1C)]
        public int unk2;

        [FieldOffset(0x20)]
        public float BloomAmount;
        [FieldOffset(0x24)]
        public float LocalPlayerIs0_3;
        [FieldOffset(0x28)]
        public bool m_bRenderWhenOccluded;
        [FieldOffset(0x29)]
        public bool m_bRenderWhenUnoccluded;
        [FieldOffset(0x2A)]
        public bool m_bFullBloom;

        [FieldOffset(0x2B)]
        public byte unk3;

        [FieldOffset(0x2C)]
        public int FullBloomStencilValue;
        [FieldOffset(0x30)]
        public int m_nGlowStyle;
        [FieldOffset(0x34)]
        public int SplitScreenSlot;

        public static int GetSize()
        {
            return 0x38;
        }

        public static int Ptr
        {
            get
            {
                return Memory.Read<int>(Memory.clientBase + dwGlowObjectManager);
            }
        }
    };

    public struct RenderColor
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;

        public RenderColor(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    };
}
