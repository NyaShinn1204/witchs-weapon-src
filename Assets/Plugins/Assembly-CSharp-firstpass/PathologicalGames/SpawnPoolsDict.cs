using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace PathologicalGames
{
	public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void OnCreatedDelegate(SpawnPool pool);

		internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

		private Dictionary<string, SpawnPool> _pools;

		bool ICollection<KeyValuePair<string, SpawnPool>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public SpawnPool Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<SpawnPool> Values
		{
			get
			{
				return null;
			}
		}

		private bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		public SpawnPool Create(string poolName)
		{
			return null;
		}

		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		private bool assertValidPoolName(string poolName)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Destroy(string poolName)
		{
			return false;
		}

		public void DestroyAll()
		{
		}

		internal void Add(SpawnPool spawnPool)
		{
		}

		public void Add(string key, SpawnPool value)
		{
		}

		internal bool Remove(SpawnPool spawnPool)
		{
			return false;
		}

		public bool Remove(string poolName)
		{
			return false;
		}

		public bool ContainsKey(string poolName)
		{
			return false;
		}

		public bool ContainsValue(SpawnPool pool)
		{
			return false;
		}

		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			spawnPool = null;
			return false;
		}

		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return false;
		}

		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		public void Clear()
		{
		}

		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		void ICollection<KeyValuePair<string, SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
