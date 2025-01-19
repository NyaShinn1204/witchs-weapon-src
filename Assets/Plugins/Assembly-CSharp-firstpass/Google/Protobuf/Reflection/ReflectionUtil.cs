using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal static class ReflectionUtil
	{
		internal static readonly Type[] EmptyTypes;

		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			return null;
		}

		internal static Func<IMessage, T> CreateFuncIMessageT<T>(MethodInfo method)
		{
			return null;
		}

		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			return null;
		}

		internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			return null;
		}
	}
}
