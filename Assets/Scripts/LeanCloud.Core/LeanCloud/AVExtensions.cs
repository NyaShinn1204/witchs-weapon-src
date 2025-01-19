using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud
{
	public static class AVExtensions
	{
		public static Task SaveAllAsync<T>(this IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task SaveAllAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(this IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(this IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static AVQuery<T> Or<T>(this AVQuery<T> source, params AVQuery<T>[] queries) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj, IEnumerable<string> includeKeys) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj, IEnumerable<string> includeKeys, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchIfNeededAsync<T>(this T obj) where T : AVObject
		{
			return null;
		}

		public static Task<T> FetchIfNeededAsync<T>(this T obj, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}
	}
}
