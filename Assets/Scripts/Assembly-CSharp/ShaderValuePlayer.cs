using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShaderValuePlayer : MonoBehaviour
{
	public List<ShaderValue> values;

	private float duration;

	private Material mat;

	private bool visible;

	private float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[DebuggerHidden]
	private IEnumerator Go()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Back()
	{
		return null;
	}

	private void SetValue(float v)
	{
	}
}
