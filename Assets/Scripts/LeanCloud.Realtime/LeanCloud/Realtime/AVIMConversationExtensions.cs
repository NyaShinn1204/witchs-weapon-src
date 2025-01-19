using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LeanCloud.Realtime
{
	public static class AVIMConversationExtensions
	{
		public static Task SendAsync(this AVIMConversation conversation, IAVIMMessage message, AVIMSendOptions options)
		{
			return null;
		}

		public static Task<T> SendAsync<T>(this AVIMConversation conversation, T message, AVIMSendOptions options) where T : IAVIMMessage
		{
			return null;
		}

		public static Task<T> SendAsync<T>(this AVIMConversation conversation, T message) where T : IAVIMMessage
		{
			return null;
		}

		public static Task<AVIMTextMessage> SendTextAsync(this AVIMConversation conversation, string text)
		{
			return null;
		}

		public static Task<AVIMImageMessage> SendImageAsync(this AVIMConversation conversation, string url, string name = null, string textTitle = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMImageMessage> SendImageAsync(this AVIMConversation conversation, string fileName, Stream data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMImageMessage> SendImageAsync(this AVIMConversation conversation, string fileName, byte[] data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMAudioMessage> SendAudioAsync(this AVIMConversation conversation, string url, string name = null, string textTitle = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMAudioMessage> SendAudioAsync(this AVIMConversation conversation, string fileName, Stream data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMAudioMessage> SendAudioAsync(this AVIMConversation conversation, string fileName, byte[] data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMVideoMessage> SendVideoAsync(this AVIMConversation conversation, string url, string name = null, string textTitle = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMVideoMessage> SendVideoAsync(this AVIMConversation conversation, string fileName, Stream data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<AVIMVideoMessage> SendVideoAsync(this AVIMConversation conversation, string fileName, byte[] data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null)
		{
			return null;
		}

		public static Task<T> SendFileMessageAsync<T>(this AVIMConversation conversation, string url, string name = null, string textTitle = null, IDictionary<string, object> customAttributes = null) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public static Task<T> SendFileMessageAsync<T>(this AVIMConversation conversation, string fileName, Stream data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public static Task<T> SendFileMessageAsync<T>(this AVIMConversation conversation, string fileName, byte[] data, string mimeType = null, string textTitle = null, IDictionary<string, object> metaData = null, IDictionary<string, object> customAttributes = null) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public static Task SendLocationAsync(this AVIMConversation conversation, AVGeoPoint point)
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageAsync(this AVIMConversation conversation, string beforeMessageId = null, string afterMessageId = null, long? beforeTimeStamp = null, long? afterTimeStamp = null, int direction = 1, int limit = 20)
		{
			return null;
		}

		public static Task<IEnumerable<T>> QueryMessageAsync<T>(this AVIMConversation conversation, string beforeMessageId = null, string afterMessageId = null, long? beforeTimeStamp = null, long? afterTimeStamp = null, int direction = 1, int limit = 20) where T : IAVIMMessage
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageBeforeAsync(this AVIMConversation conversation, IAVIMMessage message, int limit = 20)
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageAfterAsync(this AVIMConversation conversation, IAVIMMessage message, int limit = 20)
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageFromOldToNewAsync(this AVIMConversation conversation, int limit = 20)
		{
			return null;
		}

		public static Task<IEnumerable<IAVIMMessage>> QueryMessageInIntervalAsync(this AVIMConversation conversation, IAVIMMessage start, IAVIMMessage end, int limit = 20)
		{
			return null;
		}

		public static Task<AVIMRecalledMessage> RecallAsync(this AVIMConversation conversation, IAVIMMessage message)
		{
			return null;
		}

		public static Task<IAVIMMessage> UpdateAsync(this AVIMConversation conversation, IAVIMMessage oldMessage, IAVIMMessage newMessage)
		{
			return null;
		}
	}
}
