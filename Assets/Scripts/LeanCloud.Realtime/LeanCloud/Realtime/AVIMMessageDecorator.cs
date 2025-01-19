using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public abstract class AVIMMessageDecorator : AVIMTypedMessage
	{
		public AVIMTypedMessage Message { get; set; }

		public virtual IDictionary<string, object> MessageContent { get; set; }

		protected AVIMMessageDecorator(AVIMTypedMessage message)
		{
		}

		public virtual IDictionary<string, object> EncodeDecorated()
		{
			return null;
		}

		public override IDictionary<string, object> Encode()
		{
			return null;
		}

		public abstract IDictionary<string, object> EncodeDecorator();
	}
}
