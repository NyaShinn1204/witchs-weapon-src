using UnityEngine;

public class GameInitializer
{
	private static string InsitializerName;

	private static GameObject initObj;

	private static GameInitializer instance;

	public GameSocket socket;

	public GameSocketIO socketio;

	private void Init()
	{
	}

	private void AddComponents(GameObject obj)
	{
	}

	public static GameInitializer GetInstance()
	{
		return null;
	}
}
