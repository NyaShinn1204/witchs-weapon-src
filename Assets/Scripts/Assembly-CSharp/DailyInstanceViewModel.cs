using System.Collections.Generic;

public class DailyInstanceViewModel : DailyInstanceViewModelBase
{
	private DailyInstanceSetViewModel _ParentDailyInstanceSet;

	public virtual P<long> IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<bool> CanFightProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanFight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> IsPassProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsPass
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual DailyInstanceSetViewModel ParentDailyInstanceSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DailyInstanceViewModel(DailyInstanceControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public DailyInstanceViewModel()
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
