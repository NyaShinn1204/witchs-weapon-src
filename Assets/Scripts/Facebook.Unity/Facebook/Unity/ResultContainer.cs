using System.Collections.Generic;

namespace Facebook.Unity
{
	internal class ResultContainer
	{
		private const string CanvasResponseKey = "response";

		public string RawResult { get; private set; }

		public IDictionary<string, object> ResultDictionary { get; set; }

		public ResultContainer(IDictionary<string, object> dictionary)
		{
		}

		public ResultContainer(string result)
		{
		}

		private IDictionary<string, object> GetWebFormattedResponseDictionary(IDictionary<string, object> resultDictionary)
		{
			return null;
		}
	}
}
