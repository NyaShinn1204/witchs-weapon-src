using System.Runtime.InteropServices;
using UnityEngine;

public class HoldableButton : UIButton
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void VoidDelegate(GameObject go);

	public VoidDelegate onHold;

	public const float HOLD_TIME = 1.5f;

	public const float MAX_DIST = 10f;

	private float pressStartTime;

	public Vector3 pressStartPos;

	public bool holdable;

	public bool transformColor;

	protected TweenScale ts;

	protected override void OnPress(bool isPressed)
	{
	}

	private void Update()
	{
	}

	private void onHoldTrigger()
	{
	}

	public override void SetState(State state, bool instant)
	{
	}
}
