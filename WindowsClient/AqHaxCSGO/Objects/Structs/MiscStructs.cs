using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

namespace AqHaxCSGO.Objects.Structs
{
    static class Misc
    {
        public struct Rect
        {
            public int Left, Top, Right, Bottom;
        };

        private static IntPtr privhandle = (IntPtr)0;

        public static IntPtr handle
        {
            get
            {
                if (privhandle != (IntPtr)0)
                {
                    return privhandle;
                }
                else
                {
                    privhandle = GetWindowHandle();
                    return privhandle;
                }
            }
        }

        #region DLLImport
        [DllImport("user32.dll")]
        public static extern bool GetClientRect(
            IntPtr hwnd,
            out Rect rectangle
            );
        [DllImport("user32.dll")]
        private static extern bool ClientToScreen(
            IntPtr hWnd,
            ref Point lpPoint
            );
        #endregion

        public static IntPtr GetWindowHandle()
        {
            int mil = DateTime.Now.Millisecond;
            var processes = Process.GetProcessesByName("csgo");
            Console.WriteLine(DateTime.Now.Millisecond - mil);
            if (processes.Length > 0)
                return processes[0].MainWindowHandle;
            else
                return (IntPtr)null;
        }
        public static Rectangle GetWindowRect()
        {
            int mil = DateTime.Now.Millisecond;
            Rect rect;
            GetClientRect(handle, out rect);
            var p = new Point(0, 0);
            ClientToScreen(handle, ref p);
            rect.Left = p.X;
            rect.Top = p.Y;
            Console.WriteLine(DateTime.Now.Millisecond - mil);
            return new Rectangle(p.X, p.Y, rect.Right, rect.Bottom);
        }
    }
}
