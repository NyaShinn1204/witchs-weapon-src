using System.Runtime.InteropServices;

namespace BestHTTP.SignalR.Transports
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnTransportStateChangedDelegate(TransportBase transport, TransportStates oldState, TransportStates newState);
}
