public static class Extenstions
{
	public static void Broadcast(this ReferenceHub rh, uint time, string message) =>
		rh.GetComponent<Broadcast>().TargetAddElement(rh.scp079PlayerScript.connectionToClient, message, time, false);
}