using CoHook.Enum;

namespace CoHook.Hook
{
    public static class KeyboardHook
    {
        public static void SendKey(VKCode key, VKState state)
        {
            NativeMethods.keybd_event((byte)key, 0, (int)state, 0);
        }
    }
}
