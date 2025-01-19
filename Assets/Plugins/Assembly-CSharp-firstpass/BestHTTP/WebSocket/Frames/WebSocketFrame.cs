namespace BestHTTP.WebSocket.Frames
{
	public sealed class WebSocketFrame
	{
		public static readonly byte[] NoData;

		public WebSocketFrameTypes Type { get; private set; }

		public bool IsFinal { get; private set; }

		public byte Header { get; private set; }

		public byte[] Data { get; private set; }

		public bool UseExtensions { get; private set; }

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool useExtensions)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool isFinal, bool useExtensions)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, ulong pos, ulong length, bool isFinal, bool useExtensions)
		{
		}

		public byte[] Get()
		{
			return null;
		}

		public WebSocketFrame[] Fragment(ushort maxFragmentSize)
		{
			return null;
		}
	}
}
