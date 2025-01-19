using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;

public class PathTypesDemo : MonoBehaviour
{
	public int activeDemo;

	public Transform start;

	public Transform end;

	public Vector3 pathOffset;

	public Material lineMat;

	public Material squareMat;

	public float lineWidth;

	public RichAI[] agents;

	public int searchLength;

	public int spread;

	public float aimStrength;

	private Path lastPath;

	private List<GameObject> lastRender;

	private List<Vector3> multipoints;

	private Vector2 mouseDragStart;

	private float mouseDragStartTime;

	private FloodPath lastFlood;

	private void Update()
	{
	}

	public void OnGUI()
	{
	}

	public void OnPathComplete(Path p)
	{
	}

	public void ClearPrevious()
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void DemoPath()
	{
	}

	[DebuggerHidden]
	public IEnumerator Constant()
	{
		return null;
	}
}
