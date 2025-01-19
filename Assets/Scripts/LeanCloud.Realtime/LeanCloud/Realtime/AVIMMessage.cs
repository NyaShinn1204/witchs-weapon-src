using System.Collections.Generic;
using LeanCloud.Realtime.Internal;

namespace LeanCloud.Realtime
{
	public class AVIMMessage : IAVIMMessage
	{
		internal readonly object mutex;

		public string ConversationId { get; set; }

		public string FromClientId { get; set; }

		public string Id { get; set; }

		public long ServerTimestamp { get; set; }

		public string Content { get; set; }

		public long RcpTimestamp { get; set; }

		public long UpdatedAt { get; set; }

		internal string cmdId { get; set; }

		public bool MentionAll { get; set; }

		public IEnumerable<string> MentionList { get; set; }

		public virtual string Serialize()
		{
			return null;
		}

		public virtual bool Validate(string msgStr)
		{
			return false;
		}

		public virtual IAVIMMessage Deserialize(string msgStr)
		{
			return null;
		}

		internal virtual MessageCommand BeforeSend(MessageCommand cmd)
		{
			return null;
		}

		internal static IAVIMMessage CopyMetaData(IAVIMMessage srcMsg, IAVIMMessage desMsg)
		{
			return null;
		}
	}
}
