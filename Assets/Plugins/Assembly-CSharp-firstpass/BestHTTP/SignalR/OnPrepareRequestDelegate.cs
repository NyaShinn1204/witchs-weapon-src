using System.Runtime.InteropServices;

namespace BestHTTP.SignalR
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnPrepareRequestDelegate(Connection connection, HTTPRequest req, RequestTypes type);
}
