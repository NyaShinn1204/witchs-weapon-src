using System.Runtime.InteropServices;

namespace BestHTTP.SocketIO.Events
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SocketIOCallback(Socket socket, Packet packet, params object[] args);
}
