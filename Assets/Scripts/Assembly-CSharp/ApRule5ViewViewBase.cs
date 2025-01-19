using UnityEngine;

public class ApRule5ViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishRule5Reset;

	[HideInInspector]
	public bool _BindFinishRule5GiveUp;

	[HideInInspector]
	public bool _BindFinishRule5Getreward;

	[HideInInspector]
	public bool _BindFinishRule5UnlockFinalRound;

	[HideInInspector]
	public bool _BindFinishChangeKey;

	[HideInInspector]
	public bool _BindFinishR5ChooseMobLevel;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishRule5ResetExecuted()
	{
	}

	public virtual void FinishRule5GiveUpExecuted()
	{
	}

	public virtual void FinishRule5GetrewardExecuted()
	{
	}

	public virtual void FinishRule5UnlockFinalRoundExecuted()
	{
	}

	public virtual void FinishChangeKeyExecuted()
	{
	}

	public virtual void FinishR5ChooseMobLevelExecuted()
	{
	}

	public override void Bind()
	{
	}
}
