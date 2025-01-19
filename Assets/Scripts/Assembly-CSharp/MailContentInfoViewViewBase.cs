using UnityEngine;

public class MailContentInfoViewViewBase : MailContentInfoViewBase
{
	[HideInInspector]
	public bool _BindReaded;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ReadedChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
