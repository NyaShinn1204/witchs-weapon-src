using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Storage.Internal
{
	public class StorageController : IStorageController
	{
		private class StorageDictionary : IStorageDictionary<string, object>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
		{
			private object mutex;

			private Dictionary<string, object> dictionary;

			private string settingsPath;

			private bool isWebPlayer;

			public IEnumerable<string> Keys
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<object> Values
			{
				get
				{
					return null;
				}
			}

			public object Item
			{
				get
				{
					return null;
				}
			}

			public int Count
			{
				get
				{
					return 0;
				}
			}

			public StorageDictionary(string settingsPath, bool isWebPlayer)
			{
			}

			internal Task SaveAsync()
			{
				return null;
			}

			internal Task LoadAsync()
			{
				return null;
			}

			internal void Update(IDictionary<string, object> contents)
			{
			}

			public Task AddAsync(string key, object value)
			{
				return null;
			}

			public Task RemoveAsync(string key)
			{
				return null;
			}

			public bool ContainsKey(string key)
			{
				return false;
			}

			public bool TryGetValue(string key, out object value)
			{
				value = null;
				return false;
			}

			public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private const string LeanCloudStorageFileName = "LeanCloud.settings";

		private TaskQueue taskQueue;

		private string settingsPath;

		private StorageDictionary storageDictionary;

		private bool isWebPlayer;

		public StorageController()
		{
		}

		public StorageController(string settingsPath)
		{
		}

		public StorageController(bool isWebPlayer, string fileNamePrefix)
		{
		}

		public StorageController(string settingsPath, bool isWebPlayer)
		{
		}

		public Task<IStorageDictionary<string, object>> LoadAsync()
		{
			return null;
		}

		public Task<IStorageDictionary<string, object>> SaveAsync(IDictionary<string, object> contents)
		{
			return null;
		}
	}
}
