using UnityEngine;

public class SceneBlockAutoSize : MonoBehaviour
{
	public enum SceneBlockAutoSizeType
	{
		scale = 0,
		particle = 1
	}

	public SceneBlockAutoSizeType scaleType;

	private float _scaleMul;

	private Vector3 right;

	private Vector3 left;

	private void Update()
	{
	}

	private void particle()
	{
	}

	private void scale()
	{
	}

	private Vector3 rayModfiny(Vector3 sBegin, Vector3 sVector)
	{
		return default(Vector3);
	}
}
