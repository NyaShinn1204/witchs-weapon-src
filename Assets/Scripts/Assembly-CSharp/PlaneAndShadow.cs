using UnityEngine;

public class PlaneAndShadow : MonoBehaviour
{
	public HalfColorUISprite shadow;

	public HalfColorUISprite plane;

	public const float offsetY = -0.15f;

	public const float offsetX = -0.3f;

	public float height;

	public float scale;

	public float round;

	public float amplitude;

	private float timeOffset;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
