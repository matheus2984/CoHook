using System;
using System.Threading;
using System.Windows.Forms;
using CoHook.Enum;
using CoHook.Extentions.Threading;
using CoHook.Hook;
using CoHook.Window;

namespace CoHook
{
    public static class Program
    {
        private static ThreadAction trh;

        [STAThread]
        public static void Main()
        {
              Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            /*trh = ThreadAction.Factory(AutoPotThread, 100, true);
            Console.ReadKey();*/
        }

        private static bool ConquerFocusCheck()
        {
            string title = WindowHook.GetActiveWindowTitle();
            return !string.IsNullOrEmpty(title) && title.Contains("Conquer");
        }

        private static void AutoPotThread()
        {
            if (!ConquerFocusCheck()) return;
            KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
            Thread.Sleep(100);
            KeyboardHook.SendKey(VKCode.F2, VKState.Pressed);
        }
    }
}