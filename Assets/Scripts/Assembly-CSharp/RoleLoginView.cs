using BestHTTP;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class RoleLoginView : RegAndLoginSubView
{
	public ButtonEx enterGameBtn;

	public ButtonEx switchZoneBtn;

	public ButtonEx zoneNoticeBtn;

	public UILabel switchZoneLabel;

	public ButtonEx switchAccBtn;

	public ButtonEx JpBackBtn;

	public UILabel switchAccLabel;

	public GameObject SwitchText;

	public GameObject JpAccountBtn;

	public UILabel JpAccountLabel;

	private UserAccCache currUserAccCache;

	private SvrZone currUserZone;

	private string ridText;

	private string uidText;

	private string zidText;

	private bool isEnterGameCD;

	private int retryCount;

	protected override void Awake()
	{
	}

	private void OnGUI()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickJpBackBtn()
	{
	}

	private void WarningBeforeGoback()
	{
	}

	private void DirectJPBack()
	{
	}

	private void CheckBeforeEnterGame()
	{
	}

	private void CheckNotifyNewUser()
	{
	}

	private void ShowZone()
	{
	}

	private void TryBindRID()
	{
	}

	private void ShowAcc()
	{
	}

	private void OnClickSwitchZoneBtn()
	{
	}

	private void OnClickSwitchAccBtn()
	{
	}

	private void OnClickZoneNoticeBtn()
	{
	}

	private void GetNoticeSuccessful()
	{
	}

	private void GetNoticeFail(string text)
	{
	}

	private void GetNoticeTimeOutDelegate(HTTPRequestStates status)
	{
	}

	private void CancelEnterGameCD()
	{
	}

	private void OnClickEnterGameBtn()
	{
	}

	private void AfterLeBianCheck()
	{
	}

	private void CheckVersion()
	{
	}

	private void CheckVersionTimeOut()
	{
	}

	private void FinishCheckVersion(int status)
	{
	}

	private void MsgGetVersionYesHD()
	{
	}

	private void FailCheckVersion()
	{
	}

	private void CheckServerBeforeNormalLogin()
	{
	}

	private void ChechServerFail(string error)
	{
	}

	private void ChechServerTimeOut(HTTPRequestStates status)
	{
	}

	private void AfrerCheckServerState()
	{
	}

	private void CheckServerBeforeCreate()
	{
	}

	private void BeginRoleCreate()
	{
	}

	private void OnRoleCreateSucc()
	{
	}

	private void OnRoleCreateError(string text)
	{
	}

	private void OnRoleCreateFail(string text)
	{
	}

	private void StartRoleLogin()
	{
	}

	private void OnRoleLoginSucc()
	{
	}

	private void OnRoleLoginFail(string error)
	{
	}
}
