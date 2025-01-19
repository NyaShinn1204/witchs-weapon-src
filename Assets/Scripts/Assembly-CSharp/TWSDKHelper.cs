using System.Collections.Generic;
using System.Runtime.InteropServices;
using LitJson;

internal class TWSDKHelper
{
	public class LeitingEventType
	{
		public const string EVENT_LOGIN = "LT_LOGIN";

		public const string EVENT_PAY = "LT_PAY";

		public const string EVENT_LOGOUT = "LT_LOGOUT";

		public const string EVENT_SHOP_ITEM_RESULT = "LT_SHOP_ITEM_RESULT";

		public const string EVENT_GET_CHANNEL_NAME = "LT_GET_CHANNEL_NAME";
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LeitingLoginDelegate(bool succ, string userId, string userName, string token, string game, string channelNo);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LeitingPayDelegate(bool succ, string leitingOrderNum, string money, string msg);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LeitingLogoutDelegat(bool succ);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LeitingShopItemResult(JsonData result);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LeitingGetChannelNameDelegate(string name);

	public static TWSDKHelper instance;

	public LeitingLoginDelegate OnLeitingLogin;

	public LeitingPayDelegate OnLeitingPayResult;

	public LeitingLogoutDelegat OnLeitingLogoutResult;

	public LeitingShopItemResult OnLeitingQueryShopItemResult;

	public LeitingGetChannelNameDelegate OnLeitingGetChannelName;

	public static string LTMacAddress
	{
		get
		{
			return null;
		}
	}

	public static TWSDKHelper GetInstance()
	{
		return null;
	}

	public void GetLeitingChannelName()
	{
	}

	public void DoLogin()
	{
	}

	public void QueryShopItemInfo(string[] items)
	{
	}

	public void DoPay(string userId, string zoneId, string money, string currency, string orderId, string roleId, string roleName, string productId, string productName)
	{
	}

	public void DoLogout()
	{
	}

	public void DoQuit()
	{
	}

	public void ShowAccountCenter()
	{
	}

	public void TrackEventLogin(string zoneId, string roleId, string roleName, string roleLevel, string zoneName)
	{
	}

	public void TrackEventCreateRole(string zoneId, string roleId, string roleName, string roleLevel, string zoneName)
	{
	}

	public void TrackEventLevelUp(string zoneId, string roleId, string roleName, string roleLevel, string zoneName)
	{
	}

	private string GetStringFromParamDict(Dictionary<string, string> paramDict, char sepChar = ',')
	{
		return null;
	}

	private string GetJsonStringFromParamDict(Dictionary<string, string> paramDict)
	{
		return null;
	}

	internal void rec_leiting_data(JsonData data)
	{
	}

	public void OnDestroy()
	{
	}
}
