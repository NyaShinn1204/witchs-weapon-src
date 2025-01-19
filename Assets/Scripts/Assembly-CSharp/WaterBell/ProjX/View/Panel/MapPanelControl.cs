using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class MapPanelControl : UIPanelSingle
	{
		private const int SCREEN_ADAPTIVE_CAMERA_OFFSET_Z_FROM = 0;

		private const int SCREEN_ADAPTIVE_CAMERA_OFFSET_Z_TO = -835;

		private const string NORMAL_LEVEL_ICON = "UI/Prefab/BattleMap/NormalLevelIcon";

		private const string HARD_LEVEL_ICON = "UI/Prefab/BattleMap/HardLevelIcon";

		private const string PORTAL_BUTTON = "UI/Prefab/BattleMap/PortalButton";

		public static MapPanelControl current;

		public static long lastBattleLevelID;

		private static Dictionary<long, Vector3[]> chapterCamInfoDict;

		public float camInitY;

		public float camInitDuration;

		public long currentChapterID;

		public long currentNormalNewUnlockID;

		public long currentLastNormalID;

		public long currentHardID;

		public long selectLevelID;

		public int chapterIndex;

		public bool isNormal;

		private List<long> chapterIdList;

		private long cacheChapterID;

		public GameObject pathLightings;

		public Material pathLightMat_Lock;

		public Material pathLightMat_Unlock;

		public Transform camContainer;

		public Camera mapCamera;

		public Camera lightCamera;

		public Material normalTypeMat;

		public Material hardTypeMat;

		public MeshRenderer[] buildings;

		public GameObject newUnlockTip;

		public GameObject getEquipTip;

		public UITexture lightTex;

		private Sequence camContainerSeq;

		private bool isShowGetEquipTip;

		private Dictionary<long, MeshRenderer> pathLightingDict;

		private Dictionary<long, BMLevelPos> levelPosDict;

		private BrownianMotion mapCameraBM;

		public Camera uiCamera;

		public GameObject butonDiffContainer;

		public GameObject normalButton;

		public GameObject hardButton;

		private bool isShowItem;

		public UILabel chapterNameLabel;

		public UILabel chapterNameLabel_EN;

		public UILabel en_chapterNameLabel;

		public UILabel chapterIndexLabel;

		public GameObject prevChapterButton;

		public GameObject nextChapterButton;

		public UIGrid chapterNameGrid;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public ButtonEx switchModeButton;

		public GameObject normalLevelIcons;

		public GameObject hardLevelIcons;

		private Dictionary<long, List<BMLevelIcon>> levelIconChapterDict;

		private Dictionary<long, BMLevelIcon> levelIconDict;

		public LoadUIPanelSingle helpLoader;

		public ButtonEx helpButton;

		public ButtonEx showItemButton;

		public GameObject portalModelConainer;

		public GameObject portalButtons;

		private Dictionary<long, PortalButton> portalButtonDict;

		public LoadUIPanelSingle storyMiniLoader;

		private MainProgressManagerView mainProgressManagerView;

		private List<ProgressChapterViewModel> chapterInfoList;

		private Dictionary<long, long> unlockPortalDict;

		private List<long> portalLevelList;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private void Update()
		{
		}

		private new void OnDisable()
		{
		}

		private void ShowItem(bool isActive)
		{
		}

		public void GotoChapter(long chapterID)
		{
		}

		private void ShowLevelIcon(long chapterID)
		{
		}

		private void HideLevelIcon(long chapterID)
		{
		}

		public void GotoNextChapter()
		{
		}

		public void GotoPrevChapter()
		{
		}

		public void SwitchDifficulty()
		{
		}

		private void SetDifficulty(bool value)
		{
		}

		private void ShowHardLevel()
		{
		}

		private void ShowNormalLevel()
		{
		}

		public void OpenLevelDetail(long instanceId)
		{
		}

		private void GotoStory(long levelID)
		{
		}

		public void OpenPanel(long levelId)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void PlayImportantAnim()
		{
		}

		public void SyncData()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
