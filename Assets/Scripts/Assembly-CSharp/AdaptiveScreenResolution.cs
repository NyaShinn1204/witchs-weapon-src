using UnityEngine;

public class AdaptiveScreenResolution : MonoBehaviour
{
	public enum AdaptiveMode
	{
		Fov = 0,
		Position = 1
	}

	private static readonly float editorWidth;

	private static readonly float editorHeight;

	private static readonly float editorRatio;

	public AdaptiveMode adaptiveMode;

	private Camera uiCam;

	private float cacheFOV;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Resize()
	{
	}

	private float GetVerticalFOV(float horizontalFOV, float aspect)
	{
		return 0f;
	}

	private float GetHorizontalFOV(float verticalFOV, float aspect)
	{
		return 0f;
	}
}
