using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public interface IAVIMMessage
	{
		string ConversationId { get; set; }

		string FromClientId { get; set; }

		string Id { get; set; }

		long ServerTimestamp { get; set; }

		long RcpTimestamp { get; set; }

		long UpdatedAt { get; set; }

		bool MentionAll { get; set; }

		IEnumerable<string> MentionList { get; set; }

		string Serialize();

		bool Validate(string msgStr);

		IAVIMMessage Deserialize(string msgStr);
	}
}
