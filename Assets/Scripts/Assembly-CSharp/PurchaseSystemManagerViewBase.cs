using System;
using UnityEngine;

public abstract class PurchaseSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public bool _BuyGoldSignal;

	[HideInInspector]
	public int _Mult;

	[HideInInspector]
	public long _RMB;

	[HideInInspector]
	public int _VitNow;

	[HideInInspector]
	public int _VitTime;

	[HideInInspector]
	public string _BuyGoldResult;

	[HideInInspector]
	public bool _BuyVitSignal;

	[HideInInspector]
	public string _BuyVitResult;

	[HideInInspector]
	public long _Gold;

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

	public PurchaseSystemManagerViewModel PurchaseSystemManager
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

	public virtual void ExecuteBuyGold()
	{
	}

	public virtual void ExecuteBuyVit()
	{
	}
}
