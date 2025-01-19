using System.Runtime.InteropServices;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnWebSocketIncompleteFrameDelegate(WebSocket webSocket, WebSocketFrameReader frame);
}
