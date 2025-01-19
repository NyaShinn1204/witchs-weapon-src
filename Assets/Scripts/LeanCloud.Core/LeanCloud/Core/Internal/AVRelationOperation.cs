using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class AVRelationOperation : IAVFieldOperation
	{
		private readonly IList<string> adds;

		private readonly IList<string> removes;

		private readonly string targetClassName;

		public string TargetClassName
		{
			get
			{
				return null;
			}
		}

		private AVRelationOperation(IEnumerable<string> adds, IEnumerable<string> removes, string targetClassName)
		{
		}

		public AVRelationOperation(IEnumerable<AVObject> adds, IEnumerable<AVObject> removes)
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

		private IEnumerable<string> IdsFromObjects(IEnumerable<AVObject> objects)
		{
			return null;
		}
	}
}
