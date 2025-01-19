using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public class AVIMMessagePager
	{
		public AVIMMessageQuery Query { get; private set; }

		public int PageSize
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public string CurrentMessageIdFlag
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DateTime CurrentDateTimeFlag
		{
			get
			{
				return default(DateTime);
			}
			private set
			{
			}
		}

		internal AVIMMessagePager()
		{
		}

		public AVIMMessagePager(AVIMConversation conversation)
		{
		}

		public AVIMMessagePager SetPageSize(int pageSize)
		{
			return null;
		}

		public Task<IEnumerable<IAVIMMessage>> PreviousAsync()
		{
			return null;
		}

		public Task<IEnumerable<IAVIMMessage>> NextAsync()
		{
			return null;
		}
	}
}
