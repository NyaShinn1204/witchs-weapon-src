using System;

namespace LeanCloud.Realtime
{
	public sealed class AVIMMessageClassNameAttribute : Attribute
	{
		public string ClassName { get; private set; }

		public AVIMMessageClassNameAttribute(string className)
		{
		}
	}
}
