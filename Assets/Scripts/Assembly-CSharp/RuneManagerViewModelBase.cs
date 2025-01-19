using System.Collections.Specialized;

public class RuneManagerViewModelBase : ViewModel
{
	public P<RuneItemViewModel> _RuneToRefreshProperty;

	public P<DentifyResult> _DentifyResultProperty;

	public P<long> _OprateTargetProperty;

	public ModelCollection<RuneItemViewModel> _AllRuneProperty;

	public ModelCollection<DrawResultData> _ResolveRerultProperty;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _Dentify;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _DentifyConfirm;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _Lock;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, RuneMountArgu> _Mount;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> _AddExp;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> _BreakThrough;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, RuneArgument> _Promote;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, string> _Resolve;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _Unlock;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, RuneMountArgu> _UnMount;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _MountAll;

	protected CommandWithSenderAndArgument<RuneManagerViewModel, long> _UnMountAll;

	protected CommandWithSender<RuneManagerViewModel> _ResolveAll;

	protected CommandWithSender<RuneManagerViewModel> _FinishResolve;

	protected CommandWithSender<RuneManagerViewModel> _FinishResolveAll;

	protected CommandWithSender<RuneManagerViewModel> _FinishDentify;

	protected CommandWithSender<RuneManagerViewModel> _FinishDentifyConfrim;

	protected CommandWithSender<RuneManagerViewModel> _FinishAddExp;

	protected CommandWithSender<RuneManagerViewModel> _FinishBreak;

	public RuneManagerViewModelBase(RuneManagerControllerBase controller, bool initialize = true)
	{
	}

	public RuneManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void AllRuneCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
