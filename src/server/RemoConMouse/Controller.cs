
using SmartMouse;
using System.Runtime.InteropServices;
using System.Threading;

namespace Controller
{
    class Mouse
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private enum MouseEventFlags
        {
            LeftDown = 0x02,
            LeftUp = 0x04,
            RightDown = 0x08,
            RightUp = 0x10,
            MiddleDown = 0x20,
            MiddleUp = 0x40,
            Wheel = 0x800,
        }


        public static void Move(int moveX, int moveY)
        {
            int currentX = Cursor.Position.X;
            int currentY = Cursor.Position.Y;

            Cursor.Position = new System.Drawing.Point(currentX + moveX, currentY + moveY);
        }

        public static void Click(string button)
        {
            switch (button)
            {
                case "left-down":
                    mouse_event((int)MouseEventFlags.LeftDown, 0, 0, 0, 0);
                    break;
                case "left-up":
                    mouse_event((int)MouseEventFlags.LeftUp, 0, 0, 0, 0);
                    break;
                case "right-down":
                    mouse_event((int)MouseEventFlags.RightDown, 0, 0, 0, 0);
                    break;
                case "right-up":
                    mouse_event((int)MouseEventFlags.RightUp, 0, 0, 0, 0);
                    break;
                case "middle-down":
                    mouse_event((int)MouseEventFlags.MiddleDown, 0, 0, 0, 0);
                    break;
                case "middle-up":
                    mouse_event((int)MouseEventFlags.MiddleUp, 0, 0, 0, 0);
                    break;
                default:
                    break;

            }
        }

        public static void Scroll(string direction)
        {
            switch (direction)
            {
                case "up":
                    mouse_event((int)MouseEventFlags.Wheel, 0, 0, 50, 0);
                    break;
                case "down":
                    mouse_event((int)MouseEventFlags.Wheel, 0, 0, -50, 0);
                    break;
                default:
                    break;
            }
        }

    }
}