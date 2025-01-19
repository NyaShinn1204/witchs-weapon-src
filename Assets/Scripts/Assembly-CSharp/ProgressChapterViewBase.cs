using System;
using UnityEngine;

public abstract class ProgressChapterViewBase : ViewBase
{
	[HideInInspector]
	public long _ChapterId;

	[HideInInspector]
	public int _EnterCounts;

	[HideInInspector]
	public bool _IsLock;

	[HideInInspector]
	public string _ChapterName;

	[HideInInspector]
	public int _EnterCountMax;

	[HideInInspector]
	public int _ChapterType;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public ProgressChapterViewModel ProgressChapter
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
