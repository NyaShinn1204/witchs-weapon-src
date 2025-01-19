using System;

namespace LeanCloud.Realtime
{
	public sealed class AVIMTypedMessageTypeIntAttribute : Attribute
	{
		public int TypeInteger { get; private set; }

		public AVIMTypedMessageTypeIntAttribute(int typeInt)
		{
		}
	}
}
