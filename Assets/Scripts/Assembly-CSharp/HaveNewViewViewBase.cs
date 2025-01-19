using UnityEngine;

public class HaveNewViewViewBase : MailManagerViewBase
{
	[HideInInspector]
	public bool _BindHaveNew;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void HaveNewChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
