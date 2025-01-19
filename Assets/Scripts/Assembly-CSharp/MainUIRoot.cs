using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class MainUIRoot : MonoBehaviour
{
	public GameObject BlockInAnimation;

	public bool isFromLevelToHerolist;

	public GameObject chapterLevelUpPanel;

	public GameObject _3Dobj;

	public GameObject city;

	public MainCameraController control;

	public Transform fxq;

	public Transform HeroContainer;

	public GameObject storyText;

	public GameObject daily1Text;

	public GameObject daily2Text;

	public GameObject daily3Text;

	public GameObject ExpeditionText;

	public GameObject daily1TextLock;

	public GameObject daily2TextLock;

	public GameObject daily3TextLock;

	public GameObject ExpeditionTextLock;

	public HeroSwitchSkin heroSkin;

	public Transform leadTask;

	public Transform hero;

	public Transform task;

	public Transform servant;

	public Transform guild;

	public Transform draw;

	public Transform servantIcon;

	public Transform taskIcon;

	public Transform drawIcon;

	public Transform guildIcon;

	public ButtonEx bgBox;

	public Transform HeroPanelBg;

	public Transform shop1;

	public Transform shop2;

	public Transform ui;

	public GameObject shop1Obj;

	public GameObject shop2Obj;

	public Transform bigAcitivty;

	public Transform ActivityPlayModeRemind;

	public Transform shopObj;

	private bool _Sharelock;

	private bool isInitEveryDayRefresh;

	private float countClock;

	private string nameBeforeBind;

	[SerializeField]
	private long TestGoodid;

	private void Awake()
	{
	}

	private void TestSendFakeMail()
	{
	}

	private void EfunQuit()
	{
	}

	private void LeitingLogin(bool succ, string userId, string userName, string token, string game, string channelNo)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	public static void showLevelUp(int BeforeLv, int AfterLv, int StaminaBefore, int StaminaAfter)
	{
	}

	private void Start()
	{
	}

	private void InitEveryDayRefresh()
	{
	}

	private void CheckUnShipOrder()
	{
	}

	private void CheckNewRole()
	{
	}

	public void RefreshTempStore()
	{
	}

	private void CheckToRefreshCap()
	{
	}

	public void CheckToReceiveMail()
	{
	}

	private void CheckToRefreshLevelCountStatus()
	{
	}

	public void RefreshCap()
	{
	}

	public void RefreshLevelCountStatus()
	{
	}

	public void CheckUploadDeviceInfo()
	{
	}

	public void HideAllButHeroList()
	{
	}

	public void HideSelectLvAndLvDetail()
	{
	}

	public void TestSuccess()
	{
	}

	public void TestFail()
	{
	}

	public void ShowLogView()
	{
	}

	public void RefreshUseSvItemCountClock()
	{
	}

	public void AddUseSvItemCountClock()
	{
	}

	public void AddBlockInAnimation(float delay = -1f)
	{
	}

	public void CloseBlockInAnimation()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnJpFacebookLoginComplete(bool isSucc, string id, string name, string msg)
	{
	}

	private void OnJpGoogleLoginComplete(bool isSucc, string id, string name, string msg)
	{
	}

	private void OnTwitterLoginComplete(bool isSucc, string id, string name, string msg)
	{
	}

	private void OnIOSGameCenterLoginComplete(bool isSucc, string id, string name, string msg)
	{
	}

	public void JpBindAccount(string token, string name, UserLoginType userLoginType)
	{
	}

	private void finishJpBindAccount(string account, string userLoginType)
	{
	}

	[DebuggerHidden]
	private IEnumerator TryShareKrImage(string url, Action action)
	{
		return null;
	}

	public bool ShareImageForFaceBook()
	{
		return false;
	}

	public bool ShareImageForShareKakao()
	{
		return false;
	}

	public bool ShareImageForTwitter()
	{
		return false;
	}

	private void DoGoBackAction()
	{
	}

	private void DoGoBackMain()
	{
	}

	private void DoTestShipGood()
	{
	}

	private void ReceiveTWBetaReward()
	{
	}
}
