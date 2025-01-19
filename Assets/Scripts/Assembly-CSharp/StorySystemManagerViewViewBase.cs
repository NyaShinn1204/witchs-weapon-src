using UnityEngine;

public class StorySystemManagerViewViewBase : StorySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindNoticeStorynlock;

	[HideInInspector]
	public bool _BindNoticeStoryGroupUnlock;

	[HideInInspector]
	public bool _BindNoticeStoryCanUnlock;

	[HideInInspector]
	public bool _BindBuyStory;

	[HideInInspector]
	public bool _BindCurrentCanUnlockStory;

	[HideInInspector]
	public bool _BindCurrentUnlockStoryGroup;

	[HideInInspector]
	public bool _BindCurrentUnlockStory;

	[HideInInspector]
	public bool _BindFinishBuyStory;

	[HideInInspector]
	public bool _BindFinishBuyStoryByItem;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NoticeStorynlockExecuted()
	{
	}

	public virtual void NoticeStoryGroupUnlockExecuted()
	{
	}

	public virtual void NoticeStoryCanUnlockExecuted()
	{
	}

	public virtual void BuyStoryExecuted()
	{
	}

	public virtual void CurrentCanUnlockStoryChanged(long value)
	{
	}

	public virtual void CurrentUnlockStoryGroupChanged(long value)
	{
	}

	public virtual void CurrentUnlockStoryChanged(long value)
	{
	}

	public virtual void FinishBuyStoryExecuted()
	{
	}

	public virtual void FinishBuyStoryByItemExecuted()
	{
	}

	public override void Bind()
	{
	}
}
