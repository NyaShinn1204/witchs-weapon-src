using UnityEngine;

public class QuestSystemManagerViewViewBase : QuestSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindDailyQuests;

	[HideInInspector]
	public bool _DailyQuestsSceneFirst;

	[HideInInspector]
	public Transform _DailyQuestsContainer;

	[HideInInspector]
	public bool _BindSideQuests;

	[HideInInspector]
	public bool _SideQuestsSceneFirst;

	[HideInInspector]
	public Transform _SideQuestsContainer;

	[HideInInspector]
	public bool _BindRandomQuests;

	[HideInInspector]
	public bool _RandomQuestsSceneFirst;

	[HideInInspector]
	public Transform _RandomQuestsContainer;

	[HideInInspector]
	public bool _BindFinishiQuest;

	[HideInInspector]
	public bool _BindGuideQuest;

	[HideInInspector]
	public bool _GuideQuestSceneFirst;

	[HideInInspector]
	public Transform _GuideQuestContainer;

	[HideInInspector]
	public bool _BindNewNormalQuest;

	[HideInInspector]
	public bool _BindNewStoryQuest;

	[HideInInspector]
	public bool _BindStoryQuest;

	[HideInInspector]
	public bool _StoryQuestSceneFirst;

	[HideInInspector]
	public Transform _StoryQuestContainer;

	[HideInInspector]
	public bool _BindAfterFinishQuest;

	[HideInInspector]
	public bool _BindActivityQuest;

	[HideInInspector]
	public bool _ActivityQuestSceneFirst;

	[HideInInspector]
	public Transform _ActivityQuestContainer;

	[HideInInspector]
	public bool _BindActivityDailyQuest;

	[HideInInspector]
	public bool _ActivityDailyQuestSceneFirst;

	[HideInInspector]
	public Transform _ActivityDailyQuestContainer;

	[HideInInspector]
	public bool _BindNewAPQuest;

	[HideInInspector]
	public bool _BindNewAPDailyQuest;

	[HideInInspector]
	public bool _BindNewAchieve;

	[HideInInspector]
	public bool _BindFinishReceiveAllQuest;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual ViewBase CreateDailyQuestsView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void DailyQuestsAdded(ViewBase item)
	{
	}

	public virtual void DailyQuestsRemoved(ViewBase item)
	{
	}

	public virtual ViewBase CreateSideQuestsView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void SideQuestsAdded(ViewBase item)
	{
	}

	public virtual void SideQuestsRemoved(ViewBase item)
	{
	}

	public virtual ViewBase CreateRandomQuestsView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void RandomQuestsAdded(ViewBase item)
	{
	}

	public virtual void RandomQuestsRemoved(ViewBase item)
	{
	}

	public virtual void FinishiQuestExecuted()
	{
	}

	public virtual ViewBase CreateGuideQuestView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void GuideQuestAdded(ViewBase item)
	{
	}

	public virtual void GuideQuestRemoved(ViewBase item)
	{
	}

	public virtual void NewNormalQuestChanged(bool value)
	{
	}

	public virtual void NewStoryQuestChanged(bool value)
	{
	}

	public virtual ViewBase CreateStoryQuestView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void StoryQuestAdded(ViewBase item)
	{
	}

	public virtual void StoryQuestRemoved(ViewBase item)
	{
	}

	public virtual void AfterFinishQuestExecuted()
	{
	}

	public virtual ViewBase CreateActivityQuestView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void ActivityQuestAdded(ViewBase item)
	{
	}

	public virtual void ActivityQuestRemoved(ViewBase item)
	{
	}

	public virtual ViewBase CreateActivityDailyQuestView(QuestInfoViewModel item)
	{
		return null;
	}

	public virtual void ActivityDailyQuestAdded(ViewBase item)
	{
	}

	public virtual void ActivityDailyQuestRemoved(ViewBase item)
	{
	}

	public virtual void NewAPQuestChanged(bool value)
	{
	}

	public virtual void NewAPDailyQuestChanged(bool value)
	{
	}

	public virtual void NewAchieveChanged(bool value)
	{
	}

	public virtual void FinishReceiveAllQuestExecuted()
	{
	}

	public override void Bind()
	{
	}
}
