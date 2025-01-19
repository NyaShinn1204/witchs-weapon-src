using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Achievemod;
using Actionmod;
using Google.Protobuf.Collections;
using LitJson;
using Lootmod;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ProtocolManager
	{
		private enum LoginMode
		{
			none = 0,
			existedEmailUserRegAndLogin = 1,
			existedPhoneUserRegAndLogin = 2,
			emailOrPhoneLoginByNameAndPassword = 3,
			phoneLoginBySMS = 4
		}

		private static ProtocolManager instance;

		public bool IsExpeditionOpen;

		private Dictionary<long, NetMsgBase> MsgPool;

		private Queue<GooglePlayPurchase> FailGooglePlayPurchase;

		public Coroutine loginCoroutine;

		public float netMsgStartTime;

		public bool isNeedReFresh;

		private Dictionary<long, int> addSvExpItemDic;

		private string addSvExpItemvSvId;

		public static ProtocolManager GetInstance()
		{
			return null;
		}

		private void init()
		{
		}

		public void DisposeAll()
		{
		}

		private void AfterGetLeitingChannelName(string chName)
		{
		}

		private void OnQueryLeitingShopItemInfo(JsonData result)
		{
		}

		private void OnInvQueryResult(GooglePlayPurchase[] purchases)
		{
		}

		private void TyDOJpGooglePay()
		{
		}

		private void DealJpGooglePayResult(int Result, string goodid, string TransactionID, RepeatedField<LootObject> lootObjects)
		{
		}

		public void StartRoleLogin()
		{
		}

		[DebuggerHidden]
		public IEnumerator Login()
		{
			return null;
		}

		private void GetAchiveByProtobuf(List<AchievementJob> achieveJob, List<AchievementMeta> achieveMeta, Result allAchieveContent)
		{
		}

		public void InitAchieve(Result allAchieveContent)
		{
		}

		public void FreshAchieve(Result allAchieveContent)
		{
		}

		private void FinishGetAllShopSet()
		{
		}

		public bool ProcessDataForLua(byte[] data)
		{
			return false;
		}

		public void SendNormalMessageSeq(List<NetMsgBase> msgList, NetMsgSeq.FinishSeqHandler allFinishHandler = null)
		{
		}

		public void SendNormalMessageWithoutDelegation(NetMsgBase msg)
		{
		}

		public void SendNormalMassage(NetMsgBase msg)
		{
		}

		public bool IsMsgConsumed(long msgID)
		{
			return false;
		}

		public void ShowMsgInPool()
		{
		}

		public int getNormalMsgCount()
		{
			return 0;
		}

		public bool CheckNormalMsg()
		{
			return false;
		}

		public bool IsAngNormalMsgNotHandled()
		{
			return false;
		}

		public void RemoveNormalMsgFromPool(long msgID)
		{
		}

		public void AddMsgIntoPool(long msgID, NetMsgBase msg)
		{
		}

		public void ResendMsgInPool()
		{
		}

		public void UploadUserDevice()
		{
		}

		public void BatchSendSvExpItemMsg()
		{
		}

		public void ParseCommonInfo(byte[] data)
		{
		}

		public void ParseActivityGameInstance(byte[] data)
		{
		}

		public void ParseExtraInfo(ExtraInfo extra)
		{
		}
	}
}
