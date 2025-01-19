using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class NetMsgSeq
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void FinishStepHandler();

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void FinishSeqHandler();

		private NetworkAlertUI.ExceptionMode bindMode;

		public NetMsgBase.FailedDelegate OnDefaultFailedDelegate;

		public NetMsgBase.ErrorDelegate OnDefaultErrorDelegate;

		public NetMsgBase.TimeOutDelegate OnDefaultTimeOutDelegate;

		private Queue<Queue<NetMsgBase>> seq;

		private Queue<FinishStepHandler> stepHanderQueue;

		private Queue<NetMsgBase> currStepQuene;

		private int currStepQueueMsgCounter;

		private int origStepNum;

		private bool isAllMsgRecived;

		private bool isAborted;

		private bool isMust2Finish;

		private ProtocolManager mngr;

		public FinishSeqHandler OnFinishSeq;

		public NetMsgBase.FailedDelegate OnAnyMsgFailed;

		public NetMsgBase.ErrorDelegate OnAnyMsgError;

		public NetMsgBase.TimeOutDelegate OnAnyMsgTimeOut;

		private List<long> msgIDList;

		private float _currentRatio;

		public float currentRatio
		{
			get
			{
				return 0f;
			}
		}

		public NetMsgSeq(bool isMustFinish = true)
		{
		}

		public int GetSeqCount()
		{
			return 0;
		}

		public void SetDefaultMode(NetworkAlertUI.ExceptionMode mode)
		{
		}

		public void AddOneStep(NetMsgBase msg, FinishStepHandler onFinishStepFunc = null)
		{
		}

		public void AddOneStep(List<NetMsgBase> msgList, FinishStepHandler onFinishStepFunc = null)
		{
		}

		public void Release()
		{
		}

		public void StartSendMsg()
		{
		}

		public bool IsComplete()
		{
			return false;
		}

		public bool IsAborted()
		{
			return false;
		}

		public float GetFinishedStepPercent()
		{
			return 0f;
		}

		private void AttachEvent(NetMsgBase msg)
		{
		}

		private void OnMsgInSeqSucc()
		{
		}

		private void SendNextStep()
		{
		}

		private void OnFinishSeqDefault()
		{
		}

		private void OnFinishStepDefault()
		{
		}

		public void Abort()
		{
		}
	}
}
