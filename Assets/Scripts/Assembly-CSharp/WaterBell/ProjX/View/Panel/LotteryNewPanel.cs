using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class LotteryNewPanel : UIPanelSingle
	{
		private const int BALL_POS_NUM = 3;

		public static bool IsDebug;

		public static LotteryNewPanel current;

		[NonSerialized]
		public static DrawInfo currentDrawInfo;

		private static int selectIndex;

		public Transform crystalBallButtonContainer;

		public Transform crystalBallPos;

		public LotteryResultPanel resultPanel;

		public float a;

		public float b;

		public GameObject cutSceneEffect;

		public Camera kismetCam;

		public Animator kismetAnim;

		public GameObject clipPlaneWidgets;

		public LoadUIPanelSingle drawProbLoader;

		public UIPanel lotteryFrontPanel;

		public UIContainerWithSlider kindButtons;

		public GameObject girl;

		public UITexture apBg;

		public UILabel currencyLabel;

		public GameObject mDiscount;

		public ButtonEx probButton;

		public ButtonEx ruleButton;

		public ButtonEx shopButton;

		public UILabel guaranteesTimeCountLabel;

		public UILabel guaranteesTimeLabel;

		public UILabel guaranteesFirstTimeLabel;

		public UILabel guaranteesRuleLabel;

		public UILabel drawPublicLabel;

		public GameObject guaranteesInfo;

		public GameObject guaranteesRule;

		public GameObject firstRestrict;

		public LotteryAdPanel lotteryAdPanel;

		public GameObject excite;

		public GameObject surprised;

		public GameObject smile;

		public GameObject talkex;

		public GameObject wing;

		private List<DrawInfo> drawInfos;

		private DrawSystemManagerView drawView;

		private ObservablePlayer playerInfo;

		private GameObject[] faces;

		private CrystalBallButton[] crystalBallButtonArray;

		private CrystalBallPos[] crystalBallPosArray;

		private LFP_KindButtonNew currentMiddleButton;

		private RenderTexture kismetRT;

		private int cacheLayerMask;

		private bool updateSelectIndex;

		[SerializeField]
		private bool m_IsDebug;

		public LotteryIconSelector lotteryIconSelector;

		public LotteryDrawButton lotteryDrawButton;

		public static void ResetOnRelod()
		{
		}

		public LFP_KindButtonNew GetCurrentMiddleButton()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void CenterButton()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public static List<DrawInfo> GetDrawInfo()
		{
			return null;
		}

		public void OpenRulePanel()
		{
		}

		public void OpenProbPanel()
		{
		}

		public void SelectBall(LFP_KindButtonNew selectButton)
		{
		}

		public bool SelectBall_forceDiamondDraw()
		{
			return false;
		}

		private void UpdateMiddleButtonState()
		{
		}

		public void TryDraw(LuckDrawButton button)
		{
		}

		public void TryDraw(DrawInfo drawInfo, DrawCountTypes drawCountType)
		{
		}

		private void DrawNow()
		{
		}

		private void UpdateButtons(int index)
		{
		}

		public void SetDiscountState(bool tag)
		{
		}

		public void SetCamInteractionState(bool state)
		{
		}

		private void OpenResultPanel()
		{
		}

		public static DateTime ToDateTime(long timeStamp)
		{
			return default(DateTime);
		}

		public static string TimeString(TimeSpan time)
		{
			return null;
		}

		public static void Reconfirm(DrawInfo drawInfo, Action drawCallback)
		{
		}
	}
}
