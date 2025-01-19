using System.Collections.Generic;
using System.Collections.Specialized;

public class ProgressSystemManagerViewModel : ProgressSystemManagerViewModelBase
{
	public virtual P<long> NewUnlockLevelProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long NewUnlockLevel
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<SweepInfo> SweepInfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual SweepInfo SweepInfo
	{
		get
		{
			return null;
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

	public virtual P<int> WeaponChooseTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int WeaponChooseTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<ProgressChapterViewModel> MainChapters
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DailyInstanceSetViewModel> DailyChapters
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DailyInstanceSetViewModel> WeaponDailyChapters
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> SelectlLevelByID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ProgressSystemManagerViewModel> ResetBattleCount
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ProgressSystemManagerViewModel, SweepArgu> Sweep
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ProgressSystemManagerViewModel> SweepFinish
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> ResetBattleCountByID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ProgressSystemManagerViewModel, long> SetTargetWeapon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ProgressSystemManagerViewModel(ProgressSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ProgressSystemManagerViewModel()
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

	protected override void MainChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void DailyChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void WeaponDailyChaptersCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
