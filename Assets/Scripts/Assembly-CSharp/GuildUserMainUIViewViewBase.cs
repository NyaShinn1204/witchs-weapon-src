using UnityEngine;

public class GuildUserMainUIViewViewBase : GuildUserManagerViewBase
{
	[HideInInspector]
	public bool _BindisOpen;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void isOpenChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
