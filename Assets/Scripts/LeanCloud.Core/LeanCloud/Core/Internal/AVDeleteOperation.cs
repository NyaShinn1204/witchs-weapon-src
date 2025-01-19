namespace LeanCloud.Core.Internal
{
	public class AVDeleteOperation : IAVFieldOperation
	{
		internal static readonly object DeleteToken;

		private static AVDeleteOperation _Instance;

		public static AVDeleteOperation Instance
		{
			get
			{
				return null;
			}
		}

		private AVDeleteOperation()
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
