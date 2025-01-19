using UnityEngine;

public class ServantWeaponExpItemViewViewBase : ServantWeaponExpItemViewBase
{
	[HideInInspector]
	public bool _BindNum;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NumChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
