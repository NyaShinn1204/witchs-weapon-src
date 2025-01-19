using System.Collections.Generic;
using System.Collections.Specialized;

public class DailyInstanceSetViewModel : DailyInstanceSetViewModelBase
{
	private ProgressSystemManagerViewModel _ParentProgressSystemManager;

	public virtual P<long> IdProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Id
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> EnterCountsProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int EnterCounts
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<DailyInstanceViewModel> Levels
	{
		get
		{
			return null;
		}
	}

	public virtual ProgressSystemManagerViewModel ParentProgressSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DailyInstanceSetViewModel(DailyInstanceSetControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public DailyInstanceSetViewModel()
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

	protected override void LevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
