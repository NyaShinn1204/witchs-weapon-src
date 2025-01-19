using System.Collections.Generic;

namespace BestHTTP.SocketIO.Transports
{
	internal sealed class PollingTransport : ITransport
	{
		private enum PayloadTypes : byte
		{
			Text = 0,
			Binary = 1
		}

		private HTTPRequest LastRequest;

		private HTTPRequest PollRequest;

		private Packet PacketWithAttachment;

		private List<Packet> lonelyPacketList;

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

		public PollingTransport(SocketManager manager)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Send(Packet packet)
		{
		}

		public void Send(List<Packet> packets)
		{
		}

		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		public void Poll()
		{
		}

		private void OnPollRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		private void OnPacket(Packet packet)
		{
		}

		private void ParseResponse(HTTPResponse resp)
		{
		}
	}
}
