using System.Collections.Specialized;

public class QuestSystemManagerViewModelBase : ViewModel
{
	public P<int> _BeforeLvProperty;

	public P<int> _AfterLvProperty;

	public P<int> _BeforeStaminaProperty;

	public P<int> _AfterStaminaProperty;

	public P<bool> _NewNormalQuestProperty;

	public P<bool> _NewGuideQuestProperty;

	public P<bool> _NewStoryQuestProperty;

	public P<bool> _InProgressGuideQuestProperty;

	public P<int> _QuestResultProperty;

	public P<bool> _NewAPQuestProperty;

	public P<bool> _NewAPDailyQuestProperty;

	public P<bool> _NewAchieveProperty;

	public ModelCollection<QuestInfoViewModel> _DailyQuestsProperty;

	public ModelCollection<QuestInfoViewModel> _SideQuestsProperty;

	public ModelCollection<QuestInfoViewModel> _RandomQuestsProperty;

	public ModelCollection<QuestInfoViewModel> _GuideQuestProperty;

	public ModelCollection<QuestInfoViewModel> _StoryQuestProperty;

	public ModelCollection<QuestInfoViewModel> _ActivityQuestProperty;

	public ModelCollection<DrawResultData> _QuestLootsProperty;

	public ModelCollection<QuestInfoViewModel> _ActivityDailyQuestProperty;

	protected CommandWithSenderAndArgument<QuestSystemManagerViewModel, long> _FinishiQuest;

	protected CommandWithSenderAndArgument<QuestSystemManagerViewModel, long> _OpenGuide;

	protected CommandWithSender<QuestSystemManagerViewModel> _AfterFinishQuest;

	protected CommandWithSenderAndArgument<QuestSystemManagerViewModel, int> _ReceiveAllQuest;

	protected CommandWithSender<QuestSystemManagerViewModel> _FinishReceiveAllQuest;

	public QuestSystemManagerViewModelBase(QuestSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public QuestSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void DailyQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void SideQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void RandomQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void GuideQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void StoryQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void ActivityQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void ActivityDailyQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
