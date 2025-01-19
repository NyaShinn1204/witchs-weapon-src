using UnityEngine;

public class BezierMover : MonoBehaviour
{
	public Transform[] points;

	public float tangentLengths;

	public float speed;

	private float time;

	private void Update()
	{
	}

	private Vector3 Plot(float t)
	{
		return default(Vector3);
	}

	private void Move(bool progress)
	{
	}

	public void OnDrawGizmos()
	{
	}
}
