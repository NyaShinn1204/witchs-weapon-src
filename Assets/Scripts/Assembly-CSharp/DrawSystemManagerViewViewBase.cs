using UnityEngine;

public class DrawSystemManagerViewViewBase : DrawSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindDrawFinish;

	[HideInInspector]
	public bool _BindRemainFreeGoldTime;

	[HideInInspector]
	public bool _BindRemainFreeRMBTime;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void DrawFinishExecuted()
	{
	}

	public virtual void RemainFreeGoldTimeChanged(int value)
	{
	}

	public virtual void RemainFreeRMBTimeChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
