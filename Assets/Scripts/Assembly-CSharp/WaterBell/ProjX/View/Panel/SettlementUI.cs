using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class SettlementUI : UIPanelSingle
	{
		public enum AnimTypes
		{
			General = 0,
			SkipAnim = 1,
			SkipSvHead = 2
		}

		private const string WIN_HERO_IMAGE = "UI/UIImage/Settlement/win";

		private const string LOSE_HERO_IMAGE = "UI/UIImage/Settlement/lose";

		private static Color winBgColor;

		private static Color loseBgColor;

		public static GameObject instance;

		public GameObject servantContainer;

		public List<SeetlementWatchmenUI> servantPhotoList;

		public DoTweenLabel goldTweener;

		public DoTweenLabel expTweener;

		public UIPanelSingleContainer lootContainer;

		public UILabel timeLabel;

		public UILabel hpLabel;

		public UILabel instanceIndexLabel;

		public GameObject winTop;

		public GameObject loseTop;

		public SettlementTask settlementTask;

		public UISprite[] bgColorElements;

		public UISprite lootLine;

		public UIGrid lootGrid;

		public ButtonEx restartButton;

		public ButtonEx endGameButton;

		public ButtonEx closeHeadButton;

		public ButtonEx quitButton;

		public GameObject resetButtonStyle1;

		public GameObject resetButtonStyle2;

		public LoadUIPanelSingle getServantAnimLoader;

		public LoadUIPanelSingle getWeaponAnimLoader;

		public LoadUIPanelSingle chapterLevelUpLoader;

		public LoadUIPanelSingle buyItemLoader;

		public LoadUIPanelSingle failCauseLoader;

		public LoadUIPanelSingle ap1Loader;

		public LoadUIPanelSingle ap3Loader;

		public LoadUIPanelSingle ap4Loader;

		public LoadUIPanelSingle ap5Loader;

		public UILabel SettlementBattleTime;

		public UILabel SettlementBattleHP;

		public UILabel SettlementReward;

		public long instanceId;

		public long clothID;

		public AnimTypes animType;

		public bool isWin;

		public long gold;

		public long goldBefore;

		public long expInc;

		public int level;

		public int levelBefore;

		public int vit;

		public int vitBefore;

		public ModeType modeType;

		public List<SeetlementWatchmenUIData> servantDataList;

		public List<LotteryLootData> lootItemDataList;

		public int timeSec;

		public float hp;

		public float bhp;

		public bool isDebugMode;

		private int lootLineWidth;

		private Vector3 initHeroPosition;

		private Vector3 initHeroRotation;

		private Vector3 initHeroScale;

		private TypeCsvInstance instanceCsv;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void SetAnim(AnimTypes settlementType = AnimTypes.General)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		[DebuggerHidden]
		private IEnumerator ShowPanel()
		{
			return null;
		}

		public void InitExp()
		{
		}

		public void InitGold()
		{
		}

		public void WaitClickHead()
		{
		}

		public void AnimCallShowButtons()
		{
		}

		public void InitLoot()
		{
		}

		private void ShowAP1()
		{
		}

		private void ShowAP3()
		{
		}

		private void ShowAP4()
		{
		}

		private void ShowAP5()
		{
		}

		public void ShowBuyItemPanel()
		{
		}

		public void InitHeads()
		{
		}

		public void ShowFailCausePanel()
		{
		}

		[DebuggerHidden]
		private IEnumerator PlayHeadAnim(SeetlementWatchmenUI head, float delay)
		{
			return null;
		}

		public void InitChapterLevelUpPanel()
		{
		}

		private void EndGame()
		{
		}

		private void Restart()
		{
		}

		protected override void BindData()
		{
		}
	}
}
