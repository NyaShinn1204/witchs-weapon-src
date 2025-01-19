using System;
using UnityEngine;

public abstract class CurrentLevelDetailViewBase : ViewBase
{
	[HideInInspector]
	public long _LevelId;

	[HideInInspector]
	public int _BattleCount;

	[HideInInspector]
	public int _ResetCount;

	[HideInInspector]
	public bool _IsLevelLock;

	[HideInInspector]
	public bool _IsChapterLock;

	[HideInInspector]
	public long _ChapterId;

	[HideInInspector]
	public bool _CanSweep;

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

	public CurrentLevelDetailViewModel CurrentLevelDetail
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
