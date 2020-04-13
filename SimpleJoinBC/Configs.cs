namespace SimpleJoinBC
{
    internal static class Configs
    {
        internal static string joinmessage;
        internal static uint time;
        internal static void Reload()
        {
            Configs.joinmessage = Plugin.Config.GetString("simplejbc_joinmessage", "Welcome to the server!"); // Broadcast message config option
            Configs.time = Plugin.Config.GetUInt("simplejbc_time", 15); // Broadcast time config option
        }
    }
}