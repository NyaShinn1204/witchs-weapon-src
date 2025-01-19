using System.Collections;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Level.Trigger;

public class DreamWipe : MonoBehaviour
{
	public static Protal Protal;

	public static DreamWipe self;

	public Camera camera;

	public float fadeTime;

	public float waveScale;

	public float waveFrequency;

	private bool inProgress;

	private void Start()
	{
	}

	public void DoWipeMessage(int i)
	{
	}

	[DebuggerHidden]
	private IEnumerator DoFade()
	{
		return null;
	}
}
