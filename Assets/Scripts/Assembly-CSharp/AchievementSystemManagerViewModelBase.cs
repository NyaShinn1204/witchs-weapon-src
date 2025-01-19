using System.Collections.Specialized;

public class AchievementSystemManagerViewModelBase : ViewModel
{
	public P<int> _ReceiveResultProperty;

	public ModelCollection<AchievementInProgressViewModel> _AchievementsProperty;

	public ModelCollection<AchievementCompleteViewModel> _FinishAchievementsProperty;

	public ModelCollection<DrawResultData> _LootsProperty;

	protected CommandWithSenderAndArgument<AchievementSystemManagerViewModel, long> _GetReward;

	protected CommandWithSender<AchievementSystemManagerViewModel> _FinishGetReward;

	public AchievementSystemManagerViewModelBase(AchievementSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public AchievementSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void AchievementsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void FinishAchievementsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
