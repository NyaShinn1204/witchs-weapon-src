using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class DynamicGridObstacle : MonoBehaviour
{
	private Collider col;

	public float updateError;

	public float checkTime;

	private Bounds prevBounds;

	private bool isWaitingForUpdate;

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateGraphs()
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	public void DoUpdateGraphs()
	{
	}

	public float BoundsVolume(Bounds b)
	{
		return 0f;
	}
}
