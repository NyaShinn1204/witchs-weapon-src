using System.Runtime.InteropServices;

namespace Facebook.Unity
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void HideUnityDelegate(bool isUnityShown);
}
