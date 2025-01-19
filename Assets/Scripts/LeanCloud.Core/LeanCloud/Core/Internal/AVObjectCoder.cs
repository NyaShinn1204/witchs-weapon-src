using System;
using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class AVObjectCoder
	{
		private static readonly AVObjectCoder instance;

		public static AVObjectCoder Instance
		{
			get
			{
				return null;
			}
		}

		private AVObjectCoder()
		{
		}

		public IDictionary<string, object> Encode<T>(T state, IDictionary<string, IAVFieldOperation> operations, AVEncoder encoder) where T : IObjectState
		{
			return null;
		}

		public IObjectState Decode(IDictionary<string, object> data, AVDecoder decoder)
		{
			return null;
		}

		private T extractFromDictionary<T>(IDictionary<string, object> data, string key, Func<object, T> action)
		{
			return default(T);
		}
	}
}
