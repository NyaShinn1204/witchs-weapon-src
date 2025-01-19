using UnityEngine;

public class ActivityPlayMainUIViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindActOpen;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ActOpenChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
