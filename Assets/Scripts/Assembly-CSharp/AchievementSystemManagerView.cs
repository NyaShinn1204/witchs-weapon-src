public class AchievementSystemManagerView : AchievementSystemManagerViewViewBase
{
	public override void FinishGetRewardExecuted()
	{
	}

	public override ViewBase CreateAchievementsView(AchievementInProgressViewModel item)
	{
		return null;
	}

	public override void AchievementsAdded(ViewBase item)
	{
	}

	public override void AchievementsRemoved(ViewBase item)
	{
	}

	public override ViewBase CreateFinishAchievementsView(AchievementCompleteViewModel item)
	{
		return null;
	}

	public override void FinishAchievementsAdded(ViewBase item)
	{
	}

	public override void FinishAchievementsRemoved(ViewBase item)
	{
	}
}
