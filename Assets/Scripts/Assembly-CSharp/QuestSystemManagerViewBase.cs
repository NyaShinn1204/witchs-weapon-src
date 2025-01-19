using System;
using UnityEngine;

public abstract class QuestSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _BeforeLv;

	[HideInInspector]
	public int _AfterLv;

	[HideInInspector]
	public int _BeforeStamina;

	[HideInInspector]
	public int _AfterStamina;

	[HideInInspector]
	public bool _NewNormalQuest;

	[HideInInspector]
	public bool _NewGuideQuest;

	[HideInInspector]
	public bool _NewStoryQuest;

	[HideInInspector]
	public bool _InProgressGuideQuest;

	[HideInInspector]
	public int _QuestResult;

	[HideInInspector]
	public bool _NewAPQuest;

	[HideInInspector]
	public bool _NewAPDailyQuest;

	[HideInInspector]
	public bool _NewAchieve;

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

	public QuestSystemManagerViewModel QuestSystemManager
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

	public virtual void ExecuteFinishiQuest(long arg)
	{
	}

	public virtual void ExecuteOpenGuide(long arg)
	{
	}

	public virtual void ExecuteAfterFinishQuest()
	{
	}

	public virtual void ExecuteReceiveAllQuest(int arg)
	{
	}

	public virtual void ExecuteFinishReceiveAllQuest()
	{
	}
}
