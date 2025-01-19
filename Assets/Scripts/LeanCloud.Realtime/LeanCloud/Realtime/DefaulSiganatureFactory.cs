using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	internal class DefaulSiganatureFactory : ISignatureFactory
	{
		Task<AVIMSignature> ISignatureFactory.CreateConnectSignature(string clientId)
		{
			return null;
		}

		Task<AVIMSignature> ISignatureFactory.CreateConversationSignature(string conversationId, string clientId, IEnumerable<string> targetIds, ConversationSignatureAction action)
		{
			return null;
		}

		Task<AVIMSignature> ISignatureFactory.CreateStartConversationSignature(string clientId, IEnumerable<string> targetIds)
		{
			return null;
		}
	}
}
