using UnityEngine;

public class FocusTester
{
	public const float sqrGap = 0.5f;

	public const float roundGap = 3f;

	public static string COLLIDER_NAME;

	public static string KEEPOUT_NAME;

	public static Vector3 GetMinPos(CharacterBase characterbase, float dist, float focusAngle, float radius)
	{
		return default(Vector3);
	}

	public static Vector3 GetMinPos(Transform basePoint, float dist, float focusAngle, float radius)
	{
		return default(Vector3);
	}

	public static Vector3 GetFocus(Transform basePoint, float dist, float focusAngle)
	{
		return default(Vector3);
	}

	public static float GetMaxSqrLength(GameObject go, float width)
	{
		return 0f;
	}

	public static float GetMaxRadius(GameObject go, float width)
	{
		return 0f;
	}

	public static float RayTest(Vector3 origin, Vector3 focus)
	{
		return 0f;
	}
}
