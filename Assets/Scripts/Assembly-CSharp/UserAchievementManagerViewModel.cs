using System.Collections.Generic;

public class UserAchievementManagerViewModel : UserAchievementManagerViewModelBase
{
	public virtual ModelCollection<AchievementData> Achievements
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<FinishAchievementData> FinishAchievements
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<UserAchievementManagerViewModel, long> GetRewardChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<UserAchievementManagerViewModel> RefreshAchieve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UserAchievementManagerViewModel(UserAchievementManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public UserAchievementManagerViewModel()
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
