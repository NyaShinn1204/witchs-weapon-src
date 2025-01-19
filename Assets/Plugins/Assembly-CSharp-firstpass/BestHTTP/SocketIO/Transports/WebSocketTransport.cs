using System;
using System.Collections.Generic;
using BestHTTP.WebSocket;

namespace BestHTTP.SocketIO.Transports
{
	internal sealed class WebSocketTransport : ITransport
	{
		private Packet PacketWithAttachment;

		private byte[] Buffer;

		public TransportTypes Type
		{
			get
			{
				return default(TransportTypes);
			}
		}

		public TransportStates State { get; private set; }

		public SocketManager Manager { get; private set; }

		public bool IsRequestInProgress
		{
			get
			{
				return false;
			}
		}

		public bool IsPollingInProgress
		{
			get
			{
				return false;
			}
		}

		public BestHTTP.WebSocket.WebSocket Implementation { get; private set; }

		public WebSocketTransport(SocketManager manager)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Poll()
		{
		}

		private void OnOpen(BestHTTP.WebSocket.WebSocket ws)
		{
		}

		private void OnMessage(BestHTTP.WebSocket.WebSocket ws, string message)
		{
		}

		private void OnBinary(BestHTTP.WebSocket.WebSocket ws, byte[] data)
		{
		}

		private void OnError(BestHTTP.WebSocket.WebSocket ws, Exception ex)
		{
		}

		private void OnClosed(BestHTTP.WebSocket.WebSocket ws, ushort code, string message)
		{
		}

		public void Send(Packet packet)
		{
		}

		public void Send(List<Packet> packets)
		{
		}

		private void OnPacket(Packet packet)
		{
		}
	}
}
