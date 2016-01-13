using System;
using CoHook.Enum;

namespace CoHook.Hook
{
    public static class MouseHook
    {
        private static void Send(MouseEventFlags mouseEvent)
        {
            NativeMethods.mouse_event((uint) mouseEvent, 0, 0, 0, new IntPtr());
        }

        public static void PressRight()
        {
            Send(MouseEventFlags.RIGHTDOWN);
        }

        public static void ReleaseRight()
        {
            Send(MouseEventFlags.RIGHTUP);
        }

        public static void PressLeft()
        {
            Send(MouseEventFlags.LEFTDOWN);
        }

        public static void ReleaseLeft()
        {
            Send(MouseEventFlags.LEFTUP);
        }

        public static void SendRightClick()
        {
            PressRight();
            ReleaseRight();
        }

        public static void SendLeftClick()
        {
            PressLeft();
            ReleaseLeft();
        }
    }
}
