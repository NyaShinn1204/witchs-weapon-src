using System.Collections;
using System.ComponentModel;

namespace LeanCloud
{
	public class CollectionPropertyUpdatedEventArgs : PropertyChangedEventArgs
	{
		public IEnumerable OldValues { get; set; }

		public IEnumerable NewValues { get; set; }

		public NotifyCollectionUpdatedAction CollectionAction { get; set; }

		public CollectionPropertyUpdatedEventArgs(string propertyName, NotifyCollectionUpdatedAction collectionAction, IEnumerable oldValues, IEnumerable newValues)
			: base(null)
		{
		}
	}
}
