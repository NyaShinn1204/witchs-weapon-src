using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;

namespace LeanCloud
{
	public class AVQuery<T> : AVQueryPair<AVQuery<T>, T>, IAVQuery where T : AVObject
	{
		internal static IAVQueryController QueryController
		{
			get
			{
				return null;
			}
		}

		internal static IObjectSubclassingController SubclassingController
		{
			get
			{
				return null;
			}
		}

		private string JsonString
		{
			get
			{
				return null;
			}
		}

		private AVQuery(AVQuery<T> source, IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
		}

		public override AVQuery<T> CreateInstance(IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
			return null;
		}

		public AVQuery()
		{
		}

		public AVQuery(string className)
		{
		}

		public static AVQuery<T> Or(IEnumerable<AVQuery<T>> queries)
		{
			return null;
		}

		public override Task<IEnumerable<T>> FindAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<T> FirstAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<int> CountAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<T> GetAsync(string objectId, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<IEnumerable<T>> DoCloudQueryAsync(string cql, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<IEnumerable<T>> DoCloudQueryAsync(string cql)
		{
			return null;
		}

		public static Task<IEnumerable<T>> DoCloudQueryAsync(string cqlTeamplate, params object[] pvalues)
		{
			return null;
		}

		internal static Task<IEnumerable<T>> rebuildObjectFromCloudQueryResult(string queryString)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
