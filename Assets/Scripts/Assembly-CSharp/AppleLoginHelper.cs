using System.Runtime.InteropServices;

public class AppleLoginHelper
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LoginDelegate(string UserId, string Signature);

	public static AppleLoginHelper instance;

	public LoginDelegate OnAppleLoginComplete;

	public static AppleLoginHelper GetInstance()
	{
		return null;
	}

	public void AppleLoginback(string date)
	{
	}
}
