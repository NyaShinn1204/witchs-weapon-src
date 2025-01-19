using System.Collections.Generic;

public class BulletFactory
{
	public const int MOVEMENT_TYPE_STAY = 1;

	public static string motionConfPath;

	public static Dictionary<string, BulletTPL> tplDic;

	public static Dictionary<string, Emit> emitDic;

	public static Dictionary<string, BTPool> bulletPoolDic;

	public static BulletTPL SaveTPL(string bulletTypeString)
	{
		return null;
	}

	public static BulletTPL GetTPL(string key)
	{
		return null;
	}

	public static Emit SaveEmit(string id, string uuid)
	{
		return null;
	}

	public static Emit GetEmit(string id, string uuid)
	{
		return null;
	}

	public static void SaveBullet(string id, string path, int max)
	{
	}

	public static Bullet GetBullet(string id)
	{
		return null;
	}

	public static void Clear()
	{
	}
}
