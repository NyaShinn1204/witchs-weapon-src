using System;

namespace LeanCloud.Realtime
{
	public sealed class AVIMMessageFieldNameAttribute : Attribute
	{
		public string FieldName { get; private set; }

		public AVIMMessageFieldNameAttribute(string fieldName)
		{
		}
	}
}
