using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MainScenePanel : UIPanelSingle
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void MoveCamera();

		[Space]
		public HeroInfoControl heroIconControl;

		public ButtonEx GuildBtn;

		public ButtonEx VipBtn;

		public ButtonEx GetAwardBtn;

		public ButtonEx BigActivityBtn;

		public ButtonEx GuideTaskBtn;

		public ButtonEx DrawBtn;

		public ButtonEx ServantBtn;

		public ButtonEx DroneBtn;

		public ButtonEx hero;

		public LiuLiAnimStateComponet liuLiAnim;

		public ButtonEx task;

		public ButtonEx run;

		public ButtonEx exploreBoxCollider;

		public ButtonEx MainStoryBtn;

		public ButtonEx Daily1Btn;

		public ButtonEx Daily2Btn;

		public ButtonEx Daily3Btn;

		public ButtonEx ExpeditionBtn;

		public ButtonEx special1ShopBtn;

		public ButtonEx special2ShopBtn;

		public ButtonEx HeroInfoBtn;

		public ButtonEx shopBtn;

		public ButtonEx finishTestGetAwardBtn;

		[HideInInspector]
		public ButtonEx bgBox;

		private GameObject City;

		public Transform LockClick;

		private HeroDevPanel HeroDevPanel;

		public GameObject[] guideHideableObjArr;

		public Transform taskBG;

		public UILabel VipText;

		[HideInInspector]
		public Transform tansuo;

		[HideInInspector]
		public Transform nvzhu;

		[HideInInspector]
		public Transform servantIcon;

		[HideInInspector]
		public Transform drawIcon;

		[HideInInspector]
		public Transform HeroPanelBG;

		[HideInInspector]
		public Transform guildIcon;

		[HideInInspector]
		public Transform activityPlayModeRemind;

		public Transform storyContainer;

		private UISprite activityImg;

		public Transform ButtonEXContainer;

		public Transform MailPoint;

		[HideInInspector]
		public GameObject daily1Text;

		[HideInInspector]
		public GameObject daily2Text;

		[HideInInspector]
		public GameObject daily3Text;

		[HideInInspector]
		public GameObject ExpeditionText;

		[HideInInspector]
		public GameObject daily1TextLock;

		[HideInInspector]
		public GameObject daily2TextLock;

		[HideInInspector]
		public GameObject daily3TextLock;

		[HideInInspector]
		public GameObject ExpeditionTextLock;

		public static MainScenePanel current;

		private float speed;

		[HideInInspector]
		public HeroSwitchSkin heroSkin;

		[HideInInspector]
		public MainCameraController control;

		public MoveCamera DelegateMove;

		private List<Texture> ActivityTextures;

		private List<long> ActivityIDs;

		private int currentIndex;

		private int nextIndex;

		private int ActivitySpriteCount;

		public Transform SdkRemind;

		public UserPlayerHeadIconView HeadIconView;

		private UIDataBase tempUIDataBase;

		public Transform inviateRemindIcon;

		public GameObject elementUI;

		public GameObject leftTop;

		public UITexture currentTV;

		public UITexture nextTV;

		public UIDragScrollView drag;

		public UIScrollView scroll;

		public UITable tvIndexTable;

		public ButtonEx dragBtn;

		private ButtonEx _shopBtn;

		private ButtonEx _packageBtn;

		public GameObject rightTop;

		private ButtonEx _vipBtn;

		private ButtonEx _library;

		public GameObject rightBottom;

		private UITable btnTable;

		private ButtonEx _servantBtn;

		private ButtonEx _battleBtn;

		private ButtonEx _storyBtn;

		private ButtonEx _taskBtn;

		private ButtonEx _activityBtn;

		[HideInInspector]
		public Transform taskIcon;

		[HideInInspector]
		public Transform svIcon;

		public GameObject leftBottom;

		private ButtonEx _talkingBtn;

		private ButtonEx _chatBtn;

		private ButtonEx _mailBtn;

		private GameObject _mailPoint;

		private int index;

		private TweenAlpha ta;

		private Transform heroPoint;

		private Transform headPoint;

		private ArrayList heroBtnPointInfo;

		private ArrayList headBtnPointInfo;

		private bool isFirstLoadHero;

		private bool IsOpenGuild
		{
			get
			{
				return false;
			}
		}

		private UIAtlas DefultAtlas
		{
			get
			{
				return null;
			}
		}

		private Texture DefultActivityTexture
		{
			get
			{
				return null;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		protected override void Awake()
		{
		}

		protected override void AddConfigItem()
		{
		}

		private void CloseUIofOpenUfo()
		{
		}

		private void OpenUIofCloseUfo()
		{
		}

		private void ActivityTimeLog()
		{
		}

		private void AddEvent()
		{
		}

		private void InitSceneComponent()
		{
		}

		private void InitGet3Dobj()
		{
		}

		private void OpenExplore()
		{
		}

		private void CloseExplore()
		{
		}

		private void OpenDrone()
		{
		}

		private void GoToClothing()
		{
		}

		private void GoToTask()
		{
		}

		private void GoToRun()
		{
		}

		private void GoToDaily3()
		{
		}

		private void GoToSelectLevel()
		{
		}

		private void GoToDaily1()
		{
		}

		private void GoToDaily2()
		{
		}

		private void GoToPackage()
		{
		}

		private void GoToMail()
		{
		}

		private void GoToLottery()
		{
		}

		private void GoToServantList()
		{
		}

		private void GoToExpedition()
		{
		}

		public void GoMail()
		{
		}

		private void GoShop()
		{
		}

		private void GoStory()
		{
		}

		private void GoActivity()
		{
		}

		private void GoServant()
		{
		}

		public void GoTalking()
		{
		}

		private void OpenChat()
		{
		}

		public void OpenHeroInfoPanel()
		{
		}

		private void GoGuideQuest()
		{
		}

		private void OpenSvBoardPanel()
		{
		}

		private void GoVipPanel()
		{
		}

		private void OpenGuild()
		{
		}

		private void GoLibraryy()
		{
		}

		private void OpenWelfare()
		{
		}

		private void OpenSatinRose()
		{
		}

		private void GetVit()
		{
		}

		private bool CanOpenDaily_1()
		{
			return false;
		}

		private bool CanOpenDaily_2()
		{
			return false;
		}

		private bool CanOpenDaily_3()
		{
			return false;
		}

		private bool CanOpenExpedition()
		{
			return false;
		}

		public void ReSetVip()
		{
		}

		public void ShowLogView()
		{
		}

		public void TryHideObjs4Guide()
		{
		}

		public void TryShowObjs4Guide()
		{
		}

		public void DoMoveWithCamera(Vector3 target, MoveCamera _move)
		{
		}

		private void SetRotation(Transform trans)
		{
		}

		private List<LotteryLootData> GetAwardData()
		{
			return null;
		}

		public void GetAward()
		{
		}

		public void SetMailBtn(bool _New)
		{
		}

		public bool IsShowBigActivityLabel()
		{
			return false;
		}

		public void TryMarkBigActivityLabelAsShowed()
		{
		}

		public void SetActivityRemind(bool _isShow)
		{
		}

		public void SetInviteRemindIcon(bool _show)
		{
		}

		public void IsShowLeadTask()
		{
		}

		private void ShowScemeUI(bool _show)
		{
		}

		public void SetHeroHeadInfo()
		{
		}

		private void SetSpecialShop()
		{
		}

		private void GetEfunResult()
		{
		}

		private void EfunMessageResult(bool hasUnReadMessage)
		{
		}

		public void SetActivityPlayState(bool _isOpen)
		{
		}

		public void OpenDrag()
		{
		}

		public void CloseDrag()
		{
		}

		private UIAtlas ActivityAtlas(string _spriteName)
		{
			return null;
		}

		private void InitTV()
		{
		}

		private void GoActivityTv(int _index)
		{
		}

		private void SwitchActivityIcon()
		{
		}

		private void InitTVIndex()
		{
		}

		private void ResetTVIndex(int _index)
		{
		}

		private Texture CurrentTx()
		{
			return null;
		}

		private Texture NextTx()
		{
			return null;
		}

		private void GoActivityTV()
		{
		}

		private void DragEvent()
		{
		}

		private void GetRescouceImg()
		{
		}

		private void CurrentTvAnim()
		{
		}

		private void ShowActivityImg()
		{
		}

		private void SaveBtnPointInfo()
		{
		}

		private void SetSyncPoint()
		{
		}

		private void SetHeroLeadBtn(HeroSwitchSkin obj)
		{
		}

		private void GoHeroPanel()
		{
		}

		private void RotateAni()
		{
		}

		private void MoveAni()
		{
		}

		private void OpenHeroPanel()
		{
		}

		public void ComeBackMain()
		{
		}

		private void HeroPanelInit()
		{
		}
	}
}
