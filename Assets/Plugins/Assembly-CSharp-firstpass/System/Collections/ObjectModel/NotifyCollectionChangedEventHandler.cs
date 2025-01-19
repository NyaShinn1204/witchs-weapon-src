using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace System.Collections.ObjectModel
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void NotifyCollectionChangedEventHandler(NotifyCollectionChangedEventArgs changeArgs);
}
