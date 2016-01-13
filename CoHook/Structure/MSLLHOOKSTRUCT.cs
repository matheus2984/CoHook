using System;
using System.Runtime.InteropServices;

namespace CoHook.Structure
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MSLLHOOKSTRUCT
    {
        public readonly POINT pt;
        public readonly uint mouseData;
        public readonly uint flags;
        public readonly uint time;
        public readonly IntPtr dwExtraInfo;
    }
}
