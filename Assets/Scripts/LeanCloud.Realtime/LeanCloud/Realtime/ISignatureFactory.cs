using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public interface ISignatureFactory
	{
		Task<AVIMSignature> CreateConnectSignature(string clientId);

		Task<AVIMSignature> CreateStartConversationSignature(string clientId, IEnumerable<string> targetIds);

		Task<AVIMSignature> CreateConversationSignature(string conversationId, string clientId, IEnumerable<string> targetIds, ConversationSignatureAction action);
	}
}
