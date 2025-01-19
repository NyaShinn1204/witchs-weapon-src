using System;
using UnityEngine;

public abstract class ActivityPlaySystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public bool _IsOpen;

	[HideInInspector]
	public bool _IsReceiveInitStamina;

	[HideInInspector]
	public bool _IsReceiveDailyStamina;

	[HideInInspector]
	public long _Currency;

	[HideInInspector]
	public long _ActivityStamina;

	[HideInInspector]
	public bool _UnlockStory;

	[HideInInspector]
	public bool _ActOpen;

	[HideInInspector]
	public long _Ticket;

	[HideInInspector]
	public int _FightCount;

	[HideInInspector]
	public int _SweepResult;

	[HideInInspector]
	public long _Currency2;

	public override string DefaultIdentifier
	{
		get
		{
			return null;
		}
	}

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public ActivityPlaySystemManagerViewModel ActivityPlaySystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override ViewModel CreateModel()
	{
		return null;
	}

	protected override void InitializeViewModel(ViewModel viewModel)
	{
	}

	public virtual void ExecuteReceiveInitStamina()
	{
	}

	public virtual void ExecuteReceiveDailyStamina()
	{
	}

	public virtual void ExecuteReset(int arg)
	{
	}

	public virtual void ExecuteGetReward()
	{
	}

	public virtual void ExecuteFinishGetRewaed()
	{
	}

	public virtual void ExecuteFinishReset()
	{
	}

	public virtual void ExecuteUnlockAPStory()
	{
	}

	public virtual void ExecuteGetRank(int arg)
	{
	}

	public virtual void ExecuteFinishGetRank()
	{
	}

	public virtual void ExecuteSweep(SweepArgu arg)
	{
	}

	public virtual void ExecuteFinishSweep()
	{
	}

	public virtual void ExecuteGoToNextFloorRule1()
	{
	}

	public virtual void ExecuteFinishGoToNextFloorRule1()
	{
	}

	public virtual void ExecuteAttributeAdd(string arg)
	{
	}

	public virtual void ExecuteFinishAttributeAdd()
	{
	}

	public virtual void ExecuteAttributeReset()
	{
	}

	public virtual void ExecuteFinishAttributeReset()
	{
	}

	public virtual void ExecuteRule5Reset(Rule5Argu arg)
	{
	}

	public virtual void ExecuteRule5GiveUp(Rule5Argu arg)
	{
	}

	public virtual void ExecuteRule5Getreward(Rule5Argu arg)
	{
	}

	public virtual void ExecuteFinishRule5Reset()
	{
	}

	public virtual void ExecuteFinishRule5GiveUp()
	{
	}

	public virtual void ExecuteFinishRule5Getreward()
	{
	}

	public virtual void ExecuteRule5UnlockFinalRound(int arg)
	{
	}

	public virtual void ExecuteChangeKey(ChangeKeyArg arg)
	{
	}

	public virtual void ExecuteFinishRule5UnlockFinalRound()
	{
	}

	public virtual void ExecuteFinishChangeKey()
	{
	}

	public virtual void ExecuteR4ChooseMobLevel(int arg)
	{
	}

	public virtual void ExecuteFinishR4ChooseMobLevel()
	{
	}

	public virtual void ExecuteR5ChooseMobLevel(Rule5Argu arg)
	{
	}

	public virtual void ExecuteFinishR5ChooseMobLevel()
	{
	}
}
