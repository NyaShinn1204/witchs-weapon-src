using System;
using UnityEngine;

public abstract class MailContentInfoViewBase : ViewBase
{
	[HideInInspector]
	public bool _Readed;

	[HideInInspector]
	public bool _IsSpecialMail;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public MailContentInfoViewModel MailContentInfo
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
