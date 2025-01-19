using System.Collections.Generic;

public class AchievementCompleteViewModel : AchievementCompleteViewModelBase
{
	private AchievementSystemManagerViewModel _ParentAchievementSystemManager;

	public virtual P<FinishAchievementData> InfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual FinishAchievementData Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public AchievementCompleteViewModel(AchievementCompleteControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public AchievementCompleteViewModel()
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
