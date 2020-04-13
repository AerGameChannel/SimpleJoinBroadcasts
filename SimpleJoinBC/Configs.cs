namespace SimpleJoinBC
{
    internal static class Configs
    {
        internal static string joinmessage;
        internal static bool sjbc_enable;
        internal static uint time;
        internal static void Reload()
        {
            Configs.joinmessage = Plugin.Config.GetString("simplejbc_joinmessage", "Welcome to the server!"); // Broadcast message config option
            Configs.sjbc_enable = Plugin.Config.GetBool("simplejbc_enable", true); // Disable/Enable plugin
            Configs.time = Plugin.Config.GetUInt("simplejbc_time", 15); // Broadcast time config option
        }
    }
}