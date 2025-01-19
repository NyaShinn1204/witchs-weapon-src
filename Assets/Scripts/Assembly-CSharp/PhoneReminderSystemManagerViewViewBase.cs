using UnityEngine;

public class PhoneReminderSystemManagerViewViewBase : PhoneReminderSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindShowRedPoint;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ShowRedPointChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
