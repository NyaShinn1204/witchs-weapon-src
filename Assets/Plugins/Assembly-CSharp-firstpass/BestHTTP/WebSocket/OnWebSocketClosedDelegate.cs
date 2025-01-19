using System.Runtime.InteropServices;

namespace BestHTTP.WebSocket
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnWebSocketClosedDelegate(WebSocket webSocket, ushort code, string message);
}
