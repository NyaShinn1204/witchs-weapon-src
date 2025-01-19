using System.Collections.Generic;
using UnityEngine;

public class iTweenPath : MonoBehaviour
{
	public string pathName;

	public Color pathColor;

	public List<Vector3> nodes;

	public int nodeCount;

	public static Dictionary<string, iTweenPath> paths;

	public bool initialized;

	public string initialName;

	public bool pathVisible;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	public static Vector3[] GetPathReversed(string requestedName)
	{
		return null;
	}
}
