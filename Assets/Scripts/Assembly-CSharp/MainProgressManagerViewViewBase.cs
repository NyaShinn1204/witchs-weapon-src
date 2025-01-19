using UnityEngine;

public class MainProgressManagerViewViewBase : ProgressSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindNewUnlockLevel;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NewUnlockLevelChanged(long value)
	{
	}

	public override void Bind()
	{
	}
}
