using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class LoadingBackToMainUI : MonoBehaviour
{
	private static LoadingBackToMainUI _instance;

	[Space]
	public GameObject tipsContainer;

	public static LoadingBackToMainUI GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadMainUIAsync()
	{
		return null;
	}

	public void Unload()
	{
	}
}
