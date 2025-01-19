using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class SingleFieldAccessor : FieldAccessorBase
	{
		private readonly Action<IMessage, object> setValueDelegate;

		private readonly Action<IMessage> clearDelegate;

		internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
			: base(null, null)
		{
		}

		public override void Clear(IMessage message)
		{
		}

		public override void SetValue(IMessage message, object value)
		{
		}
	}
}
