using UnityEngine;

public static class ConstData
{
	public const float MIN_GROUND_HEIGHT = 0.02f;

	public const float SCALE_BASE = 0.012f;

	public const int SCREEN_HEIGHT_BASE = 640;

	public static float SCALE_3D_BASE;

	public static Rect ZERO_RECT;

	public static Vector3 EMPTY_POSITION;

	private static int m_LayerMask_3D_Nostop;

	private static int m_LayerMask_3D_Paused;

	private static int m_LayerMask_BattleUI;

	public static int LayerMask_Default;

	public static int LayerMask_Outline;

	public static Vector2 OrthoTransform;

	public static Quaternion Inverse;

	public static int LayerMask_3D_Nostop
	{
		get
		{
			return 0;
		}
	}

	public static int LayerMask_3D_Paused
	{
		get
		{
			return 0;
		}
	}

	public static int LayerMask_BattleUI
	{
		get
		{
			return 0;
		}
	}

	public static float get2DRotation(Vector3 origin, Vector3 target)
	{
		return 0f;
	}

	public static float get2DRotation(Vector3 origin, Vector3 target, Camera c)
	{
		return 0f;
	}

	public static float get2DVerticalRotation(Vector3 origin, Vector3 target)
	{
		return 0f;
	}

	public static float get2DVerticalRotation(Vector3 origin, Vector3 target, Vector3 normal, Camera c)
	{
		return 0f;
	}

	public static Vector3 getVerticalFocus(Vector3 focus)
	{
		return default(Vector3);
	}

	public static Vector3 GetRotatedVector3(CharacterBase cb, Vector3 vector)
	{
		return default(Vector3);
	}

	public static void reset2dEffect(GameObject go)
	{
	}

	public static void reset2dEffect(GameObject go, Camera c, float rotationZ)
	{
	}

	public static void ClearOutline(GameObject go)
	{
	}

	public static bool DefaultResistance(float resistance, ref Vector3 spd)
	{
		return false;
	}

	public static float StartSpeedInDefaultResistance(float shift, float endSpd, float resistance)
	{
		return 0f;
	}

	public static float StandardAngle(float angle)
	{
		return 0f;
	}

	public static float StaticRadius(Vector3 origin, Vector3 target)
	{
		return 0f;
	}

	public static float StaticRadius(Vector3 origin, Vector3 target, Vector3 forward)
	{
		return 0f;
	}

	public static void RotateTowards(Transform tr, Vector3 dir, bool needReverse, float roSpeed)
	{
	}

	public static void RotateTowardsAllFocus(Transform tr, Vector3 dir, bool needReverse, float roSpeed)
	{
	}

	public static void RotateToRotation(Transform tr, Quaternion toTarget, float roSpeed)
	{
	}

	public static Quaternion InverseQuaternion(Quaternion souce)
	{
		return default(Quaternion);
	}

	public static void HalfFaceToCamera(Transform t, Camera c)
	{
	}

	public static void faceToCamera(GameObject go)
	{
	}

	public static void faceToCamera(GameObject go, Camera c, float rotationZ)
	{
	}
}
