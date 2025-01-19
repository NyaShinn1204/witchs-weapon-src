using UnityEngine;

public class ReminderComposeViewViewBase : ServantListManagerViewBase
{
	[HideInInspector]
	public bool _BindNeedShowRedStar;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NeedShowRedStarChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
