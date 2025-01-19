using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LeanCloud.Core.Internal
{
	public class AVRemoveOperation : IAVFieldOperation
	{
		private ReadOnlyCollection<object> objects;

		public IEnumerable<object> Objects
		{
			get
			{
				return null;
			}
		}

		public AVRemoveOperation(IEnumerable<object> objects)
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
