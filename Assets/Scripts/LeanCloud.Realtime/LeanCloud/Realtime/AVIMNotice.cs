using System;
using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMNotice : EventArgs
	{
		public readonly string CommandName;

		public readonly IDictionary<string, object> RawData;

		public AVIMNotice()
		{
		}

		public AVIMNotice(IDictionary<string, object> estimatedData)
		{
		}

		public static bool IsValidLeanCloudProtocol(IDictionary<string, object> estimatedData)
		{
			return false;
		}
	}
}
