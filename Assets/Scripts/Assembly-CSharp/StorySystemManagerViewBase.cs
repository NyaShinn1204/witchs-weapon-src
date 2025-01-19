using System;
using UnityEngine;

public abstract class StorySystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public long _CurrentUnlockStoryGroup;

	[HideInInspector]
	public long _CurrentUnlockStory;

	[HideInInspector]
	public long _CurrentCanUnlockStory;

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

	public StorySystemManagerViewModel StorySystemManager
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

	public virtual void ExecuteNoticeStoryGroupUnlock(long arg)
	{
	}

	public virtual void ExecuteNoticeStorynlock(long arg)
	{
	}

	public virtual void ExecuteNoticeStoryCanUnlock(long arg)
	{
	}

	public virtual void ExecuteBuyStory(long arg)
	{
	}

	public virtual void ExecuteFinishBuyStory()
	{
	}

	public virtual void ExecuteBuyStoryByItem(long arg)
	{
	}

	public virtual void ExecuteFinishBuyStoryByItem()
	{
	}
}
