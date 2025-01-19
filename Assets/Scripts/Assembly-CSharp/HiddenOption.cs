using UnityEngine;

public class HiddenOption : MonoBehaviour
{
	public GameObject connRemoteBox;

	public GameObject debugBox;

	public GameObject netLogBox;

	public GameObject skipGuideBox;

	public UIButtonLongPressTick tickComp;

	private bool isNewTickStarted;

	private int tickSum;

	private void Start()
	{
	}

	private void onTickTrigger(int tickDelta)
	{
	}

	private void onTickDone()
	{
	}
}
