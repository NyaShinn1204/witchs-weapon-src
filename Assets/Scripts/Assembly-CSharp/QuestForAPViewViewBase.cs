using UnityEngine;

public class QuestForAPViewViewBase : QuestSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindNewAPQuest;

	[HideInInspector]
	public bool _BindNewAPDailyQuest;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NewAPQuestChanged(bool value)
	{
	}

	public virtual void NewAPDailyQuestChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
