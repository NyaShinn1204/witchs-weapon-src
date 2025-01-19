using UnityEngine;

public class ProgressChapterViewViewBase : ProgressChapterViewBase
{
	[HideInInspector]
	public bool _BindIsLock;

	[HideInInspector]
	public bool _BindEnterCounts;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void IsLockChanged(bool value)
	{
	}

	public virtual void EnterCountsChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
