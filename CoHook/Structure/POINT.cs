using System.Runtime.InteropServices;

namespace CoHook.Structure
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public readonly int x;
        public readonly int y;
    }
}
