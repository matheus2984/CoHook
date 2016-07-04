using CoHook.Hook;

namespace CoHook.Functions
{
    public static class Client
    {
        public static bool FocusCheck()
        {
            string title = WindowHook.GetActiveWindowTitle();
            return !string.IsNullOrEmpty(title) && title.Contains("Conquer");
        }
    }
}
