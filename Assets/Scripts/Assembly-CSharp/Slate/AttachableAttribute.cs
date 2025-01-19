using System;

namespace Slate
{
	public class AttachableAttribute : Attribute
	{
		public Type[] types;

		public AttachableAttribute(params Type[] types)
		{
		}
	}
}
