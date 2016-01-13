using System;
using System.Text;

namespace CoHook.Hook
{
    public static class WindowHook
    {
        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            var buff = new StringBuilder(nChars);
            IntPtr handle = NativeMethods.GetForegroundWindow();

            return NativeMethods.GetWindowText(handle, buff, nChars) > 0 ? buff.ToString() : null;
        }
    }
}
