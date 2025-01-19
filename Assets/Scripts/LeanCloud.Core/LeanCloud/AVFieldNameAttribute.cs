using System;

namespace LeanCloud
{
	public sealed class AVFieldNameAttribute : Attribute
	{
		public string FieldName { get; private set; }

		public AVFieldNameAttribute(string fieldName)
		{
		}
	}
}
