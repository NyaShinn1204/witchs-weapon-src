using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public class AVIMMessageQuery
	{
		public AVIMConversation Convsersation { get; set; }

		public int Limit { get; set; }

		public DateTime From { get; set; }

		public DateTime To { get; set; }

		public string EndMessageId { get; set; }

		public string StartMessageId { get; set; }

		internal AVIMMessageQuery()
		{
		}

		public AVIMMessageQuery(AVIMConversation conversation)
		{
		}

		public AVIMMessageQuery SetLimit(int limit)
		{
			return null;
		}

		public Task<IEnumerable<IAVIMMessage>> FindAsync()
		{
			return null;
		}

		public Task<IEnumerable<IAVIMMessage>> ReverseFindAsync()
		{
			return null;
		}

		public Task<IEnumerable<T>> FindAsync<T>(bool reverse = false) where T : IAVIMMessage
		{
			return null;
		}

		public Task<IEnumerable<T>> ReverseFindAsync<T>() where T : IAVIMMessage
		{
			return null;
		}
	}
}
