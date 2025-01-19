using System;
using System.Collections.Generic;
using System.IO;

namespace LeanCloud.Storage.Internal
{
	public class HttpRequest
	{
		public Uri Uri { get; set; }

		public IList<KeyValuePair<string, string>> Headers { get; set; }

		public virtual Stream Data { get; set; }

		public string Method { get; set; }
	}
}
