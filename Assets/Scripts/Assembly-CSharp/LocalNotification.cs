using UnityEngine;

internal class LocalNotification
{
	private static string fullClassName;

	private static string unityClass;

	public static void SendNotification(int id, long delay, string title, string message, Color32 bgColor, bool sound = true, bool vibrate = true, bool lights = true, string bigIcon = "")
	{
	}

	public static void SendRepeatingNotification(int id, long delay, long timeout, string title, string message, Color32 bgColor, bool sound = true, bool vibrate = true, bool lights = true, string bigIcon = "")
	{
	}

	public static void CancelNotification(int id)
	{
	}
}
