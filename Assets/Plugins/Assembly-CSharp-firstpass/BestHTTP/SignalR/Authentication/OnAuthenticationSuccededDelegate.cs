using System.Runtime.InteropServices;

namespace BestHTTP.SignalR.Authentication
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnAuthenticationSuccededDelegate(IAuthenticationProvider provider);
}
