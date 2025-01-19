using System.Collections.Generic;

public class ExpeditionManagerViewModel : ExpeditionManagerViewModelBase
{
	public virtual P<int> CurrentIndexProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int CurrentIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> ResetResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ResetResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> ReceiveChestResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ReceiveChestResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> ChestGoldProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ChestGold
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> hpProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int hp
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> EnterCountProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int EnterCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public virtual P<int> CscCurrencyProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int CscCurrency
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<ExpeditionServant> Servants
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<ExpeditionProgressInfo> ExpeditionInfo
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ReceiveLoots
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<long> SelectedServants
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> ResetExpedition
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ExpeditionManagerViewModel, CommitExpeditionServant> CommitExpeditionServant
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> ReceiveChest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> RefreshExpedition
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> FinishReset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> FinishLoot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ExpeditionManagerViewModel, int> GetRank
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ExpeditionManagerViewModel> FinishGetRank
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ExpeditionManagerViewModel(ExpeditionManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ExpeditionManagerViewModel()
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
