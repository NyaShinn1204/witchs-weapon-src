using UnityEngine;

public sealed class CameraControl : MonoBehaviour
{
	private const float closeDistanceMin = 2f;

	private const float overlookingMax = 55f;

	private const float overlookingMin = 45f;

	private static Rect safeViewport;

	public Transform followTarget;

	public float moveSpeed;

	public float closeDistance;

	public Collider[] targetsInView;

	private Camera m_Camera;

	private Transform pivot;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void ShowAllTarget()
	{
	}

	private float LimitInViewport(Vector3 worldPoint)
	{
		return 0f;
	}

	private static Vector2 GetIntersectPoint(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
	{
		return default(Vector2);
	}

	private static bool Intersect(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
	{
		return false;
	}

	private static float DirectionV3(float x1, float y1, float x2, float y2, float x3, float y3)
	{
		return 0f;
	}

	private static Vector2 GetCrossPoint(Line line1, Line line2)
	{
		return default(Vector2);
	}
}
