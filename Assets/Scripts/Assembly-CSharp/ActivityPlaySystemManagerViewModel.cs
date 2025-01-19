using System.Collections.Generic;

public class ActivityPlaySystemManagerViewModel : ActivityPlaySystemManagerViewModelBase
{
	public virtual P<bool> IsOpenProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> IsReceiveInitStaminaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsReceiveInitStamina
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> IsReceiveDailyStaminaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsReceiveDailyStamina
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> CurrencyProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Currency
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> ActivityStaminaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ActivityStamina
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<bool> UnlockStoryProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool UnlockStory
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> ActOpenProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool ActOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> TicketProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Ticket
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> FightCountProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int FightCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> SweepResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int SweepResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> Currency2Property
	{
		get
		{
			return null;
		}
	}

	public virtual long Currency2
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual ModelCollection<DrawResultData> DrawLoot
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ExtraWeapon
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ExtraBonus
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<long> LootBuff
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<int> LootBuffLayer
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> ReceiveInitStamina
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> ReceiveDailyStamina
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> Reset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> GetReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishGetRewaed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishReset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> UnlockAPStory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> GetRank
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishGetRank
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, SweepArgu> Sweep
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishSweep
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> GoToNextFloorRule1
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishGoToNextFloorRule1
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, string> AttributeAdd
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishAttributeAdd
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> AttributeReset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishAttributeReset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> Rule5Reset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> Rule5GiveUp
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> Rule5Getreward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishRule5Reset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishRule5GiveUp
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishRule5Getreward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> Rule5UnlockFinalRound
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, ChangeKeyArg> ChangeKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishRule5UnlockFinalRound
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishChangeKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> R4ChooseMobLevel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishR4ChooseMobLevel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> R5ChooseMobLevel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ActivityPlaySystemManagerViewModel> FinishR5ChooseMobLevel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ActivityPlaySystemManagerViewModel(ActivityPlaySystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ActivityPlaySystemManagerViewModel()
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
}
