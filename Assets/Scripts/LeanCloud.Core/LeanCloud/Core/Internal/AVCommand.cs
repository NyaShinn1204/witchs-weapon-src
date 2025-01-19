using System.Collections.Generic;
using System.IO;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	public class AVCommand : HttpRequest
	{
		public IDictionary<string, object> DataObject { get; private set; }

		public override Stream Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AVCommand(string relativeUri, string method, string sessionToken = null, IList<KeyValuePair<string, string>> headers = null, IDictionary<string, object> data = null)
		{
		}

		public AVCommand(string relativeUri, string method, string sessionToken = null, IList<KeyValuePair<string, string>> headers = null, Stream stream = null, string contentType = null)
		{
		}

		public AVCommand(AVCommand other)
		{
		}
	}
}
