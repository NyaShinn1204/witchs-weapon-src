using System.Runtime.InteropServices;

namespace LeanCloud
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PropertyUpdatedEventHandler(object sender, PropertyUpdatedEventArgs args);
}
