using System.Collections.Generic;

public class ProgressLevelViewModel : ProgressLevelViewModelBase
{
	private ProgressChapterViewModel _ParentProgressChapter;

	public virtual P<long> LevelIdProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long LevelId
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

	public virtual P<bool> IsClearProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsClear
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> BattleCountProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int BattleCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> BattleCountMaxProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int BattleCountMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> CanSweepProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanSweep
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual ProgressChapterViewModel ParentProgressChapter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ProgressLevelViewModel(ProgressLevelControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ProgressLevelViewModel()
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
