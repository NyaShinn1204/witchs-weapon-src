using System;
using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class AVDecoder
	{
		private static readonly AVDecoder instance;

		public static AVDecoder Instance
		{
			get
			{
				return null;
			}
		}

		private AVDecoder()
		{
		}

		public object Decode(object data)
		{
			return null;
		}

		protected virtual object DecodePointer(string className, string objectId)
		{
			return null;
		}

		protected virtual object DecodeAVObject(IDictionary<string, object> dict)
		{
			return null;
		}

		protected virtual object DecodeAVFile(IDictionary<string, object> dict)
		{
			return null;
		}

		public virtual IList<T> DecodeList<T>(object data)
		{
			return null;
		}

		public static DateTime ParseDate(string input)
		{
			return default(DateTime);
		}
	}
}
