using UnityEngine;

public class ExpeditionManagerViewViewBase : ExpeditionManagerViewBase
{
	[HideInInspector]
	public bool _BindCurrentIndex;

	[HideInInspector]
	public bool _BindEnterCount;

	[HideInInspector]
	public bool _BindFinishReset;

	[HideInInspector]
	public bool _BindFinishLoot;

	[HideInInspector]
	public bool _BindCscCurrency;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CurrentIndexChanged(int value)
	{
	}

	public virtual void EnterCountChanged(int value)
	{
	}

	public virtual void FinishResetExecuted()
	{
	}

	public virtual void FinishLootExecuted()
	{
	}

	public virtual void CscCurrencyChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
