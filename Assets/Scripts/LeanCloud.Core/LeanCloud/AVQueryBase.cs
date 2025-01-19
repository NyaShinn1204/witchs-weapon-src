using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LeanCloud
{
	public abstract class AVQueryBase<T> : IAVQuery where T : IAVObject
	{
		internal string className;

		internal Dictionary<string, object> where;

		internal ReadOnlyCollection<string> orderBy;

		internal ReadOnlyCollection<string> includes;

		internal ReadOnlyCollection<string> selectedKeys;

		internal string redirectClassNameForKey;

		internal int? skip;

		internal int? limit;

		public virtual Dictionary<string, object> Where
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, object> BuildParameters(bool includeClassName = false)
		{
			return null;
		}

		public virtual IDictionary<string, object> MergeWhere(IDictionary<string, object> primary, IDictionary<string, object> secondary)
		{
			return null;
		}
	}
}
