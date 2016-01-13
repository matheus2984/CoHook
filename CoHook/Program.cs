using System;
using System.Threading;
using CoHook.Enum;
using CoHook.Extentions.Threading;
using CoHook.Hook;

namespace CoHook
{
    public static class Program
    {
        public static void Main()
        {
            ThreadAction.Factory(AutoPotThread, 1, true);
            ThreadAction.Factory(AutoClick, 10, true);
            Console.ReadKey();
        }

        private static bool ConquerFocusCheck()
        {
            string title = WindowHook.GetActiveWindowTitle();
            return !string.IsNullOrEmpty(title) && title.Contains("Conquer");
        }

        public static void AutoPotThread()
        {
            if (!ConquerFocusCheck()) return;
            KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
            KeyboardHook.SendKey(VKCode.F1, VKState.Released);
            KeyboardHook.SendKey(VKCode.F2, VKState.Pressed);
            KeyboardHook.SendKey(VKCode.F2, VKState.Released);
        }

        public static void AutoClick()
        {
            if (!ConquerFocusCheck()) return;
            MouseHook.SendRightClick();
        }
    }
}