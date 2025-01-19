using UnityEngine;

public class QuesReminderViewViewBase : QuestSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindNewNormalQuest;

	[HideInInspector]
	public bool _BindNewGuideQuest;

	[HideInInspector]
	public bool _BindNewStoryQuest;

	[HideInInspector]
	public bool _BindInProgressGuideQuest;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NewNormalQuestChanged(bool value)
	{
	}

	public virtual void NewGuideQuestChanged(bool value)
	{
	}

	public virtual void NewStoryQuestChanged(bool value)
	{
	}

	public virtual void InProgressGuideQuestChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
