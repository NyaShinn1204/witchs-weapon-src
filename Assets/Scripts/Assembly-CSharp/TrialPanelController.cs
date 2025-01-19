using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class TrialPanelController : CommonScenePanel
{
	public static TrialPanelController current;

	public Transform trial;

	public Transform task;

	public TrialSelectLevel selectLevel;

	private List<int> open;

	private List<int> close;

	public DailyProgressManagerView view;

	public ButtonEx returnButton;

	public ButtonEx[] trialBtn;

	public ButtonEx[] taskBtn;

	public ButtonEx[] levelsButtonEx;

	private long currentChapterID;

	private long currentLevelID;

	public ButtonEx bgCollider;

	public ButtonEx cannelBtn;

	public UIScrollView scroll;

	public UIScrollBar bar;

	public ButtonEx help;

	private string monday;

	private string tuesday;

	private string wednesday;

	private string thursday;

	private string friday;

	private string saturday;

	private string sunday;

	private void Start()
	{
	}

	protected override void AddConfigItem()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void Init()
	{
	}

	private void GoChapter()
	{
	}

	private void DrawTrial()
	{
	}

	private void DrawTask()
	{
	}

	private void CanGo(Transform trans, long _chapterID)
	{
	}

	private int CaculateWeekDay()
	{
		return 0;
	}

	private bool IsPlay(int number, string _key)
	{
		return false;
	}

	private string CanDo(string _key)
	{
		return null;
	}

	private void GoTrial(Transform trans)
	{
	}

	private void GoLevel(int index)
	{
	}

	private void ShowHelp()
	{
	}

	private void Binding()
	{
	}

	private void AddEvent()
	{
	}

	private void CloseLevel()
	{
	}

	private void ReturnView()
	{
	}

	private void SetPosition(int num)
	{
	}
}
