using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public struct AVIMSendOptions
	{
		private bool _receipt;

		public bool Receipt;

		public bool Transient;

		public int Priority;

		public bool Will;

		public IDictionary<string, object> PushData;
	}
}
