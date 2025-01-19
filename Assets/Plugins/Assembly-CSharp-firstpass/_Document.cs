using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class _Document : MonoBehaviour
{
	private static bool _isCDNLoad;

	public static bool isCDNLoad
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator initExtraCheck()
	{
		return null;
	}

	public static void AssetBundleLoadingCheck()
	{
	}

	private static void JudgeIsCDNLoad()
	{
	}

	private void AfInt()
	{
	}
}
