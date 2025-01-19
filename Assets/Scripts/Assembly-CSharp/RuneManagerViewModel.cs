using System.Collections.Generic;
using System.Collections.Specialized;

public class RuneManagerViewModel : RuneManagerViewModelBase
{
	public virtual P<RuneItemViewModel> RuneToRefreshProperty
	{
		get
		{
			return null;
		}
	}

	public virtual RuneItemViewModel RuneToRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<DentifyResult> DentifyResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual DentifyResult DentifyResult
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> OprateTargetProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long OprateTarget
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual ModelCollection<RuneItemViewModel> AllRune
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ResolveRerult
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> Dentify
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> DentifyConfirm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> Lock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, RuneMountArgu> Mount
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> AddExp
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> BreakThrough
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> Promote
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, string> Resolve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> Unlock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, RuneMountArgu> UnMount
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> MountAll
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<RuneManagerViewModel, long> UnMountAll
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> ResolveAll
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishResolve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishResolveAll
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishDentify
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishDentifyConfrim
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishAddExp
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<RuneManagerViewModel> FinishBreak
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RuneManagerViewModel(RuneManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public RuneManagerViewModel()
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

	protected override void AllRuneCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
