using UnityEngine;

public class UserInfoForSvDevelopViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindRMB;

	[HideInInspector]
	public bool _BindGold;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void RMBChanged(long value)
	{
	}

	public virtual void GoldChanged(long value)
	{
	}

	public override void Bind()
	{
	}
}
