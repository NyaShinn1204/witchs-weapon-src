using System;
using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ProtocolConstant
	{
		public static bool IsDebugRIDLogin;

		public static string DebugRID;

		public static string DebugUID;

		public static string DebugZID;

		public static string NEW_PROTOCOL_TAG;

		public static bool isShowLog;

		public static bool isShowRMB;

		public static bool CanPay;

		public static bool IsSkinConfirmDiamond;

		public static bool IsSkinConfimrGold;

		public static bool IsSkinConfimrDraw;

		public static string CREATE_ROLE_TYPE_FOR_DEFAULTT;

		public static string CREATE_ROLE_TYPE_FOR_BETA;

		public static string CREATE_ROLE_TYPE;

		public static string APPVersion;

		public static string DEFAUL_FLAG;

		public static string DEFAUL_SRC;

		public static string GAME_NOTICE_SIGN;

		public static bool NeedRefreshShop;

		public const int SERVER_STATE_OEPN_NEW = 10;

		public const int SERVER_STATE_OEPN_NORMAL = 11;

		public const int SERVER_STATE_MAINTAIN = 12;

		public const int SERVER_STATE_OFFLINE = 13;

		public const int SERVER_STATE_FLOODED = 80;

		public const int SERVER_STATE_FULL = 99;

		public const int SERVER_STATE_NORMAL = 1;

		public const int SERVER_STATE_SELECT = 2;

		public static int CurrentSelectLanguage;

		public static string URL_BASE;

		public static string URL_COMMON;

		public static string URL_BASE_NEW_PROTOCOL;

		private static string _Timestamp;

		public static DateTime LoginServerTime;

		public static float TimeFromStartWhenGetLoginServerTime;

		public static string Token;

		public static string LoginToken;

		public static string LoginPhone;

		public static string LoginMail;

		public static string LoginThirdParty;

		public static bool IsRealNameUser;

		public static string PassFromLoginBySms;

		public static string dmm_data;

		public static string dmm_signature;

		public static bool EnableRedeem;

		public static bool IsCreateRoleSkipGuid;

		public static bool IsInGame;

		public static string UID;

		public static string RoleID;

		public static string ZoneID;

		public static string Account;

		public static string cid;

		public static string UserType;

		public static int RegistUserType;

		public static string NickName;

		public static string Pass;

		public static string Signature;

		public static string Pubkey;

		public static string WordChannelID;

		public static string SysChannelID;

		public static string NotifyChannelID;

		public static string CallbackIp;

		public static bool NeedTrackCreateRole;

		public static bool finishGetRoleLastLevel;

		public static bool NotFinishBattleReturnMainUI;

		public static bool NeedGetCsc;

		public static int NeedGetApInfo;

		public static bool NeedGetShopSet;

		public static List<long> NeedGetShopSetIds;

		public static bool isTryingInitItem;

		public static int DebugItemNum;

		public static bool NeedRefreshProgress;

		public static int USER_TYPE_PHONE;

		public static int USER_TYPE_EMAIL;

		public static string REQUEST_SMS_CODE_REGIST;

		public static string REQUEST_SMS_CODE_LOGIN;

		public static bool IsFinishOP;

		public static string NoticeID;

		public static string NoticeTitle;

		public static string NoticeText;

		public static string NoticeAuthor;

		public static string NoticeCreateDate;

		public static string TW_Cache_twgame;

		public static string TW_Cache_twchannel;

		public static string TW_Cache_twsign;

		public static string TW_Cache_twuserID;

		public static string TW_Cache_twname;

		public static int MsgCount;

		public static bool IsShowNotifyJpUserWindow;

		public static bool IsDebugMsgErrorCode;

		public static long TestMsgID;

		public static string DebugErrorCode;

		public static string Timestamp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string CurrentPlatForm
		{
			get
			{
				return null;
			}
		}

		public static int DefaultPayType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int IsJpUserReadProto
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SaveTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SaveCvID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int OldID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int HaveShowAuthNoticeState
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastNewID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool IsConn2BattleBranch()
		{
			return false;
		}

		public static string GetMD5(string password)
		{
			return null;
		}

		public static void ChangeURL(string type)
		{
		}

		public static void SetGameURLBaseByZone(SvrZone currUserZone)
		{
		}

		public static void SetURLBase(bool isConnRemote)
		{
		}

		public static void GenerateLog()
		{
		}

		public static void BindZRPair(string zid, string rid)
		{
		}

		public static int GetBundleID()
		{
			return 0;
		}

		public static List<TypeCsvOP> GetRealList()
		{
			return null;
		}

		private static int NewOpID()
		{
			return 0;
		}

		public static bool IsUseNewVersionRoleLoginProto()
		{
			return false;
		}
	}
}
