using UnityEngine;

public class AchievementSystemManagerViewViewBase : AchievementSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindAchievements;

	[HideInInspector]
	public bool _AchievementsSceneFirst;

	[HideInInspector]
	public Transform _AchievementsContainer;

	[HideInInspector]
	public bool _BindFinishAchievements;

	[HideInInspector]
	public bool _FinishAchievementsSceneFirst;

	[HideInInspector]
	public Transform _FinishAchievementsContainer;

	[HideInInspector]
	public bool _BindFinishGetReward;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual ViewBase CreateAchievementsView(AchievementInProgressViewModel item)
	{
		return null;
	}

	public virtual void AchievementsAdded(ViewBase item)
	{
	}

	public virtual void AchievementsRemoved(ViewBase item)
	{
	}

	public virtual ViewBase CreateFinishAchievementsView(AchievementCompleteViewModel item)
	{
		return null;
	}

	public virtual void FinishAchievementsAdded(ViewBase item)
	{
	}

	public virtual void FinishAchievementsRemoved(ViewBase item)
	{
	}

	public virtual void FinishGetRewardExecuted()
	{
	}

	public override void Bind()
	{
	}
}
