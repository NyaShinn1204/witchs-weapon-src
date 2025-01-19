using UnityEngine;

public class CameraManager : MonoBehaviour
{
	private static CameraManager _instance;

	private Camera _mainCamera;

	private Camera _outlineCamera;

	private Camera _uiCamera;

	public static CameraManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public Vector3 UIPos2World(Vector3 pos)
	{
		return default(Vector3);
	}

	public Vector3 WorldPos2UI(Vector3 pos)
	{
		return default(Vector3);
	}
}
