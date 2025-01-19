using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetLootsPanel : UIPanelSingle
	{
		public static GetLootsPanel current;

		private const string PREFAB_PATH = "UI/Prefab/GetLootsPanel";

		public UIPanelSingleContainer lootContainer;

		public ButtonEx closeButton;

		public ButtonEx skipButton;

		public UISprite box;

		private GameObject item;

		private int BeforeLv;

		private int AfterLv;

		private int BeforeStamina;

		private int AfterStamina;

		private bool isUp;

		private bool isSkipAnim;

		private int itemCount;

		private bool canClick;

		private List<LotteryLootData> _datas;

		public int num;

		private Action OnCloseEvent;

		[SerializeField]
		private List<LotteryLootData> dataList;

		private Sequence sequence;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static GetLootsPanel GetInstance()
		{
			return null;
		}

		public static void ShowAwards(List<LotteryLootData> dataList, Action onCloseEvent = null)
		{
		}

		public void OpenPanel(List<LotteryLootData> dataList, Action onCloseEvent = null)
		{
		}

		private void DirectClosePanel()
		{
		}

		private void SkipAnim()
		{
		}

		[DebuggerHidden]
		private IEnumerator DirectShowLoot()
		{
			return null;
		}

		private void ShowLootOneByOne()
		{
		}

		private void PlayNext()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Hide()
		{
		}

		public void Init()
		{
		}

		public void ShowStamina()
		{
		}

		public void ShowAPStamina(int stamina)
		{
		}

		public void ShowQuastFallItem(List<DrawResultData> loots)
		{
		}

		public void ShowQuastFallItem(long questID, int bLV, int aLV, int bVIT, int aVIT, List<DrawResultData> loots)
		{
		}

		public void ShowSignLoot(int day)
		{
		}

		public void ShowGuildServantReward(long num, long goldnum)
		{
		}

		public void ShowPayLoot(ModelCollection<DrawResultData> datas)
		{
		}

		public void ShowShopFallItem(ModelCollection<DrawResultData> datas, ModelCollection<DrawResultData> weapons)
		{
		}

		public void ShowShowPayFallItem(long itemID, bool isFirstBuy)
		{
		}

		public void ShowOpenChestFallItem(long itemID, long targetItemID)
		{
		}

		private LotteryLootData GenerateLotteryLootData(long goods_id, GlobalEnum.ResType type, int goods_value, int num)
		{
			return null;
		}

		private void QuastFall(List<DrawResultData> loots)
		{
		}

		private void SetInfo(Transform tran, DrawResultData data)
		{
		}

		private void SetChest(Transform tran, int type, long id, int value, int num)
		{
		}

		public void ShowMailFallItem(List<DrawResultData> datas)
		{
		}

		private void LevelUp()
		{
		}

		public void CreateGo(long id, Transform tran, int num)
		{
		}

		private void CreateGo(long id, GlobalEnum.ResType type, Transform tran, int num)
		{
		}

		private void CreateGo(GlobalEnum.ResType type, Transform tran, int count)
		{
		}
	}
}
