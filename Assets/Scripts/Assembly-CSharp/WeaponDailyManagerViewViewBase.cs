using UnityEngine;

public class WeaponDailyManagerViewViewBase : ProgressSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindSetTargetWeapon;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SetTargetWeaponExecuted()
	{
	}

	public override void Bind()
	{
	}
}
