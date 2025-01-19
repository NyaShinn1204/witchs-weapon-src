using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud
{
	public abstract class AVQueryPair<S, T> where S : IAVQuery where T : IAVObject
	{
		protected readonly string className;

		protected readonly Dictionary<string, object> where;

		protected readonly ReadOnlyCollection<string> orderBy;

		protected readonly ReadOnlyCollection<string> includes;

		protected readonly ReadOnlyCollection<string> selectedKeys;

		protected readonly string redirectClassNameForKey;

		protected readonly int? skip;

		protected readonly int? limit;

		private string relativeUri;

		internal string ClassName
		{
			get
			{
				return null;
			}
		}

		internal string RelativeUri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, object> Condition
		{
			get
			{
				return null;
			}
		}

		protected AVQueryPair()
		{
		}

		public abstract S CreateInstance(IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null);

		protected AVQueryPair(AVQueryPair<S, T> source, IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
		}

		public AVQueryPair(string className)
		{
		}

		private HashSet<string> MergeIncludes(IEnumerable<string> includes)
		{
			return null;
		}

		private HashSet<string> MergeSelectedKeys(IEnumerable<string> selectedKeys)
		{
			return null;
		}

		private IDictionary<string, object> MergeWhereClauses(IDictionary<string, object> where)
		{
			return null;
		}

		public virtual IDictionary<string, object> MergeWhere(IDictionary<string, object> primary, IDictionary<string, object> secondary)
		{
			return null;
		}

		public static Q Or<Q, O>(IEnumerable<Q> queries) where Q : AVQueryBase<O> where O : IAVObject
		{
			return null;
		}

		public virtual S OrderBy(string key)
		{
			return default(S);
		}

		public virtual S OrderByDescending(string key)
		{
			return default(S);
		}

		public virtual S ThenBy(string key)
		{
			return default(S);
		}

		public virtual S ThenByDescending(string key)
		{
			return default(S);
		}

		public virtual S Include(string key)
		{
			return default(S);
		}

		public virtual S Select(string key)
		{
			return default(S);
		}

		public virtual S Skip(int count)
		{
			return default(S);
		}

		public virtual S Limit(int count)
		{
			return default(S);
		}

		internal virtual S RedirectClassName(string key)
		{
			return default(S);
		}

		public virtual S WhereContainedIn<TIn>(string key, IEnumerable<TIn> values)
		{
			return default(S);
		}

		public virtual S WhereContainsAll<TIn>(string key, IEnumerable<TIn> values)
		{
			return default(S);
		}

		public virtual S WhereContains(string key, string substring)
		{
			return default(S);
		}

		public virtual S WhereDoesNotExist(string key)
		{
			return default(S);
		}

		public virtual S WhereDoesNotMatchQuery<TOther>(string key, AVQuery<TOther> query) where TOther : AVObject
		{
			return default(S);
		}

		public virtual S WhereEndsWith(string key, string suffix)
		{
			return default(S);
		}

		public virtual S WhereEqualTo(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereSizeEqualTo(string key, uint size)
		{
			return default(S);
		}

		public virtual S WhereExists(string key)
		{
			return default(S);
		}

		public virtual S WhereGreaterThan(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereGreaterThanOrEqualTo(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereLessThan(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereLessThanOrEqualTo(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereMatches(string key, Regex regex, string modifiers)
		{
			return default(S);
		}

		public virtual S WhereMatches(string key, Regex regex)
		{
			return default(S);
		}

		public virtual S WhereMatches(string key, string pattern, string modifiers = null)
		{
			return default(S);
		}

		public virtual S WhereMatches(string key, string pattern)
		{
			return default(S);
		}

		public virtual S WhereMatchesKeyInQuery<TOther>(string key, string keyInQuery, AVQuery<TOther> query) where TOther : AVObject
		{
			return default(S);
		}

		public virtual S WhereDoesNotMatchesKeyInQuery<TOther>(string key, string keyInQuery, AVQuery<TOther> query) where TOther : AVObject
		{
			return default(S);
		}

		public virtual S WhereMatchesQuery<TOther>(string key, AVQuery<TOther> query) where TOther : AVObject
		{
			return default(S);
		}

		public virtual S WhereNear(string key, AVGeoPoint point)
		{
			return default(S);
		}

		public virtual S WhereNotContainedIn<TIn>(string key, IEnumerable<TIn> values)
		{
			return default(S);
		}

		public virtual S WhereNotEqualTo(string key, object value)
		{
			return default(S);
		}

		public virtual S WhereStartsWith(string key, string suffix)
		{
			return default(S);
		}

		public virtual S WhereWithinGeoBox(string key, AVGeoPoint southwest, AVGeoPoint northeast)
		{
			return default(S);
		}

		public virtual S WhereWithinDistance(string key, AVGeoPoint point, AVGeoDistance maxDistance)
		{
			return default(S);
		}

		internal virtual S WhereRelatedTo(AVObject parent, string key)
		{
			return default(S);
		}

		public virtual Task<IEnumerable<T>> FindAsync()
		{
			return null;
		}

		public abstract Task<IEnumerable<T>> FindAsync(CancellationToken cancellationToken);

		public virtual Task<T> FirstOrDefaultAsync()
		{
			return null;
		}

		public abstract Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken);

		public virtual Task<T> FirstAsync()
		{
			return null;
		}

		public abstract Task<T> FirstAsync(CancellationToken cancellationToken);

		public virtual Task<int> CountAsync()
		{
			return null;
		}

		public abstract Task<int> CountAsync(CancellationToken cancellationToken);

		public virtual Task<T> GetAsync(string objectId)
		{
			return null;
		}

		public abstract Task<T> GetAsync(string objectId, CancellationToken cancellationToken);

		internal object GetConstraint(string key)
		{
			return null;
		}

		public IDictionary<string, object> BuildParameters(bool includeClassName = false)
		{
			return null;
		}

		private string RegexQuote(string input)
		{
			return null;
		}

		private string GetRegexOptions(Regex regex, string modifiers)
		{
			return null;
		}

		private IDictionary<string, object> EncodeRegex(Regex regex, string modifiers)
		{
			return null;
		}
	}
}
