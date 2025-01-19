using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class TransitionMaskAnimCtrl : MonoBehaviour
{
	private static GameObject _current;

	public UIPanel leftPanel;

	public UIPanel rightPanel;

	public UITexture mainTex;

	public BoxCollider boxCollider;

	private float currAnimTime;

	private float showAnimTime;

	public float hideAnimTime;

	private float leftPos1;

	private float leftPos2;

	private float rightPos1;

	private float rightPos2;

	private UITexture Mask1;

	private UITexture Mask2;

	private void Awake()
	{
	}

	[DebuggerHidden]
	public IEnumerator ShowAnim()
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator HideAnim()
	{
		return null;
	}
}
