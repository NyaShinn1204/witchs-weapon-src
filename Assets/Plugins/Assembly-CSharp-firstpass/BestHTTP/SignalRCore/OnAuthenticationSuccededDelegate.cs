using System.Runtime.InteropServices;

namespace BestHTTP.SignalRCore
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnAuthenticationSuccededDelegate(IAuthenticationProvider provider);
}
