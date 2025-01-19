using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Realtime.Internal;

namespace LeanCloud.Realtime
{
	public class AVIMConversationQuery : AVQueryPair<AVIMConversationQuery, AVIMConversation>, IAVQuery
	{
		private bool compact;

		private bool withLastMessageRefreshed;

		internal AVIMClient CurrentClient { get; set; }

		internal AVIMConversationQuery(AVIMClient _currentClient)
		{
		}

		private AVIMConversationQuery(AVIMConversationQuery source, IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
		}

		public override AVIMConversationQuery CreateInstance(IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
			return null;
		}

		public AVIMConversationQuery WithLastMessageRefreshed(bool enabled)
		{
			return null;
		}

		public AVIMConversationQuery Compact(bool enabled)
		{
			return null;
		}

		internal ConversationCommand GenerateQueryCommand()
		{
			return null;
		}

		public override Task<int> CountAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<IEnumerable<AVIMConversation>> FindAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<AVIMConversation> FirstAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<AVIMConversation> FirstOrDefaultAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<AVIMConversation> GetAsync(string objectId, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
