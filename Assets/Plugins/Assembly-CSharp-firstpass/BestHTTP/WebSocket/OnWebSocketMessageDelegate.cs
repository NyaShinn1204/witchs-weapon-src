using System.Runtime.InteropServices;

namespace BestHTTP.WebSocket
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnWebSocketMessageDelegate(WebSocket webSocket, string message);
}
