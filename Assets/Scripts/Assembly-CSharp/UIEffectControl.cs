using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public sealed class UIEffectControl : MonoBehaviour
{
	private static UIEffectControl current;

	private void OnDestroy()
	{
	}

	public static UIEffectControl GetInstance()
	{
		return null;
	}

	public void StartCoroutineEx(IEnumerator routine)
	{
	}

	public void StopCoroutineEx(IEnumerator routine)
	{
	}

	public void StartCoroutineEx(float delay, Action onComplete)
	{
	}

	[DebuggerHidden]
	private IEnumerator CallStartCoroutine(float delay, Action onComplete)
	{
		return null;
	}
}
