public class UserAchievementManagerViewModelBase : ViewModel
{
	public ModelCollection<AchievementData> _AchievementsProperty;

	public ModelCollection<FinishAchievementData> _FinishAchievementsProperty;

	protected CommandWithSenderAndArgument<UserAchievementManagerViewModel, long> _GetRewardChange;

	protected CommandWithSender<UserAchievementManagerViewModel> _RefreshAchieve;

	public UserAchievementManagerViewModelBase(UserAchievementManagerControllerBase controller, bool initialize = true)
	{
	}

	public UserAchievementManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
