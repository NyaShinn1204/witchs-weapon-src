using System.Runtime.InteropServices;

namespace BestHTTP.ServerSentEvents
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnStateChangedDelegate(EventSource eventSource, States oldState, States newState);
}
