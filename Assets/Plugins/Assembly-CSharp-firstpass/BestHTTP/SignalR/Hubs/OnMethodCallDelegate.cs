using System.Runtime.InteropServices;

namespace BestHTTP.SignalR.Hubs
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnMethodCallDelegate(Hub hub, string method, params object[] args);
}
