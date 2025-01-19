using NodeCanvas.GuideLessonTrees;
using UnityEngine;
using WaterBell.ProjX.Core.Manager.Audio;

namespace WaterBell.ProjX.Guide.Content
{
	public class Stage : MonoBehaviour
	{
		public enum FocusStyle
		{
			Default = 0,
			DragHand = 1,
			Invisible = 2,
			ClickFocus = 3,
			InvisibleMaskButShowClick = 4,
			None = 99
		}

		private struct viewCache
		{
			public float scrollView_initLocalPosY;

			public float scrollView_viewSizeH;

			public Transform trans;

			public float gridContainerOffsetY;

			public float firstItemInGrid_localPosY;
		}

		private static Stage _instance;

		private static int stageNum;

		public static readonly int ConversationRoleBaseDepth;

		public static readonly int DialogRoleBaseDepth;

		public static readonly int ConversationPicDepth;

		public static readonly int DialogPicDepth;

		public static readonly int BgIntroPicDepth;

		public static readonly int TeachingPicDepth;

		public ScreenMask screenMask;

		public StoryTransition storyTransition;

		public TeachingLayer teachingLayer;

		public FocusLayer focusLayer;

		public ConversationManager conversationMngr;

		public PhoneDialogLayer dialogLayer;

		public PicLayer picLayer;

		public PicTextLayer picTextLayer;

		public BgIntroManager bgIntroManager;

		public AsideIntroLayer asideIntroLayer;

		public Transform tempLayerTrans;

		public Camera mainCam;

		public Camera lotteryCam;

		public AudioPlay currSndEff;

		public AudioSource SpeechPlayback;

		public Coroutine autoFocusCoroutine;

		public GuideLessonTreeController lessonTreeCtrl;

		public string writerSoundID;

		public LogLayer logLayer;

		public DragPicMgr dragPicMgr;

		private FocusStyle currFocusStyle;

		private UIScrollView scrollViewCache;

		private viewCache scrollViewInfo;

		public static Stage GetInstance()
		{
			return null;
		}

		public static Stage GetExistedInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void Init()
		{
		}

		public Camera GetMainCam()
		{
			return null;
		}

		public Camera GetLotteryCam()
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void ClearTemp()
		{
		}

		public void FocusTrigger(GameObject trigger, string tipWord = "", FocusStyle style = FocusStyle.Default, int focusOffsetX = 0, int focusOffsetY = 0)
		{
		}

		public void LocateItemInScrollView(UIScrollView scrollView, Vector3 triggerOrigPos, UIGrid gridContainer)
		{
		}

		public void ItemInScrollView(UIScrollView scrollView, Vector3 triggerOrigPos, UIGrid gridContainer)
		{
		}

		public void TryCancelAutoFocus()
		{
		}

		public void ShowScreenMask(bool useTransparentColor = false)
		{
		}

		public void ShowExtraScreenMask()
		{
		}

		public void TryHideExtraScreenMask()
		{
		}

		public void PlaySpeech(long SpeechId)
		{
		}

		public void TryStopSpeech()
		{
		}

		public void RoundReset()
		{
		}

		public void ForceClear()
		{
		}

		public bool IsAnythingOnStageStillRunning()
		{
			return false;
		}

		public bool IsAnythingOnStageStillRunningAnim()
		{
			return false;
		}

		public bool IsAnywordOnStageStillUnfinished()
		{
			return false;
		}

		public void PlaySndEff(long effResID)
		{
		}

		public void LetInstantFinish()
		{
		}

		public void LetNextWordContinue()
		{
		}

		public bool IsTransitionStillRunning()
		{
			return false;
		}

		public void SetServant(long[] ServantIDs)
		{
		}

		public void MoveIntoMainUICamera()
		{
		}

		public void MoveIntoBattleUICamera()
		{
		}

		public void MoveIntoRoot()
		{
		}

		private void resetScale(bool isInMainUI)
		{
		}

		public FocusStyle GetCurrFocusStyle()
		{
			return default(FocusStyle);
		}

		public void onWriterPlaying()
		{
		}
	}
}
