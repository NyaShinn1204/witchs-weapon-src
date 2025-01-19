using System;

namespace LeanCloud.Realtime
{
	public class AVIMTemporaryConversation : AVIMConversation
	{
		public DateTime ExpiredAt
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		internal AVIMTemporaryConversation(long ttl)
			: base((string)null)
		{
		}
	}
}
