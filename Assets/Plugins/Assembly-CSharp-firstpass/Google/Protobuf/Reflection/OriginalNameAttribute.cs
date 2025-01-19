using System;

namespace Google.Protobuf.Reflection
{
	public class OriginalNameAttribute : Attribute
	{
		public string Name { get; set; }

		public OriginalNameAttribute(string name)
		{
		}
	}
}
