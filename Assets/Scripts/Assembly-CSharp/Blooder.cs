using UnityEngine;

public class Blooder : MonoBehaviour
{
	public const string TYPE_BLACK = "prefab/parts/battle/blood/blood_black";

	public const string TYPE_DEAD = "prefab/parts/battle/blood/blood_dead";

	public const string TYPE_DEAD_LARGE = "prefab/parts/battle/blood/blood_dead_large";

	public const string TYPE_FX = "prefab/parts/battle/blood/blood_fx";

	public const string TYPE_UNDER = "prefab/parts/battle/blood/blood_under";

	public static string RANDOM
	{
		get
		{
			return null;
		}
	}

	public void sucide()
	{
	}

	public static void initPool()
	{
	}

	public static GameObject getBlooder(string type, Vector3 pos, GameObject parent)
	{
		return null;
	}
}
