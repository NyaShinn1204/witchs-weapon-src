using UnityEngine;

public class FashionForBattleViewViewBase : FashionSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindSelectFashion;

	[HideInInspector]
	public bool _BindCurrentFashion;

	[HideInInspector]
	public bool _BindBuyFashion;

	[HideInInspector]
	public bool _BindFinishRefresh;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SelectFashionExecuted()
	{
	}

	public virtual void CurrentFashionChanged(FashionInfo value)
	{
	}

	public virtual void BuyFashionExecuted()
	{
	}

	public virtual void FinishRefreshExecuted()
	{
	}

	public override void Bind()
	{
	}
}
