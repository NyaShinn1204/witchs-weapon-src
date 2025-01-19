using UnityEngine;

public class GUtilData : MonoBehaviour
{
	public const string DEBUG_ENEMY_DATA = "ENEMY DATA\n";

	public const string DEBUG_HERO_DATA = "HERO DATA\n";

	public const string DEBUG_COMBAT_BUFF = "COMBAT BUFF\n";

	public const string DEBUG_COMBAT_HP = "COMBAT HP\n";

	private static long _IDSign;

	private static GUtilData _valueObject;

	private float _time;

	public static long IDSign
	{
		get
		{
			return 0L;
		}
	}

	public static GUtilData valueObject
	{
		get
		{
			return null;
		}
	}

	public static float time
	{
		get
		{
			return 0f;
		}
	}

	private void Update()
	{
	}
}
