using UnityEngine;

public class RadarEx
{
	private float range;

	private Transform origin;

	private Vector3 direction;

	private float favAngle;

	private float currentAngle;

	private float currentIndex;

	public RadarEx(Transform origin, float range, Vector3 direction, float favAngle)
	{
	}

	public Vector3 ScanEmptyPlace(float angle)
	{
		return default(Vector3);
	}

	private float GetAngleOffset(float angle, int index)
	{
		return 0f;
	}

	private bool ConfirmIsEmpty(float angleOffset)
	{
		return false;
	}

	private bool CheckDirectionEmpty(float angleOffset)
	{
		return false;
	}

	public Vector3 GetDirectionVector(Transform basePoint, float focusAngle)
	{
		return default(Vector3);
	}

	public void Reset()
	{
	}

	public static Vector3 FindEmptyPlace(Transform origin, float range, Vector3 initDirection, float favAngle = 0f)
	{
		return default(Vector3);
	}
}
