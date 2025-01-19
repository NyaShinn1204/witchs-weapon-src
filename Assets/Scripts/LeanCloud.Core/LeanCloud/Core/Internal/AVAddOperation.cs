using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LeanCloud.Core.Internal
{
	public class AVAddOperation : IAVFieldOperation
	{
		private ReadOnlyCollection<object> objects;

		public IEnumerable<object> Objects
		{
			get
			{
				return null;
			}
		}

		public AVAddOperation(IEnumerable<object> objects)
		{
		}

		public object Encode()
		{
			return null;
		}

		public IAVFieldOperation MergeWithPrevious(IAVFieldOperation previous)
		{
			return null;
		}

		public object Apply(object oldValue, string key)
		{
			return null;
		}
	}
}
