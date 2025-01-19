using UnityEngine;

public class CurrentLevelDetailViewViewBase : CurrentLevelDetailViewBase
{
	[HideInInspector]
	public bool _BindCurrentLevelInfoComputedProperty;

	[HideInInspector]
	public bool _BindBattleCount;

	[HideInInspector]
	public bool _BindResetCount;

	[HideInInspector]
	public bool _BindCanSweep;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CurrentLevelInfoComputedPropertyChanged(CurrentLevelDetailInfo value)
	{
	}

	public virtual void BattleCountChanged(int value)
	{
	}

	public virtual void ResetCountChanged(int value)
	{
	}

	public virtual void CanSweepChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
