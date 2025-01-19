using System.Runtime.InteropServices;

namespace BestHTTP.SignalR.Authentication
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnAuthenticationFailedDelegate(IAuthenticationProvider provider, string reason);
}
