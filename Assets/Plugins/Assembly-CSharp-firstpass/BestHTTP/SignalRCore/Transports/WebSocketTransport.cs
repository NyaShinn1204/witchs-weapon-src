using System;
using System.Collections.Generic;
using BestHTTP.SignalRCore.Messages;
using BestHTTP.WebSocket;

namespace BestHTTP.SignalRCore.Transports
{
	internal sealed class WebSocketTransport : ITransport
	{
		private TransportStates _state;

		private BestHTTP.WebSocket.WebSocket webSocket;

		private HubConnection connection;

		private List<Message> messages;

		public TransportTypes TransportType
		{
			get
			{
				return default(TransportTypes);
			}
		}

		public TransferModes TransferMode
		{
			get
			{
				return default(TransferModes);
			}
		}

		public TransportStates State
		{
			get
			{
				return default(TransportStates);
			}
			private set
			{
			}
		}

		public string ErrorReason { get; private set; }

		public event Action<TransportStates, TransportStates> OnStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public WebSocketTransport(HubConnection con)
		{
		}

		void ITransport.StartConnect()
		{
		}

		void ITransport.Send(byte[] msg)
		{
		}

		private void OnOpen(BestHTTP.WebSocket.WebSocket webSocket)
		{
		}

		private string ParseHandshakeResponse(string data)
		{
			return null;
		}

		private void HandleHandshakeResponse(string data)
		{
		}

		private void OnMessage(BestHTTP.WebSocket.WebSocket webSocket, string data)
		{
		}

		private void OnBinary(BestHTTP.WebSocket.WebSocket webSocket, byte[] data)
		{
		}

		private void OnError(BestHTTP.WebSocket.WebSocket webSocket, string reason)
		{
		}

		private void OnClosed(BestHTTP.WebSocket.WebSocket webSocket, ushort code, string message)
		{
		}

		void ITransport.StartClose()
		{
		}

		private Uri BuildUri(Uri baseUri)
		{
			return null;
		}
	}
}
