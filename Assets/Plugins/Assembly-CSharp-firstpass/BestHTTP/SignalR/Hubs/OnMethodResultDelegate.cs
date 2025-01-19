using System.Runtime.InteropServices;
using BestHTTP.SignalR.Messages;

namespace BestHTTP.SignalR.Hubs
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnMethodResultDelegate(Hub hub, ClientMessage originalMessage, ResultMessage result);
}
