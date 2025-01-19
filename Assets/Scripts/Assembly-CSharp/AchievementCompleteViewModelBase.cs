public class AchievementCompleteViewModelBase : ViewModel
{
	public P<FinishAchievementData> _InfoProperty;

	public P<long> _IDProperty;

	public AchievementCompleteViewModelBase(AchievementCompleteControllerBase controller, bool initialize = true)
	{
	}

	public AchievementCompleteViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
