using System.Runtime.InteropServices;

namespace LeanCloud
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void CollectionPropertyUpdatedEventHandler(object sender, CollectionPropertyUpdatedEventArgs args);
}
