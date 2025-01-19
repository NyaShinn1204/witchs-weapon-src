using System.Runtime.InteropServices;
using BestHTTP.SignalR.Messages;

namespace BestHTTP.SignalR.Hubs
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnMethodCallCallbackDelegate(Hub hub, MethodCallMessage methodCall);
}
