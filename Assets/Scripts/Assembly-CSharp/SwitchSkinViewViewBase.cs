using UnityEngine;

public class SwitchSkinViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindSwitchSkin;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SwitchSkinExecuted()
	{
	}

	public override void Bind()
	{
	}
}
