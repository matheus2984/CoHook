using System.Threading;

namespace CoHook
{
    public static class Program
    {
        public static void Main()
        {
            while (true)
            {
                string title = NativeMethods.GetActiveWindowTitle();
                if (string.IsNullOrEmpty(title)) continue;

                if (title.Contains("Conquer"))
                {
                    NativeMethods.SendKey(VKCode.F1, VKState.Pressed);
                    NativeMethods.SendKey(VKCode.F1, VKState.Released);
                    Thread.Sleep(150);
                }
                Thread.Sleep(1);
            }
        }
    }
}