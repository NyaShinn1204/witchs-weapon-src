using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
	[Serializable]
	public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		[Serializable]
		private sealed class SimpleMonitor : IDisposable
		{
			private int _busyCount;

			public bool Busy
			{
				get
				{
					return false;
				}
			}

			public void Enter()
			{
			}

			public void Dispose()
			{
			}
		}

		private SimpleMonitor _monitor;

		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual event NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public ObservableCollection()
		{
		}

		public ObservableCollection(IEnumerable<T> collection)
		{
		}

		public ObservableCollection(List<T> list)
		{
		}

		protected IDisposable BlockReentrancy()
		{
			return null;
		}

		protected void CheckReentrancy()
		{
		}

		protected override void ClearItems()
		{
		}

		protected override void InsertItem(int index, T item)
		{
		}

		public void Move(int oldIndex, int newIndex)
		{
		}

		protected virtual void MoveItem(int oldIndex, int newIndex)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void SetItem(int index, T item)
		{
		}
	}
}
