using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public class LeanEngineSignatureFactory : ISignatureFactory
	{
		public Task<AVIMSignature> CreateConnectSignature(string clientId)
		{
			return null;
		}

		public Task<AVIMSignature> CreateStartConversationSignature(string clientId, IEnumerable<string> targetIds)
		{
			return null;
		}

		public Task<AVIMSignature> CreateConversationSignature(string conversationId, string clientId, IEnumerable<string> targetIds, ConversationSignatureAction action)
		{
			return null;
		}
	}
}
