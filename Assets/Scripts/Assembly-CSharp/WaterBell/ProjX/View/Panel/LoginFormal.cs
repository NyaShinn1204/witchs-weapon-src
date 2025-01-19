using System;
using BestHTTP;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class LoginFormal : MonoBehaviour, YijieHelper.YijieLoginCallback
	{
		private static LoginFormal _instance;

		public GameClauseView gameClauseView;

		public JPSelectLoginView jPSelectLoginView;

		public LineUpView lineUpView;

		public GameNoticeView gameNoticeView;

		public ZoneNoticeView zoneNoticeView;

		public RoleLoginView roleLoginView;

		public SelectAccView selectAccView;

		public ZoneNoticeListView zoneNoticeListView;

		public EntryOptionView entryOptionView;

		public PassSafetyProblemView passSafetyProblemView;

		public ResetCodeView resetCodeView;

		public ResetCodePhonePassView resetCodePhonePassView;

		public ResetCodeSuccessView resetCodeSuccessView;

		public AccLoginErrorView accLoginErrorView;

		public AccRegisterInviteCodeView accRegisterInviteCodeView;

		public AccRegisterByPhoneView accRegisterByPhoneView;

		public AccRegisterByEmailView accRegisterByEmailView;

		public AccLoginByPWView accLoginByPWView;

		public AccLoginBySMSView accLoginBySmsView;

		public SelectServerView selectServerView;

		public SelectLanguageView selectLanguageView;

		public ForgetCodeView forgetCodeView;

		public ContactUSView contactUSView;

		public GameObject ResetConfirmPanel;

		public LoadUIPanelSingle confirmPanelLoader;

		[Space]
		public CommonTipsBox tipsBox;

		public UILabel appVersion;

		public GameObject ContactUsPanel;

		public ButtonEx ContactUsButton;

		public ButtonEx OrderButton;

		public ButtonEx efunButton;

		public ButtonEx LeiTingChangeAccountButton;

		public GameObject connRemoteCheckBox;

		public GameObject CreateRoleSkipGuildCheckBox;

		public UIButton btnBlockWhenOP;

		private int currentSafetyProblemAccType;

		public const int currentSafetyProblemAccTypeMail = 1;

		public const int currentSafetyProblemAccTypePhonePass = 2;

		public const int currentSafetyProblemAccTypePhoneCode = 3;

		public UITexture BGUITexture;

		public GameObject GRB_Logo_Kr;

		public GameObject Witchweapon_Logo_Kr;

		public ButtonEx clearSandboxButton;

		public ButtonEx NewVersionButton;

		public UITable uiTabel;

		public ButtonEx LanguageButton;

		private LoginSubView loginSubViewBeforeSafetyProblem;

		private LoginSubView currView;

		private LoginSubView preView;

		private bool isShowAccountCenterCD;

		public readonly int SMSRegistRegainCDMax;

		public int SMSRegistRegainCD;

		public bool isSMSRegistRegainInCD;

		public readonly int MailRegainCDMax;

		public int MailRegainCD;

		public bool isMailRegainInCD;

		public readonly int SMSLoginRegainCDMax;

		public int SMSLoginRegainCD;

		public bool isSMSLoginRegainInCD;

		public string inviteCodeStr;

		public int CurrentSafetyProblemAccType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LoginSubView LoginSubViewBeforeSafetyProblem
		{
			get
			{
				return default(LoginSubView);
			}
			set
			{
			}
		}

		public LoginSubView PreView
		{
			get
			{
				return default(LoginSubView);
			}
			set
			{
			}
		}

		public static LoginFormal GetInstance()
		{
			return null;
		}

		private void GoToOrder()
		{
		}

		private void gotoOrderYesHD()
		{
		}

		private void GoToContanctUsH5()
		{
		}

		private void alertQQYesHD()
		{
		}

		private void efunButtonclick()
		{
		}

		private void CancelShowAccountCenterCD()
		{
		}

		private void LanguageButtonclick()
		{
		}

		private void ConfirmChangeLanguage()
		{
		}

		private void NewVersionButtonclick()
		{
		}

		private void LeiTingChangeAccountButtonclick()
		{
		}

		private void Awake()
		{
		}

		private void ClickClearSandboxButton()
		{
		}

		private void ClearSandbox()
		{
		}

		private void OnDmmLoginComplete(string id, string sign)
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

		private void OnAppleLoginBackComplete(string username, string ios_token)
		{
		}

		private void EfunUIEvent(EfunHelper.EfunUIEventType efunUIEvent)
		{
		}

		public void CloseBlockWhenOP()
		{
		}

		private void AfInt()
		{
		}

		private void AfterEfunShowAnnouce()
		{
		}

		private void AfterEfunShowPermissionWindow()
		{
		}

		private string GetExternalVersionInfo()
		{
			return null;
		}

		private void Start()
		{
		}

		public void ShowGameClause()
		{
		}

		public void EnterMainFlow()
		{
		}

		private void ChechAccServerState()
		{
		}

		private void ChechAccServerStateFail(string errorcode)
		{
		}

		private void ChechAccServerStateError(string code)
		{
		}

		private void ChechAccServerTimeout(HTTPRequestStates status)
		{
		}

		private void AfterCheckServerState()
		{
		}

		private void EfunLoginResult(bool isSucc, string id, string sign, string msg)
		{
		}

		private void LeitingLoginResult(bool succ, string userId, string userName, string token, string game, string channelNo)
		{
		}

		private void EfunRegistAndLoginThirdPart(string id, string sign)
		{
		}

		public void OnLoginMessage(bool loginSucc, string channelUserID, string token, string channelID, string username)
		{
		}

		private void LoginProgress()
		{
		}

		private void DefaultUserLoginError(string code)
		{
		}

		private void DefaultUserLoginTimeout(HTTPRequestStates status)
		{
		}

		private void FailCheckAccountStatus(string errorcode)
		{
		}

		private void DefaultUserLoginSucc()
		{
		}

		private void DefaultUserLoginFail(string text)
		{
		}

		public void TryShowGameZoneNotice()
		{
		}

		private void GetNoticeSuccessful()
		{
		}

		private void GetNoticeFail(string text)
		{
		}

		private void GetNoticeError(string error)
		{
		}

		private void GetNoticeTimeOutDelegate(HTTPRequestStates status)
		{
		}

		public void SwitchSubView(LoginSubView fromView, LoginSubView toView)
		{
		}

		public void BackToPreView()
		{
		}

		public void QQRegist(string token, string nickname)
		{
		}

		public void TwRegist(string userId, string name, string sign, string game, string channel)
		{
		}

		public void JpRegist(string token, string name, UserLoginType userLoginType, string dmm_signature = "")
		{
		}

		private void finishJPRegist()
		{
		}

		private void successfulQQRegist()
		{
		}

		public void WeixinRegist(string token, string nickname)
		{
		}

		public void YijieRegist(string token, string nickname)
		{
		}

		public void AppleRegist(string username, string ios_token)
		{
		}

		private void successfulWeixinRegist()
		{
		}

		private IRegAndLoginView AssignSubView(LoginSubView view)
		{
			return null;
		}

		public void ShowConfrim(string title, string desc, Action yesCallback)
		{
		}

		public void ShowTipsBox(string _text)
		{
		}

		public void SMSStartRegistCD()
		{
		}

		public void SMSStartLoginCD()
		{
		}

		public void StartMailCD()
		{
		}

		private void RefreshDuringSMSRegistCD()
		{
		}

		private void RefreshDuringSMSLoginCD()
		{
		}

		private void OnDestroy()
		{
		}

		private void RefreshDuringMailCD()
		{
		}

		public void OnConnRemoteSelectionChanged()
		{
		}

		public void OnSkipGuideSelectionChanged()
		{
		}

		public void OnCreateRoleSkipGuideSelectionChanged()
		{
		}

		public void ShowResetConfirm()
		{
		}

		public void HideResetConfirm()
		{
		}

		public void loginSuccessful()
		{
		}

		public void loginFailed(string text)
		{
		}

		public void LoginTimeout(HTTPRequestStates status)
		{
		}

		public void LoginError(string code)
		{
		}
	}
}
