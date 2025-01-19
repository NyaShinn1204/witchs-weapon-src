using UnityEngine;

public class PurchaseSystemManagerViewViewBase : PurchaseSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindBuyGoldSignal;

	[HideInInspector]
	public bool _BindBuyVitSignal;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void BuyGoldSignalChanged(bool value)
	{
	}

	public virtual void BuyVitSignalChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
