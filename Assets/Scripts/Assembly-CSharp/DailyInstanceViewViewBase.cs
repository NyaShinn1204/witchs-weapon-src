using UnityEngine;

public class DailyInstanceViewViewBase : DailyInstanceViewBase
{
	[HideInInspector]
	public bool _BindCanFight;

	[HideInInspector]
	public bool _BindIsPass;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CanFightChanged(bool value)
	{
	}

	public virtual void IsPassChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
