using EXILED;

namespace SimpleJoinBC
{
    public class Plugin : EXILED.Plugin
    {
        public EventHandlers eventHandlers;
        public override void OnEnable()
        {
            Configs.Reload();
            eventHandlers = new EventHandlers();
            Events.PlayerJoinEvent += eventHandlers.PlayerJoined;
        }

        public override void OnDisable()
        {
            Events.PlayerJoinEvent -= eventHandlers.PlayerJoined;
        }

        public override void OnReload()
        {
        }
        public override string getName => "SimpleJoinBC";
    }
}