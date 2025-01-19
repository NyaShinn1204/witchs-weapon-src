using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public class AVIMMessageEmitterBuilder
	{
		private AVIMConversation _conversation;

		private AVIMSendOptions _sendOptions;

		private IAVIMMessage _message;

		public AVIMConversation Conversation
		{
			get
			{
				return null;
			}
		}

		public AVIMSendOptions SendOptions
		{
			get
			{
				return default(AVIMSendOptions);
			}
		}

		public IAVIMMessage Message
		{
			get
			{
				return null;
			}
		}

		public AVIMMessageEmitterBuilder SetConversation(AVIMConversation conversation)
		{
			return null;
		}

		public AVIMMessageEmitterBuilder SetSendOptions(AVIMSendOptions sendOptions)
		{
			return null;
		}

		public AVIMMessageEmitterBuilder SetMessage(IAVIMMessage message)
		{
			return null;
		}

		public Task SendAsync()
		{
			return null;
		}
	}
}
