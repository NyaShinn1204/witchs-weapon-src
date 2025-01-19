using UnityEngine;

public class QuestInfoViewViewBase : QuestInfoViewBase
{
	[HideInInspector]
	public bool _BindStatus;

	[HideInInspector]
	public bool _BindMeta;

	[HideInInspector]
	public bool _BindValid;

	[HideInInspector]
	public bool _BindGuide;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void StatusChanged(int value)
	{
	}

	public virtual void MetaChanged(int value)
	{
	}

	public virtual void ValidChanged(int value)
	{
	}

	public virtual void GuideChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
