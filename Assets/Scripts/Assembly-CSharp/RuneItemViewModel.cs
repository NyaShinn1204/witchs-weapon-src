using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

public class RuneItemViewModel : RuneItemViewModelBase
{
	private RuneManagerViewModel _ParentRuneManager;

	private ObservableSingleRune runeData;

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

	public virtual P<long> RuneIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RuneID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual RuneManagerViewModel ParentRuneManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObservableSingleRune RuneData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RuneItemViewModel(RuneItemControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public RuneItemViewModel()
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
