using System.Runtime.InteropServices;

namespace BestHTTP.SignalR
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnNonHubMessageDelegate(Connection connection, object data);
}
