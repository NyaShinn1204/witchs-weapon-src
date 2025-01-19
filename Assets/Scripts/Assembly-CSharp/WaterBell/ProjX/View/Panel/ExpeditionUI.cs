using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

namespace WaterBell.ProjX.View.Panel
{
	public class ExpeditionUI : UIPanelSingle
	{
		public static ExpeditionUI current;

		private const float distance = 80f;

		private static int CHESTS_INTERVAL;

		public Camera uiCamera;

		public Camera mapCamera;

		public FreeLookCam freeLookCam;

		public ExpGeneralLevelIcon levelIconClone;

		public UIWidget levelIconContainer;

		public UIPanelSingle chestsPanel;

		public UILabel resetNumLabel;

		public ExpChestsIcon chestsIconClone;

		public UIWidget chestsIconContainer;

		public int chapterIndex;

		public int levelIndex;

		public LoadUIPanelSingle confirmPanelLoader;

		public LoadUIPanelSingle helpLoader;

		public LoadUIPanelSingle lootPanelLoader;

		public LoadUIPanelSingle billboardLoader;

		public UISprite progressBar;

		public UILabel progressLabel;

		public GameObject clearAllIcon;

		public UILabel cscCurrency;

		public UILabel scoreLabel;

		public GameObject rewards;

		public UIPanelSingleContainer rewardsContainer;

		public UIPanelSingleContainer rewardsIcon;

		public ButtonEx openChestsButton;

		public ButtonEx resetButton;

		public ButtonEx helpButton;

		public ButtonEx gotoStoreButton;

		public ButtonEx billboardButton;

		public Material warZoneMat;

		public Material peaceZoneMat;

		public Transform city;

		public int progressIndex;

		public int totalLevels;

		private List<ExpGeneralLevelIcon> levelIconList;

		private List<ExpChestsPoint> chestsPointList;

		private List<Transform> chapterPointList;

		private Dictionary<string, MeshRenderer> lineDict;

		private Dictionary<string, List<MeshRenderer>> warZoneDict;

		private Dictionary<string, List<MeshRenderer>> edgeZoneDict;

		private ExpeditionManagerView expeditionManagerView;

		private List<ExpeditionProgressInfo> levelInfoList;

		private List<ExpeditionProgressInfo> chestsInfoList;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OpenBillboardPanel()
		{
		}

		private void GoShop()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Init()
		{
		}

		private void OpenRestConfirmPanel()
		{
		}

		private void OnButtonYesClickEvent()
		{
		}

		public void OnResetSuccessful()
		{
		}

		public void OpenLevelDetail(long levelID)
		{
		}

		private void ShowChests()
		{
		}

		private void OpenChestsPanel()
		{
		}

		public void OnChestsSuccessful()
		{
		}

		private void ShowLootPanel()
		{
		}

		public void CloseChestsPanel(LootPanel lootPanel)
		{
		}

		private void MoveTo(bool isPlayAnim = true, float delay = 0.8f)
		{
		}

		private void MoveTo(Transform target, bool isPlayAnim = true, float delay = 0.8f)
		{
		}

		public void UpdateCscCurrency(int value)
		{
		}

		public void ChangeChapter()
		{
		}

		private void ShowArea(int chapterIndex)
		{
		}
	}
}
