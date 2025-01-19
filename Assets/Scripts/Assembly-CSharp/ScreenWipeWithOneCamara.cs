using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ScreenWipeWithOneCamara : MonoBehaviour
{
	private Texture tex;

	private RenderTexture renderTex;

	private Texture2D tex2D;

	private float alpha;

	private AnimationCurve curve;

	private bool useCurve;

	public static ScreenWipeWithOneCamara use;

	public int planeResolution;

	private Vector3[] baseVertices;

	private Vector3[] newVertices;

	private Material planeMaterial;

	private GameObject plane;

	private RenderTexture renderTex2;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	[DebuggerHidden]
	private IEnumerator AlphaTimer(float time)
	{
		return null;
	}

	private void CameraSetup(Camera cam, bool enableThis)
	{
	}

	private void CameraCleanup(Camera cam)
	{
	}

	public void GenTex2D()
	{
	}

	public void GenTex2D(Camera cam)
	{
	}

	[DebuggerHidden]
	private IEnumerator CrossFade(Camera cam, float time)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator CrossFade(Camera cam, float time, AnimationCurve _curve)
	{
		return null;
	}

	public void InitializeDreamWipe(Camera cam)
	{
	}

	[DebuggerHidden]
	public IEnumerator DreamWipe(Camera cam, float time, float waveScale, float waveFrequency)
	{
		return null;
	}
}
