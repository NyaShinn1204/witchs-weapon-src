using System.Collections;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class LevelSelectScenePanel : CommonScenePanel
{
	private ArrayList lootSprits;

	public GameObject levelPre;

	public GameObject levels;

	public GameObject loots;

	public GameObject lootPre;

	private int selectlv;

	private int currentChapter;

	private int currentLv;

	public GameObject lvIndex;

	public GameObject lvName;

	public GameObject chapterName;

	private string currentLevelID;

	private UISprite star1;

	private UISprite star2;

	private UISprite star3;

	private bool isStar1Active;

	private bool isStar2Active;

	private bool isStar3Active;

	public GameObject refreshButton;

	private bool isBackToMainPanel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InitPanelContent()
	{
	}

	public void Click_Back()
	{
	}

	public void Click_Last_Chapter()
	{
	}

	public void Click_Next_Chapter()
	{
	}

	public void SetLevelContent(LevelData lv)
	{
	}

	public void SetLoots(ArrayList loots)
	{
	}

	private void Setconsumption(int cost)
	{
	}

	private void SetChallenge(int challenge, int total)
	{
	}

	public void ClickRefreshButton()
	{
	}

	private void DisRefresh()
	{
	}

	private void EnableRefresh()
	{
	}

	private void SetReward(int exp, int gold)
	{
	}

	private void SetLevelIndex(string lvIndex)
	{
	}

	private void SetLevelName(string lvName)
	{
	}

	private void SetStarNum(LevelData lv, UserLevelData ulData)
	{
	}

	public void InitChapter()
	{
	}

	public void ClickStarLevel()
	{
	}

	public void ClickFight()
	{
	}

	public void SelectLevel(int index)
	{
	}

	public void ShowStarDetail()
	{
	}

	public void ConfirmRefresh()
	{
	}

	public void CancelRefresh()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void FinishOpenAnimation()
	{
	}
}
