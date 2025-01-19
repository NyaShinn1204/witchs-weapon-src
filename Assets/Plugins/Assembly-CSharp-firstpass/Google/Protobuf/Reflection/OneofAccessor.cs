using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	public sealed class OneofAccessor
	{
		private readonly Func<IMessage, int> caseDelegate;

		private readonly Action<IMessage> clearDelegate;

		private OneofDescriptor descriptor;

		public OneofDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
		{
		}

		public void Clear(IMessage message)
		{
		}

		public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
		{
			return null;
		}
	}
}
