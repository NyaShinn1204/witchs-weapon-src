using System.Collections.Generic;
using System.IO;

namespace LeanCloud.Realtime
{
	public class AVIMFileMessage : AVIMMessageDecorator
	{
		public AVFile File { get; set; }

		public AVIMFileMessage()
			: base(null)
		{
		}

		public AVIMFileMessage(AVIMTypedMessage message)
			: base(null)
		{
		}

		public static T FromUrl<T>(string url) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public static T FromUrl<T>(string fileName, string externalUrl, string textTitle, IDictionary<string, object> customAttributes = null) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public static T FromStream<T>(string fileName, Stream data, string mimeType, string textTitle, IDictionary<string, object> metaData, IDictionary<string, object> customAttributes = null) where T : AVIMFileMessage, new()
		{
			return null;
		}

		public override IDictionary<string, object> EncodeDecorator()
		{
			return null;
		}

		public override IAVIMMessage Deserialize(string msgStr)
		{
			return null;
		}
	}
}
