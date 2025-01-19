using System.Collections.Generic;
using System.Collections.Specialized;

public class QuestSystemManagerViewModel : QuestSystemManagerViewModelBase
{
	public virtual P<int> BeforeLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int BeforeLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> AfterLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int AfterLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> BeforeStaminaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int BeforeStamina
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> AfterStaminaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int AfterStamina
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> NewNormalQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewNormalQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> NewGuideQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewGuideQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> NewStoryQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewStoryQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> InProgressGuideQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool InProgressGuideQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> QuestResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int QuestResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> NewAPQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewAPQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> NewAPDailyQuestProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewAPDailyQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> NewAchieveProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NewAchieve
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> DailyQuests
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> SideQuests
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> RandomQuests
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> GuideQuest
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> StoryQuest
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> ActivityQuest
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> QuestLoots
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<QuestInfoViewModel> ActivityDailyQuest
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<QuestSystemManagerViewModel, long> FinishiQuest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<QuestSystemManagerViewModel, long> OpenGuide
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<QuestSystemManagerViewModel> AfterFinishQuest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<QuestSystemManagerViewModel, int> ReceiveAllQuest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<QuestSystemManagerViewModel> FinishReceiveAllQuest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public QuestSystemManagerViewModel(QuestSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public QuestSystemManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}

	protected override void DailyQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void SideQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void RandomQuestsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void GuideQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void StoryQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void ActivityQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void ActivityDailyQuestCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
