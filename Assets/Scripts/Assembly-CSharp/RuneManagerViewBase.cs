using System;
using UnityEngine;

public abstract class RuneManagerViewBase : ViewBase
{
	[HideInInspector]
	public ViewBase _RuneToRefresh;

	[HideInInspector]
	public long _OprateTarget;

	public override string DefaultIdentifier
	{
		get
		{
			return null;
		}
	}

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public RuneManagerViewModel RuneManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override ViewModel CreateModel()
	{
		return null;
	}

	protected override void InitializeViewModel(ViewModel viewModel)
	{
	}

	public virtual void ExecuteDentify(long arg)
	{
	}

	public virtual void ExecuteDentifyConfirm(long arg)
	{
	}

	public virtual void ExecuteLock(long arg)
	{
	}

	public virtual void ExecuteMount(RuneMountArgu arg)
	{
	}

	public virtual void ExecuteAddExp(RuneArgument arg)
	{
	}

	public virtual void ExecuteBreakThrough(RuneArgument arg)
	{
	}

	public virtual void ExecutePromote(RuneArgument arg)
	{
	}

	public virtual void ExecuteResolve(string arg)
	{
	}

	public virtual void ExecuteUnlock(long arg)
	{
	}

	public virtual void ExecuteUnMount(RuneMountArgu arg)
	{
	}

	public virtual void ExecuteMountAll(long arg)
	{
	}

	public virtual void ExecuteUnMountAll(long arg)
	{
	}

	public virtual void ExecuteResolveAll()
	{
	}

	public virtual void ExecuteFinishResolve()
	{
	}

	public virtual void ExecuteFinishResolveAll()
	{
	}

	public virtual void ExecuteFinishDentify()
	{
	}

	public virtual void ExecuteFinishDentifyConfrim()
	{
	}

	public virtual void ExecuteFinishAddExp()
	{
	}

	public virtual void ExecuteFinishBreak()
	{
	}
}
