using UnityEngine;

public class CurrentServantStarInfoViewViewBase : CurrentServantStarInfoViewBase
{
	[HideInInspector]
	public bool _BindStarInfoID;

	[HideInInspector]
	public bool _BindAddStartLv;

	[HideInInspector]
	public bool _BindItemNum;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void StarInfoIDChanged(long value)
	{
	}

	public virtual void AddStartLvExecuted()
	{
	}

	public virtual void ItemNumChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
