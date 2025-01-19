using System;
using UnityEngine;

public abstract class QuestInfoViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	[HideInInspector]
	public int _Status;

	[HideInInspector]
	public int _Valid;

	[HideInInspector]
	public int _Meta;

	[HideInInspector]
	public bool _Guide;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public QuestInfoViewModel QuestInfo
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
