using UnityEngine;

public class AstarSmoothFollow2 : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float height;

	public float damping;

	public bool smoothRotation;

	public bool followBehind;

	public float rotationDamping;

	public bool staticOffset;

	private void LateUpdate()
	{
	}
}
