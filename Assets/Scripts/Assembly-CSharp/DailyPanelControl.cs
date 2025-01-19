using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class DailyPanelControl : CommonScenePanel
{
	public UITable trialTable;

	public UITable taskTable;

	public DailyProgressManagerView view;

	public static DailyPanelControl current;

	private GameObject trialItem;

	private GameObject taskItem;

	private int trialLockCount;

	private int taskLockCount;

	private string trialLockDesc;

	private string taskLockDesc;

	public TrialSelectLevel selectLevel;

	public UIScrollView scroll;

	public UIScrollBar bar;

	public long selectID;

	public ButtonEx helpBtn;

	public ButtonEx trialBtn;

	public ButtonEx taskBtn;

	public ButtonEx gameBtn;

	public UIScrollView dailyItemScroll;

	public Transform MoneyGame;

	private List<long> TrialChapterIDs
	{
		get
		{
			return null;
		}
	}

	private List<long> TaskChapterIDs
	{
		get
		{
			return null;
		}
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void SetScrollView(float _value)
	{
	}

	private void DrawGame()
	{
	}

	private void GoChapter(long _SetID = 0L)
	{
	}

	public void SelectChapter(long _chapterID)
	{
	}

	private void DrawTrial(long _SetID = 0L)
	{
	}

	private void DrawTask(long _SetID = 0L)
	{
	}

	private void GameLeveClick(GameObject obj)
	{
	}

	private void SetGameLeveClick()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}
}
