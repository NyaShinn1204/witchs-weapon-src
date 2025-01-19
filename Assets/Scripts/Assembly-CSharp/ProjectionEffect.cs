using UnityEngine;

public class ProjectionEffect : MonoBehaviour
{
	public Vector3 baseLocation;

	public GameObject baseGameObject;

	public Camera projectionCamera;

	public UIRoot rootPanel;

	protected Vector3 tempLocation;

	protected virtual void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	public static Vector3 GetProjectionPosition(UIRoot rootPanel, Camera projectionCamera, Vector3 position)
	{
		return default(Vector3);
	}
}
