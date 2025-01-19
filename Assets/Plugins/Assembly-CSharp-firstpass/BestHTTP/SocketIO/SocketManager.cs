using System;
using System.Collections.Generic;
using BestHTTP.Extensions;
using BestHTTP.SocketIO.JsonEncoders;
using BestHTTP.SocketIO.Transports;

namespace BestHTTP.SocketIO
{
	public sealed class SocketManager : IHeartbeat, IManager
	{
		public enum States
		{
			Initial = 0,
			Closed = 1,
			Opening = 2,
			Open = 3,
			Paused = 4,
			Reconnecting = 5
		}

		public static IJsonEncoder DefaultEncoder;

		public const int MinProtocolVersion = 4;

		private States state;

		private int nextAckId;

		private Dictionary<string, Socket> Namespaces;

		private List<Socket> Sockets;

		private List<Packet> OfflinePackets;

		private DateTime LastHeartbeat;

		private DateTime ReconnectAt;

		private DateTime ConnectionStarted;

		private bool closing;

		private bool IsWaitingPong;

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

		public SocketOptions Options { get; private set; }

		public Uri Uri { get; private set; }

		public HandshakeData Handshake { get; private set; }

		public ITransport Transport { get; private set; }

		public ulong RequestCounter { get; internal set; }

		public Socket Socket
		{
			get
			{
				return null;
			}
		}

		public Socket Item
		{
			get
			{
				return null;
			}
		}

		public int ReconnectAttempts { get; private set; }

		public IJsonEncoder Encoder { get; set; }

		internal uint Timestamp
		{
			get
			{
				return 0u;
			}
		}

		internal int NextAckId
		{
			get
			{
				return 0;
			}
		}

		internal States PreviousState { get; private set; }

		internal ITransport UpgradingTransport { get; set; }

		public SocketManager(Uri uri)
		{
		}

		public SocketManager(Uri uri, SocketOptions options)
		{
		}

		public Socket GetSocket()
		{
			return null;
		}

		public Socket GetSocket(string nsp)
		{
			return null;
		}

		void IManager.Remove(Socket socket)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		void IManager.Close(bool removeSockets)
		{
		}

		void IManager.TryToReconnect()
		{
		}

		bool IManager.OnTransportConnected(ITransport trans)
		{
			return false;
		}

		void IManager.OnTransportError(ITransport trans, string err)
		{
		}

		void IManager.OnTransportProbed(ITransport trans)
		{
		}

		private ITransport SelectTransport()
		{
			return null;
		}

		private void SendOfflinePackets()
		{
		}

		void IManager.SendPacket(Packet packet)
		{
		}

		void IManager.OnPacket(Packet packet)
		{
		}

		public void EmitAll(string eventName, params object[] args)
		{
		}

		void IManager.EmitEvent(string eventName, params object[] args)
		{
		}

		void IManager.EmitEvent(SocketIOEventTypes type, params object[] args)
		{
		}

		void IManager.EmitError(SocketIOErrors errCode, string msg)
		{
		}

		void IManager.EmitAll(string eventName, params object[] args)
		{
		}

		void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
		{
		}
	}
}
