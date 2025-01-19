using UnityEngine;

public class FashionForMainUIViewViewBase : FashionSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindCurrentFashion;

	[HideInInspector]
	public bool _BindSelectFashion;

	[HideInInspector]
	public bool _BindBuyFashion;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CurrentFashionChanged(FashionInfo value)
	{
	}

	public virtual void SelectFashionExecuted()
	{
	}

	public virtual void BuyFashionExecuted()
	{
	}

	public override void Bind()
	{
	}
}
