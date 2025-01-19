using System;

namespace LeanCloud
{
	public sealed class AVClassNameAttribute : Attribute
	{
		public string ClassName { get; private set; }

		public AVClassNameAttribute(string className)
		{
		}
	}
}
