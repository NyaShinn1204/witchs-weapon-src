using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class YijieHelper : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DealPayResultDelegate(long error);

	public enum SetInfoType
	{
		createrole = 0,
		levelup = 1,
		enterServer = 2,
		loginGameRole = 3
	}

	public interface YijieLoginCallback
	{
		void OnLoginMessage(bool loginSucc, string channelUserID, string token, string channelID, string username);
	}

	private bool bLogined;

	private bool isDebug;

	private SFOnlineUser user;

	public string message;

	public const string GAMEOBJ_NAME = "YIJIE_OBJ";

	public DealPayResultDelegate DealPayResult;

	public YijieLoginCallback callback;

	private YijieHelper()
	{
	}

	[PreserveSig]
	public static extern void exit(IntPtr context, string gameObject, string listener);

	[PreserveSig]
	public static extern void onCreate_listener(IntPtr context, string gameObject, string listener);

	[PreserveSig]
	public static extern void login(IntPtr context, string customParams);

	[PreserveSig]
	public static extern void logout(IntPtr context, string customParams);

	[PreserveSig]
	public static extern void charge(IntPtr context, string gameObject, string itemName, int unitPrice, int count, string callBackInfo, string callBackUrl, string payResultListener);

	[PreserveSig]
	public static extern void pay(IntPtr context, string gameObject, int unitPrice, string unitName, int count, string callBackInfo, string callBackUrl, string payResultListener);

	[PreserveSig]
	public static extern void payExtend(IntPtr context, string gameObject, int unitPrice, string unitName, string itemCode, string remain, int count, string callBackInfo, string callBackUrl, string payResultListener);

	[PreserveSig]
	public static extern void setRoleData(IntPtr context, string roleId, string roleName, string roleLevel, string zoneId, string zoneName);

	[PreserveSig]
	public static extern void setData(IntPtr context, string key, string value);

	[PreserveSig]
	public static extern void setLoginListener(IntPtr context, string gameObject, string listener);

	[PreserveSig]
	public static extern void extend(IntPtr context, string data, string gameObject, string listener);

	[PreserveSig]
	public static extern bool isMusicEnabled(IntPtr context);

	public static YijieHelper GetInstance()
	{
		return null;
	}

	private void Init()
	{
	}

	private void Yijie_LoginResult(string result)
	{
	}

	private void Yijie_VerifyLogin()
	{
	}

	private void Yijie_ExitResult(string result)
	{
	}

	private void Yijie_PayResult(string result)
	{
	}

	public void DoSetRoleInfo(string roleID, string roleName, string level, string zoneID, string zoneName)
	{
	}

	public void DoSetInfo(SetInfoType type)
	{
	}

	public void DoLogin(YijieLoginCallback cb)
	{
	}

	public void DoLogout()
	{
	}

	public void DoExit()
	{
	}

	public void DoPay(string title, int RMBinCent, string customInfo, string myserver_callbackURL)
	{
	}

	public bool IsLogined()
	{
		return false;
	}

	public SFOnlineUser GetUser()
	{
		return null;
	}
}
