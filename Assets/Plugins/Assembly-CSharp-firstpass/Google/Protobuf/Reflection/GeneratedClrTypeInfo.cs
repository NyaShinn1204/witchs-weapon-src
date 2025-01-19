using System;

namespace Google.Protobuf.Reflection
{
	public sealed class GeneratedClrTypeInfo
	{
		private static readonly string[] EmptyNames;

		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo;

		public readonly MessageParser Parser;

		public readonly string[] PropertyNames;

		public readonly string[] OneofNames;

		public readonly GeneratedClrTypeInfo[] NestedTypes;

		public readonly Type[] NestedEnums;

		public Type ClrType { get; private set; }

		public GeneratedClrTypeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
		{
		}

		public GeneratedClrTypeInfo(Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
		{
		}
	}
}
