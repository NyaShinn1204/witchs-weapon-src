using System.Runtime.InteropServices;

namespace BestHTTP.SignalR
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnStateChanged(Connection connection, ConnectionStates oldState, ConnectionStates newState);
}
