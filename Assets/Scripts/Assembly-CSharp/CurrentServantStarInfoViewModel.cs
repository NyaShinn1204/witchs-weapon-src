using System.Collections.Generic;

public class CurrentServantStarInfoViewModel : CurrentServantStarInfoViewModelBase
{
	public virtual P<long> StarInfoIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long StarInfoID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<NeedLoot> NeedItemProperty
	{
		get
		{
			return null;
		}
	}

	public virtual NeedLoot NeedItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> ItemNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ItemNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> StarLevelProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int StarLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> CostProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Cost
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<CurrentServantStarInfoViewModel, int> AddStarPoint
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<CurrentServantStarInfoViewModel> AddStartLv
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CurrentServantStarInfoViewModel(CurrentServantStarInfoControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public CurrentServantStarInfoViewModel()
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
