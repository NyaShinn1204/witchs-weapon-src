using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	public class AVConfig : IJsonConvertible
	{
		private IDictionary<string, object> properties;

		public static AVConfig CurrentConfig
		{
			get
			{
				return null;
			}
		}

		private static IAVConfigController ConfigController
		{
			get
			{
				return null;
			}
		}

		public virtual object Item
		{
			get
			{
				return null;
			}
		}

		internal static void ClearCurrentConfig()
		{
		}

		internal static void ClearCurrentConfigInMemory()
		{
		}

		internal AVConfig()
		{
		}

		internal AVConfig(IDictionary<string, object> fetchedConfig)
		{
		}

		public static Task<AVConfig> GetAsync()
		{
			return null;
		}

		public static Task<AVConfig> GetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public bool TryGetValue<T>(string key, out T result)
		{
			result = default(T);
			return false;
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}
	}
}
