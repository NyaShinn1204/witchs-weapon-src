using System.Runtime.InteropServices;
using UnityEngine;

public class UIButtonLongPressTick : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void Tick(int tickDelta);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void TickDone();

	private bool mLongPressStarted;

	private int currTickFrameCounter;

	private int currTickMaxFrameCounter;

	private int tickedNum;

	private int tickSum;

	private int currFreqIdx;

	protected int[] tpfsArr;

	protected int[] nextTpfsNeedTickedNumArr;

	public Tick onTick;

	public TickDone onTickDone;

	public void ChangeTickFreq(int[] tpfsArray, int[] tickNum2NextArray)
	{
	}

	public void OnPress(bool pressed)
	{
	}

	public void OnDragOut(GameObject go)
	{
	}

	private void OnEnable()
	{
	}

	private void ResetTimer()
	{
	}

	private void Update()
	{
	}

	private void LongPressTick()
	{
	}

	protected void OnTick(int tick)
	{
	}

	protected void OnLongPressDone(int tick)
	{
	}

	protected void OnLongPressCancel()
	{
	}
}
