using UnityEngine;

public class AchievementInProgressViewViewBase : AchievementInProgressViewBase
{
	[HideInInspector]
	public bool _BindAchievementInProgressInfo;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void AchievementInProgressInfoChanged(AchievementData value)
	{
	}

	public override void Bind()
	{
	}
}
