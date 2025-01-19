namespace LeanCloud.Core.Internal
{
	public class AVSetOperation : IAVFieldOperation
	{
		public object Value { get; private set; }

		public AVSetOperation(object value)
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
