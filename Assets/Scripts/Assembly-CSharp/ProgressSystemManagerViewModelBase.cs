using System.Collections.Specialized;

public class ProgressSystemManagerViewModelBase : ViewModel
{
	public P<long> _NewUnlockLevelProperty;

	public P<SweepInfo> _SweepInfoProperty;

	public P<int> _SweepResultProperty;

	public P<int> _WeaponChooseTimeProperty;

	public ModelCollection<ProgressChapterViewModel> _MainChaptersProperty;

	public ModelCollection<DailyInstanceSetViewModel> _DailyChaptersProperty;

	public ModelCollection<DailyInstanceSetViewModel> _WeaponDailyChaptersProperty;

	protected CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> _SelectlLevelByID;

	protected CommandWithSender<ProgressSystemManagerViewModel> _ResetBattleCount;

	protected CommandWithSenderAndArgument<ProgressSystemManagerViewModel, SweepArgu> _Sweep;

	protected CommandWithSender<ProgressSystemManagerViewModel> _SweepFinish;

	protected CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> _ResetBattleCountByID;

	protected CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> _SetTargetWeapon;

	public ProgressSystemManagerViewModelBase(ProgressSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public ProgressSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void MainChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void DailyChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void WeaponDailyChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
