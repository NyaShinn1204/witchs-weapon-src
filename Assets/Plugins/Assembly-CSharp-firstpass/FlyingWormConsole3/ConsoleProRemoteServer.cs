using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

namespace FlyingWormConsole3
{
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		public class HTTPContext
		{
			public HttpListenerContext context;

			public string path;

			public string Command
			{
				get
				{
					return null;
				}
			}

			public HttpListenerRequest Request
			{
				get
				{
					return null;
				}
			}

			public HttpListenerResponse Response
			{
				get
				{
					return null;
				}
			}

			public HTTPContext(HttpListenerContext inContext)
			{
			}

			public void RespondWithString(string inString)
			{
			}
		}

		[Serializable]
		public class QueuedLog
		{
			public string message;

			public string stackTrace;

			public LogType type;
		}

		public int port;

		private static HttpListener listener;

		[NonSerialized]
		public List<QueuedLog> logs;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void LogCallback(string logString, string stackTrace, LogType type)
		{
		}

		private void QueueLog(string logString, string stackTrace, LogType type)
		{
		}

		private void ListenerCallback(IAsyncResult result)
		{
		}

		private void HandleRequest(HTTPContext context)
		{
		}
	}
}
