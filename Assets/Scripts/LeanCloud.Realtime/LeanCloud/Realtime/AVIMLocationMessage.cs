using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMLocationMessage : AVIMMessageDecorator
	{
		public AVGeoPoint Location { get; set; }

		public AVIMLocationMessage()
			: base(null)
		{
		}

		public AVIMLocationMessage(AVGeoPoint location)
			: base(null)
		{
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
