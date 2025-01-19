using System.Runtime.InteropServices;

namespace BestHTTP.ServerSentEvents
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate bool OnRetryDelegate(EventSource eventSource);
}
