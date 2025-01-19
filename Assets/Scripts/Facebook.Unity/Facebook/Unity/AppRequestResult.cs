using System.Collections.Generic;

namespace Facebook.Unity
{
	internal class AppRequestResult : ResultBase, IAppRequestResult, IResult
	{
		public string RequestID { get; private set; }

		public IEnumerable<string> To { get; private set; }

		public AppRequestResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
