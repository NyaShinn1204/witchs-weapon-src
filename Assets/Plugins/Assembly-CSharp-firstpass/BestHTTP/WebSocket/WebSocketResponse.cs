using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BestHTTP.Extensions;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket
{
	public sealed class WebSocketResponse : HTTPResponse, IHeartbeat, IProtocol
	{
		public static int RTTBufferCapacity;

		public Action<WebSocketResponse, string> OnText;

		public Action<WebSocketResponse, byte[]> OnBinary;

		public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;

		public Action<WebSocketResponse, ushort, string> OnClosed;

		private int _bufferedAmount;

		private List<WebSocketFrameReader> IncompleteFrames;

		private List<WebSocketFrameReader> CompletedFrames;

		private WebSocketFrameReader CloseFrame;

		private object FrameLock;

		private object SendLock;

		private List<WebSocketFrame> unsentFrames;

		private AutoResetEvent newFrameSignal;

		private bool sendThreadCreated;

		private bool closeSent;

		private bool closed;

		private DateTime lastPing;

		private DateTime lastMessage;

		private CircularBuffer<int> rtts;

		public WebSocket WebSocket { get; internal set; }

		public bool IsClosed
		{
			get
			{
				return false;
			}
		}

		public TimeSpan PingFrequnecy { get; private set; }

		public ushort MaxFragmentSize { get; private set; }

		public int BufferedAmount
		{
			get
			{
				return 0;
			}
		}

		public int Latency { get; private set; }

		internal WebSocketResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache)
			: base(null, null, false, false)
		{
		}

		internal void StartReceive()
		{
		}

		internal void CloseStream()
		{
		}

		public void Send(string message)
		{
		}

		public void Send(byte[] data)
		{
		}

		public void Send(byte[] data, ulong offset, ulong count)
		{
		}

		public void Send(WebSocketFrame frame)
		{
		}

		public void Insert(WebSocketFrame frame)
		{
		}

		public void SendNow(WebSocketFrame frame)
		{
		}

		public void Close()
		{
		}

		public void Close(ushort code, string msg)
		{
		}

		public void StartPinging(int frequency)
		{
		}

		private void SendThreadFunc(object param)
		{
		}

		private void ReceiveThreadFunc(object param)
		{
		}

		void IProtocol.HandleEvents()
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		private void OnApplicationForegroundStateChanged(bool isPaused)
		{
		}

		private void SendPing()
		{
		}

		private void CloseWithError(string message)
		{
		}

		private int CalculateLatency()
		{
			return 0;
		}
	}
}
