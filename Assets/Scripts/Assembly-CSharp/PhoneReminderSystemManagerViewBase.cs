using System;
using UnityEngine;

public abstract class PhoneReminderSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public bool _ShowRedPoint;

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

	public PhoneReminderSystemManagerViewModel PhoneReminderSystemManager
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
}
