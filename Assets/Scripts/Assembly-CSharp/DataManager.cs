using UnityEngine;

public class DataManager : ScriptableObject
{
	private static DataManager _instance;

	private daFile _dataFile;

	public static daFile File
	{
		get
		{
			return null;
		}
	}

	public static void Init()
	{
	}
}
