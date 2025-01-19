using System;
using UnityEngine;

public abstract class DrawSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _DrawType;

	[HideInInspector]
	public int _DrawResult;

	[HideInInspector]
	public int _RemainFreeGoldTime;

	[HideInInspector]
	public int _RemainFreeRMBTime;

	[HideInInspector]
	public bool _HaveFreeDraw;

	[HideInInspector]
	public int _GiftCouponNum;

	[HideInInspector]
	public long _ActID;

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

	public DrawSystemManagerViewModel DrawSystemManager
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

	public virtual void ExecuteDraw(DrawArgu arg)
	{
	}

	public virtual void ExecuteDrawFinish()
	{
	}
}
