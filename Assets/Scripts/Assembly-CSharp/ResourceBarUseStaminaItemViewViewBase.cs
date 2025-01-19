using UnityEngine;

public class ResourceBarUseStaminaItemViewViewBase : PackageManagerViewBase
{
	[HideInInspector]
	public bool _BindUseSpStamina;

	[HideInInspector]
	public bool _BindUseItem;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void UseSpStaminaExecuted()
	{
	}

	public virtual void UseItemExecuted()
	{
	}

	public override void Bind()
	{
	}
}
