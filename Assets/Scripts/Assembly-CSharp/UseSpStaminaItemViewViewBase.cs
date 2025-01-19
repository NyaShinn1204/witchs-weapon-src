using UnityEngine;

public class UseSpStaminaItemViewViewBase : PackageManagerViewBase
{
	[HideInInspector]
	public bool _BindUseSpStamina;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void UseSpStaminaExecuted()
	{
	}

	public override void Bind()
	{
	}
}
