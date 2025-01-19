using UnityEngine;

public class ServantRuneViewViewBase : RuneManagerViewBase
{
	[HideInInspector]
	public bool _BindMountAll;

	[HideInInspector]
	public bool _BindUnMountAll;

	[HideInInspector]
	public bool _BindLock;

	[HideInInspector]
	public bool _BindUnlock;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void MountAllExecuted()
	{
	}

	public virtual void UnMountAllExecuted()
	{
	}

	public virtual void LockExecuted()
	{
	}

	public virtual void UnlockExecuted()
	{
	}

	public override void Bind()
	{
	}
}
