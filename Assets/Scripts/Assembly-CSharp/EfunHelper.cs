using System.Collections.Generic;
using System.Runtime.InteropServices;
using LitJson;

internal class EfunHelper
{
	public class EfunEventType
	{
		public const string ANNOUCE_WINDOW_CLOSE = "efun_annouce_window_close";

		public const string ADS_WINDOW_CLOSE = "efun_ads_window_close";

		public const string AUTH_WINDOW_CLOSE = "efun_auth_window_close";

		public const string LOGIN_RESULT = "efun_login";

		public const string PAY_RESULT = "efun_pay";

		public const string LOGOUT_RESULT = "efun_logout";

		public const string MESSAGE_QUERY = "efun_messageQuery";
	}

	public enum EfunUIEventType
	{
		AdsWallWindowClose = 0,
		AnnouceWindowClose = 1,
		AuthWindowClose = 2
	}

	public class EfunTrackEvent
	{
		public static string CreateRoleEvent;

		public static string UpgradeRoleEvent;

		public static string FinishGuideEvent;

		public static string PurchaseUser;
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LoginDelegate(bool isSucc, string id, string sign, string msg);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PayDelegate(bool isSucc);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LogoutDelegate();

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void MessageQueryResultDelegate(bool hasUnReadMessgae);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void EfunUIEvent(EfunUIEventType efunUIEvent);

	private static EfunHelper instance;

	public LoginDelegate EfunLoginResult;

	public PayDelegate EfunPayResult;

	public LogoutDelegate EfunLogoutResult;

	public MessageQueryResultDelegate msgQueryResult;

	public EfunUIEvent OnUIEvent;

	public static string currentUserId;

	public static string currentTimeStamp;

	public static string currentSign;

	public static EfunHelper GetInstance()
	{
		return null;
	}

	public void EfunLogin()
	{
	}

	public void EfunLogout()
	{
	}

	public void EfunShowAds()
	{
	}

	public void EfunShowAnnouce()
	{
	}

	public void EfunShowPermissionWindow()
	{
	}

	public void EfunShowUserCenter(string serverCode, string serverName, string roleId, string roleName, int roleLevel, int vipLevel)
	{
	}

	public void EfunShowCustomerService(string serverCode, string serverName, string roleId, string roleName, int roleLevel, int vipLevel)
	{
	}

	public void EfunOpenCafe(string roleID)
	{
	}

	public void EfunPay(string serverCode, string roldId, string roleName, string roleLevel, string info, string payId, string mPayStone, string mPayMoney)
	{
	}

	public void ShareFacebook(string imageFilePath)
	{
	}

	public void ShareKakao(string title, string text)
	{
	}

	public void GoURL(string url)
	{
	}

	public void EfunTrack(string serverCode, string serverName, string roleId, string roleName, int roleLevel, string trackEvent)
	{
	}

	public void EfunQueryMessageStatus()
	{
	}

	public void EfunRoleLogin(string serverCode, string serverName, string roleID, string roleLevel, string roleName, string vipLevel)
	{
	}

	public void EfunRoleLogout()
	{
	}

	public void EfunExit()
	{
	}

	private string ParamDict2String(Dictionary<string, string> param)
	{
		return null;
	}

	public void rec_android_data(JsonData data)
	{
	}

	private void ProcessMessageQuery(Dictionary<string, string> param)
	{
	}

	private void ProcessEfunPayResult(Dictionary<string, string> param)
	{
	}

	private void ProcessEfunLoginResult(Dictionary<string, string> param)
	{
	}

	public void OnDestroy()
	{
	}
}
