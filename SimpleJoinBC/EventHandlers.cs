using EXILED;
using SimpleJoinBC;

	public class EventHandlers
	{
		public void PlayerJoined(PlayerJoinEvent ev)
		{
			ev.Player.Broadcast(Configs.time, Configs.joinmessage); // Broadcasts message from configs
		}
	}