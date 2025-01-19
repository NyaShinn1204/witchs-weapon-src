using System;
using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumDescriptor : DescriptorBase
	{
		private readonly EnumDescriptorProto proto;

		private readonly MessageDescriptor containingType;

		private readonly IList<EnumValueDescriptor> values;

		private readonly Type clrType;

		internal EnumDescriptorProto Proto
		{
			get
			{
				return null;
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public Type ClrType
		{
			get
			{
				return null;
			}
		}

		public MessageDescriptor ContainingType
		{
			get
			{
				return null;
			}
		}

		public IList<EnumValueDescriptor> Values
		{
			get
			{
				return null;
			}
		}

		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType)
			: base(null, null, 0)
		{
		}

		public EnumValueDescriptor FindValueByNumber(int number)
		{
			return null;
		}

		public EnumValueDescriptor FindValueByName(string name)
		{
			return null;
		}
	}
}
