using System.Collections.Generic;

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsCyclicReferenceManager
	{
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
		{
			public static readonly IEqualityComparer<object> Instance;

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003Cobject_003E_002EEquals(object x, object y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003Cobject_003E_002EGetHashCode(object obj)
			{
				return 0;
			}
		}

		private Dictionary<object, int> _objectIds;

		private int _nextId;

		private Dictionary<int, object> _marked;

		private int _depth;

		public void Enter()
		{
		}

		public bool Exit()
		{
			return false;
		}

		public object GetReferenceObject(int id)
		{
			return null;
		}

		public void AddReferenceWithId(int id, object reference)
		{
		}

		public int GetReferenceId(object item)
		{
			return 0;
		}

		public bool IsReference(object item)
		{
			return false;
		}

		public void MarkSerialized(object item)
		{
		}
	}
}
