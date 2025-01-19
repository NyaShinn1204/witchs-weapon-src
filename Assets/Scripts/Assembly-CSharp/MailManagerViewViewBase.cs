using UnityEngine;

public class MailManagerViewViewBase : MailManagerViewBase
{
	[HideInInspector]
	public bool _BindHaveNew;

	[HideInInspector]
	public bool _BindMails;

	[HideInInspector]
	public bool _MailsSceneFirst;

	[HideInInspector]
	public Transform _MailsContainer;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void HaveNewChanged(bool value)
	{
	}

	public virtual ViewBase CreateMailsView(MailContentInfoViewModel item)
	{
		return null;
	}

	public virtual void MailsAdded(ViewBase item)
	{
	}

	public virtual void MailsRemoved(ViewBase item)
	{
	}

	public override void Bind()
	{
	}
}
