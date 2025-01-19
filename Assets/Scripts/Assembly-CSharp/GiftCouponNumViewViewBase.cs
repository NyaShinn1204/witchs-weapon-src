using UnityEngine;

public class GiftCouponNumViewViewBase : DrawSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindGiftCouponNum;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void GiftCouponNumChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
