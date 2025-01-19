using UnityEngine;

public class ApResBarViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindIsReceiveInitStamina;

	[HideInInspector]
	public bool _BindIsReceiveDailyStamina;

	[HideInInspector]
	public bool _BindReceiveInitStamina;

	[HideInInspector]
	public bool _BindReceiveDailyStamina;

	[HideInInspector]
	public bool _BindCurrency;

	[HideInInspector]
	public bool _BindTicket;

	[HideInInspector]
	public bool _BindActivityStamina;

	[HideInInspector]
	public bool _BindCurrency2;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void IsReceiveInitStaminaChanged(bool value)
	{
	}

	public virtual void IsReceiveDailyStaminaChanged(bool value)
	{
	}

	public virtual void ReceiveInitStaminaExecuted()
	{
	}

	public virtual void ReceiveDailyStaminaExecuted()
	{
	}

	public virtual void CurrencyChanged(long value)
	{
	}

	public virtual void TicketChanged(long value)
	{
	}

	public virtual void ActivityStaminaChanged(long value)
	{
	}

	public virtual void Currency2Changed(long value)
	{
	}

	public override void Bind()
	{
	}
}
