using System.Collections.Generic;
using BestHTTP;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Data.Entity
{
	public class PlayerTimeWithVit
	{
		private const int TIME_0_DELAY_MIN = 1;

		private const int TIME_0_DELAY_MAX = 60;

		public int STAMINA_RESTORE_PERIOD;

		public int ACTIVITY_STAMINA_RESTORE_PERIOD;

		private string retryFuncKey;

		private static PlayerTimeWithVit instance;

		private bool inSync;

		private List<TypeCsvStory> StorysNeedTime;

		public bool inFreshShopData;

		private long remainSecond;

		private float StaminaRemainSeconds;

		private float APStaminaRemainSeconds;

		private NetMsgSeq CurrentSeq;

		private int RetryCount;

		private List<long> updateSetId;

		private List<long> outIds;

		private PlayerTimeWithVit()
		{
		}

		public static PlayerTimeWithVit GetInstance()
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void StartTime()
		{
		}

		private void RefreshFreeGoldGraw()
		{
		}

		public void CheckCanFreeDraw()
		{
		}

		private void CheckCanRefreshTime0()
		{
		}

		private void AfterGetRemailSecond()
		{
		}

		private void setRemailSecond(long value)
		{
		}

		private void RefreshEveryDayTimePoint0()
		{
		}

		private void FinishGetGamePlayInfo()
		{
		}

		private void RefreshCurrentRemainSeconds()
		{
		}

		public float CurrentStaminaRemainSeconds()
		{
			return 0f;
		}

		public float CurrentAPStaminaRemainSeconds()
		{
			return 0f;
		}

		public void SyncActionInit()
		{
		}

		private void CheckNeedTimeStory()
		{
		}

		private void UnlockStoryByTime()
		{
		}

		public void SyncAction()
		{
		}

		private void BeAborted()
		{
		}

		private void RetrySendSyncMsgWithAbort()
		{
		}

		private void SendSyncMsgWithAbort(List<NetMsgBase> msgList, NetMsgSeq.FinishSeqHandler allFinishHandler)
		{
		}

		private void TimeOutToAbort(HTTPRequestStates status)
		{
		}

		private void FailToAbort(string text)
		{
		}

		private void ErrorToAbort(string text)
		{
		}

		private void FinishSyncAction()
		{
		}

		private void CheckShopDataUpdate()
		{
		}
	}
}
