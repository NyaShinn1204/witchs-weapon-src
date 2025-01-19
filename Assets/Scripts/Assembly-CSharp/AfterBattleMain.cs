using System.Collections;
using UnityEngine;

public class AfterBattleMain : MonoBehaviour
{
	private bool flip;

	public Animator animator;

	public ArrayList starsState;

	private ArrayList heroIcons;

	public UILabel expLable;

	public UILabel goldLable;

	public UILabel lvLable;

	public LootIcon loot1;

	public LootIcon loot2;

	public LootIcon loot3;

	public LootIcon loot4;

	private ArrayList loots;

	private ArrayList starDetails;

	public LootDetail lootDetail;

	public QuestFinish quest1;

	public QuestFinish quest2;

	public QuestFinish quest3;

	public CoverGround cover;

	public UISprite star1;

	public UISprite star2;

	public UISprite star3;

	private string levelID;

	public UISprite starDetailBtn;

	public UISprite resultBtn;

	public GameObject quests;

	public GameObject questFinishPre;

	public GameObject targetPosition;

	public GameObject levelup;

	public UIPanel levelupPanel;

	public UISprite exp_bar;

	public UISprite exp_mask;

	private LevelUPText lvlupText;

	public bool isAddlv;

	public bool isAddlvShow;

	public GameObject heroHeads;

	public GameObject heroHeadPrefab;

	private int current_user_lv;

	public AfterBattleMainQuest afterBattleMainQuest;

	private void Start()
	{
	}

	public void SetContent()
	{
	}

	private void Update()
	{
	}

	public void InitAndShow(string lvID, int exp, int gold, ArrayList newStars, ArrayList herodatas, bool addlv, int currenLV)
	{
	}

	private void AddHeroHead(ArrayList herodatas)
	{
	}

	private void InitHeroIcon(int[] heroId)
	{
	}

	public void ShowNewGetStars()
	{
	}

	public void AddGetStars()
	{
	}

	public void InitStarState(LevelData lvData, ArrayList newStars, ArrayList alreadyGetsStars, int index)
	{
	}

	public void SetStarNum(int num)
	{
	}

	public void SetLoots(string loot1, string loot2, string loot3, string loot4)
	{
	}

	public void Refresh()
	{
	}

	public void Play()
	{
	}

	public void SetExpAndGold(int exp, int gold)
	{
	}

	public void ClickStarDetail()
	{
	}

	public void HideQuest()
	{
	}

	public void HidenLvUP()
	{
	}

	public void SetStar()
	{
	}

	public void PlayFlipBorad()
	{
	}

	public void FlipBoradFinish()
	{
	}

	public void FlipBackBoradFinish()
	{
	}

	public void ShowLevelUP()
	{
	}

	public void ReplayQuest()
	{
	}

	public void ReturnMainUI()
	{
	}
}
