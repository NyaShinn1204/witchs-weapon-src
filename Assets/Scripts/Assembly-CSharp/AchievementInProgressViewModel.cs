using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

public class AchievementInProgressViewModel : AchievementInProgressViewModelBase
{
	private AchievementSystemManagerViewModel _ParentAchievementSystemManager;

	public ProgressingAchieveDetail pro;

	public virtual P<int> StatusProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Status
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<string> ArgusProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Argus
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> CurrentIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long CurrentID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> HeadIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long HeadID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<AchievementData> AchievementInProgressInfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual AchievementData AchievementInProgressInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual AchievementSystemManagerViewModel ParentAchievementSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AchievementInProgressViewModel(AchievementInProgressControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public AchievementInProgressViewModel()
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

	public override AchievementData ComputeAchievementInProgressInfo()
	{
		return null;
	}
}
