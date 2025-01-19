using System.Collections.Generic;

public class GuildUserManagerViewModel : GuildUserManagerViewModelBase
{
	public virtual P<bool> isOpenProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool isOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> LastTimeLeaveGuildProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long LastTimeLeaveGuild
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> GuildOpResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int GuildOpResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<GuildStateEnum> StateProperty
	{
		get
		{
			return null;
		}
	}

	public virtual GuildStateEnum State
	{
		get
		{
			return default(GuildStateEnum);
		}
		set
		{
		}
	}

	public virtual P<long> GuildCurrencyProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long GuildCurrency
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> GuildListPageNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int GuildListPageNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<GuildSimple> GuildRequestList
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<GuildSimple> CacheGuildList
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, string> SearchGuild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, string> RequestGuild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, string> CancelRequest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, GuildCreateArgu> CreateGuild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> FinishSearch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> FinishCreate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> FinishRequest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> FinishCancel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> Synchronize
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildUserManagerViewModel> FinishSynchronize
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, int> GetAllGuild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, int> SearchGuildByCE
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<GuildUserManagerViewModel, int> SearchGuildByMember
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GuildUserManagerViewModel(GuildUserManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public GuildUserManagerViewModel()
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
