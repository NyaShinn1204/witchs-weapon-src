using UnityEngine;

public class ProgressLevelViewViewBase : ProgressLevelViewBase
{
	[HideInInspector]
	public bool _BindCanFight;

	[HideInInspector]
	public bool _BindIsClear;

	[HideInInspector]
	public bool _BindBattleCount;

	[HideInInspector]
	public bool _BindCanSweep;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CanFightChanged(bool value)
	{
	}

	public virtual void IsClearChanged(bool value)
	{
	}

	public virtual void BattleCountChanged(int value)
	{
	}

	public virtual void CanSweepChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
