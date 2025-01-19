using System;
using System.Collections.Generic;
using BestHTTP.Extensions;

namespace BestHTTP.ServerSentEvents
{
	public class EventSource : IHeartbeat
	{
		private States _state;

		private Dictionary<string, OnEventDelegate> EventTable;

		private byte RetryCount;

		private DateTime RetryCalled;

		public Uri Uri { get; private set; }

		public States State
		{
			get
			{
				return default(States);
			}
			private set
			{
			}
		}

		public TimeSpan ReconnectionTime { get; set; }

		public string LastEventId { get; private set; }

		public HTTPRequest InternalRequest { get; private set; }

		public event OnGeneralEventDelegate OnOpen
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnMessageDelegate OnMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnErrorDelegate OnError
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnRetryDelegate OnRetry
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnGeneralEventDelegate OnClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnStateChangedDelegate OnStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public EventSource(Uri uri)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void On(string eventName, OnEventDelegate action)
		{
		}

		public void Off(string eventName)
		{
		}

		private void CallOnError(string error, string msg)
		{
		}

		private bool CallOnRetry()
		{
			return false;
		}

		private void SetClosed(string msg)
		{
		}

		private void Retry()
		{
		}

		private void OnUpgraded(HTTPRequest originalRequest, HTTPResponse response)
		{
		}

		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void OnMessageReceived(EventSourceResponse resp, Message message)
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}
	}
}
