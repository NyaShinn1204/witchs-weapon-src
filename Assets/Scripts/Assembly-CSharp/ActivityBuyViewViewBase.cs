using UnityEngine;

public class ActivityBuyViewViewBase : ShopSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishPay;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishPayExecuted()
	{
	}

	public override void Bind()
	{
	}
}
