using System.Collections.ObjectModel;

namespace System.Collections.Specialized
{
	public class NotifyCollectionChangedEventArgs : EventArgs
	{
		private NotifyCollectionChangedAction _notifyAction;

		private IList _newItemList;

		private int _newStartingIndex;

		private IList _oldItemList;

		private int _oldStartingIndex;

		public NotifyCollectionChangedAction Action
		{
			get
			{
				return default(NotifyCollectionChangedAction);
			}
		}

		public IList NewItems
		{
			get
			{
				return null;
			}
		}

		public int NewStartingIndex
		{
			get
			{
				return 0;
			}
		}

		public IList OldItems
		{
			get
			{
				return null;
			}
		}

		public int OldStartingIndex
		{
			get
			{
				return 0;
			}
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
		}

		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
		}

		private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
		{
		}

		private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
		{
		}

		private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
		{
		}
	}
}
