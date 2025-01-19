using System.Runtime.InteropServices;

namespace BestHTTP.SignalR
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnClosedDelegate(Connection connection);
}
