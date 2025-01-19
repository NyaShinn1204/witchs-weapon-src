using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LoadLuaLibBehavior : MonoBehaviour
{
	protected static bool initialize;

	private static LoadLuaLibBehavior instance;

	private List<string> downloadFiles;

	private void Init()
	{
	}

	public void CheckExtractResource()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnExtractResource()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator OnUpdateResource()
	{
		return null;
	}

	private void OnUpdateFailed(string file)
	{
	}

	private bool IsDownOK(string file)
	{
		return false;
	}

	private void BeginDownload(string url, string file)
	{
	}

	private void OnThreadCompleted(NotiData data)
	{
	}

	public void OnResourceInited()
	{
	}

	private void OnInitialize()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static LoadLuaLibBehavior GetInstance()
	{
		return null;
	}
}
