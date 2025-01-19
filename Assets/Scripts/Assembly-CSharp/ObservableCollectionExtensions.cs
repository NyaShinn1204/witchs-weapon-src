using System;
using System.Collections.ObjectModel;

public static class ObservableCollectionExtensions
{
	public static IDisposable BindCollection<TCollectionItemType>(this ObservableCollection<TCollectionItemType> collection, IBindable t, Action<TCollectionItemType> added, Action<TCollectionItemType> removed)
	{
		return null;
	}
}
