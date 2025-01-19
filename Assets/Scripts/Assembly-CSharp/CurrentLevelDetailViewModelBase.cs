using System;
using System.Collections.Generic;
using System.Diagnostics;

public class CurrentLevelDetailViewModelBase : ViewModel
{
	private IDisposable _CurrentLevelInfoComputedPropertyDisposable;

	public P<long> _LevelIdProperty;

	public P<int> _BattleCountProperty;

	public P<int> _ResetCountProperty;

	public P<bool> _IsLevelLockProperty;

	public P<bool> _IsChapterLockProperty;

	public P<long> _ChapterIdProperty;

	public P<bool> _CanSweepProperty;

	public P<CurrentLevelDetailInfo> _CurrentLevelInfoComputedPropertyProperty;

	public CurrentLevelDetailViewModelBase(CurrentLevelDetailControllerBase controller, bool initialize = true)
	{
	}

	public CurrentLevelDetailViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	public virtual void ResetCurrentLevelInfoComputedProperty()
	{
	}

	public virtual CurrentLevelDetailInfo ComputeCurrentLevelInfoComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetCurrentLevelInfoComputedPropertyDependents()
	{
		return null;
	}
}
