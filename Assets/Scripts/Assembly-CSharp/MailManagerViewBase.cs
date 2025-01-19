using System;
using UnityEngine;

public abstract class MailManagerViewBase : ViewBase
{
	[HideInInspector]
	public bool _HaveNew;

	[HideInInspector]
	public int _NotReadNum;

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

	public MailManagerViewModel MailManager
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

	public virtual void ExecuteUpdateCommonMailState(string arg)
	{
	}

	public virtual void ExecuteUpdateSpecialMailState(string arg)
	{
	}

	public virtual void ExecuteGetAttach(string arg)
	{
	}

	public virtual void ExecuteDeleteNormal(string arg)
	{
	}
}
