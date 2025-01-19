using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class MvcExtensions
{
	public static T GetComponentFromInterface<T>(this MonoBehaviour behaviour) where T : class
	{
		return null;
	}

	public static T GetComponentFromInterface<T>(this GameObject gameObj) where T : class
	{
		return null;
	}

	[DebuggerHidden]
	public static IEnumerable<T> GetComponentsInDirectChildren<T>(this Transform tfm) where T : Component
	{
		return null;
	}
}
