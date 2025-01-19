using System.Collections.Generic;

namespace Facebook.Unity
{
	internal class AppLinkResult : ResultBase, IAppLinkResult, IResult
	{
		public string Url { get; private set; }

		public string TargetUrl { get; private set; }

		public string Ref { get; private set; }

		public IDictionary<string, object> Extras { get; private set; }

		public AppLinkResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
