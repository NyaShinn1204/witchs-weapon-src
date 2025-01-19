using System.Collections;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.View.UIFrame;

public class MainSceneGlobalMask : MonoBehaviour
{
	public static MainSceneGlobalMask current;

	private void Awake()
	{
	}

	[DebuggerHidden]
	public IEnumerator TryMaskScene(UISceneState sceneState)
	{
		return null;
	}
}
