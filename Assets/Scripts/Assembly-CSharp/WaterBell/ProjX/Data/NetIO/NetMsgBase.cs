using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BestHTTP;
using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class NetMsgBase : IHTTPDetailResponse, IHTTPResponse
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void SuccessfulDelegate();

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void FailedDelegate(string text);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void ErrorDelegate(string ErrorCode);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void TimeOutDelegate(HTTPRequestStates status);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void InternalErrorDelegate(string text);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DealResultHandler(object sender, EventArgs argu);

		public SuccessfulDelegate OnSuccessfulDelegate;

		public FailedDelegate OnFailedDelegate;

		public ErrorDelegate OnErrorDelegate;

		public TimeOutDelegate OnTimeOutDelegate;

		public InternalErrorDelegate OnInternalErrorDelegate;

		protected ArrayList argumentList;

		protected string ContentName;

		protected bool isCommonMsg;

		public int UniqueID;

		public NetMsgType msgType;

		public Dictionary<string, string> argumentDic;

		public long MsgID;

		protected bool haveAddIdempotency;

		protected string url;

		protected NetMsgSvr tag;

		protected int domainType;

		public int code;

		public bool isInMsgSeq;

		public bool needShowConnect;

		private string checkEvtID;

		private int[] recIDArr;

		private int[] recStateArr;

		public static bool isAllNetMsgDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool isDebugArgu
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string offlineValue
		{
			get
			{
				return null;
			}
		}

		public event DealResultHandler defaultDealResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public void FireDealResult(EventArgs argu)
		{
		}

		public virtual void InitParams(int code)
		{
		}

		public void AppendSign2Arguments()
		{
		}

		protected virtual void Init(params string[] names)
		{
		}

		protected virtual void SetIsCommonAndContentName()
		{
		}

		protected void OnSuccess()
		{
		}

		protected void OnFail(string msg)
		{
		}

		public string GetURL()
		{
			return null;
		}

		private string getDataAsText(byte[] data)
		{
			return null;
		}

		public bool IsOKValue(string str)
		{
			return false;
		}

		public virtual void OnData(byte[] data, string URL, string type, string tag = null)
		{
		}

		private void finishGetSetData(string ids)
		{
		}

		protected void DealErrorCode(string error)
		{
		}

		public virtual void OnData(string text, string URL, string type, string tag = null)
		{
		}

		public virtual void OnData(JsonData json)
		{
		}

		public virtual void OnProtoBufData(byte[] bytes)
		{
		}

		public virtual void OnError(string detail)
		{
		}

		public virtual void OnTimeOut(HTTPRequestStates status)
		{
		}

		protected virtual void AddArgumentsBeforeSend()
		{
		}

		public virtual void SendMsg()
		{
		}

		private void offlineHD()
		{
		}

		public virtual void ReSendMsg()
		{
		}

		private void PrintArguments()
		{
		}

		public void StartCountDown()
		{
		}

		public bool CheckLocalGuide()
		{
			return false;
		}

		public void CacheResponseData(NetMsgType type, JsonData data)
		{
		}

		public void CheckWait()
		{
		}

		public virtual void OnInternalError(string detail)
		{
		}

		public int GetNetMsgCode()
		{
			return 0;
		}

		protected void AddContentAndsignature(string ContentName)
		{
		}

		public void AppendGuideRec2Arguments(int[] idArr, int[] stateArr)
		{
		}
	}
}
