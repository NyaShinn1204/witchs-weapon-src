using System.Collections.Generic;

public class GuildMercenaryManagerViewModel : GuildMercenaryManagerViewModelBase
{
	public virtual P<int> MaxSvNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int MaxSvNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> OpResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int OpResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> ModeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Mode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> RemoveMercenaryRewardProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RemoveMercenaryReward
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> RemoveMecGoldRewardProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RemoveMecGoldReward
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual ModelCollection<GuildMercenarySv> Servants
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<GuildMercenarySv> OwnServants
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<int> MercenaryRewards
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, AddSvArgu> AddSv
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, long> RemoveSv
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FreshMercenariesList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishFresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishAdd
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishRemove
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FreshCanHireList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishFreshCanHireList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, SelectSvGroup> SelectBattleGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishSelectBattleGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, SelectSvGroup> HireMercenary
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildMercenaryManagerViewModel> FinishHireMercenary
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GuildMercenaryManagerViewModel(GuildMercenaryManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public GuildMercenaryManagerViewModel()
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
