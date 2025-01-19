using UnityEngine;

public static class BulletPartFactory
{
	public static Bullet CreateBullet(BulletTPL tpl, GameObject obj, string prefab)
	{
		return null;
	}

	public static BulletSysProperties CreateSysProp()
	{
		return null;
	}

	private static HitListener CreateHitListener(HitListenerTPL tpl, Bullet bullet, GameObject source)
	{
		return null;
	}

	private static CompleteListener CreateCompleteListener(CompleteListenerTPL tpl, Bullet bullet, GameObject source)
	{
		return null;
	}

	public static IMotionEx CreateMotionByTPL(Bullet bullet, MotionTPL tpl, GameObject source)
	{
		return null;
	}

	private static MotionBezier CreateMotionBezier(MotionTPL tpl, GameObject source)
	{
		return null;
	}

	private static MotionBezierDisturbance CreateMotionBezierDisturbance(MotionTPL tpl, GameObject source)
	{
		return null;
	}

	public static MotionGroup CreateGroupMotion(Bullet bullet, MotionGroupTPL tpl, GameObject source)
	{
		return null;
	}

	public static Vector3 GetDirection(int diretion, Vector3 source, Vector3 target)
	{
		return default(Vector3);
	}
}
