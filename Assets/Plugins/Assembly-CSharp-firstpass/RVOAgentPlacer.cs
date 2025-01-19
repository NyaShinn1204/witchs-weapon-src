using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class RVOAgentPlacer : MonoBehaviour
{
	public int agents;

	public float ringSize;

	public LayerMask mask;

	public GameObject prefab;

	public Vector3 goalOffset;

	public float repathRate;

	private const float rad2Deg = 180f / (float)Math.PI;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	public Color GetColor(float angle)
	{
		return default(Color);
	}

	private static Color HSVToRGB(float h, float s, float v)
	{
		return default(Color);
	}
}
