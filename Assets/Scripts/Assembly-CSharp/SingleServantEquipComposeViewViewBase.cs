using UnityEngine;

public class SingleServantEquipComposeViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindUseEuip;

	[HideInInspector]
	public bool _BindComposeEquip;

	[HideInInspector]
	public bool _BindComposeEquipOneClick;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void UseEuipExecuted()
	{
	}

	public virtual void ComposeEquipExecuted()
	{
	}

	public virtual void ComposeEquipOneClickExecuted()
	{
	}

	public override void Bind()
	{
	}
}
