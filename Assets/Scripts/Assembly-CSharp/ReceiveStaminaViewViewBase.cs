using UnityEngine;

public class ReceiveStaminaViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishReceiveStamina;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishReceiveStaminaExecuted()
	{
	}

	public override void Bind()
	{
	}
}
