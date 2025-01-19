using System.Collections.Generic;

public class CurrentLevelDetailViewModel : CurrentLevelDetailViewModelBase
{
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

	public virtual P<int> ResetCountProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ResetCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> IsLevelLockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsLevelLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> IsChapterLockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsChapterLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> ChapterIdProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ChapterId
	{
		get
		{
			return 0L;
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

	public virtual P<CurrentLevelDetailInfo> CurrentLevelInfoComputedPropertyProperty
	{
		get
		{
			return null;
		}
	}

	public virtual CurrentLevelDetailInfo CurrentLevelInfoComputedProperty
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CurrentLevelDetailViewModel(CurrentLevelDetailControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public CurrentLevelDetailViewModel()
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

	public override CurrentLevelDetailInfo ComputeCurrentLevelInfoComputedProperty()
	{
		return null;
	}
}
