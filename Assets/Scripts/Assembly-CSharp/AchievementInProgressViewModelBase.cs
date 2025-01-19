using System;
using System.Collections.Generic;
using System.Diagnostics;

public class AchievementInProgressViewModelBase : ViewModel
{
	private IDisposable _AchievementInProgressInfoDisposable;

	public P<int> _StatusProperty;

	public P<string> _ArgusProperty;

	public P<long> _CurrentIDProperty;

	public P<long> _HeadIDProperty;

	public P<AchievementData> _AchievementInProgressInfoProperty;

	public AchievementInProgressViewModelBase(AchievementInProgressControllerBase controller, bool initialize = true)
	{
	}

	public AchievementInProgressViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	public virtual void ResetAchievementInProgressInfo()
	{
	}

	public virtual AchievementData ComputeAchievementInProgressInfo()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetAchievementInProgressInfoDependents()
	{
		return null;
	}
}
