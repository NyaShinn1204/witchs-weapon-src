using System.Collections;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;

public class ProceduralGridMover : MonoBehaviour
{
	public float updateDistance;

	public Transform target;

	public bool floodFill;

	private GridGraph graph;

	private GridNode[] tmp;

	public void Start()
	{
	}

	private void Update()
	{
	}

	[DebuggerHidden]
	public IEnumerator UpdateGraph()
	{
		return null;
	}
}
