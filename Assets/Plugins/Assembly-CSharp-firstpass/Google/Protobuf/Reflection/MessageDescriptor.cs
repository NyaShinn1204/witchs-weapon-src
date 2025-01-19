using System;
using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class MessageDescriptor : DescriptorBase
	{
		public sealed class FieldCollection
		{
			private readonly MessageDescriptor messageDescriptor;

			public FieldDescriptor Item
			{
				get
				{
					return null;
				}
			}

			public FieldDescriptor Item
			{
				get
				{
					return null;
				}
			}

			internal FieldCollection(MessageDescriptor messageDescriptor)
			{
			}

			public IList<FieldDescriptor> InDeclarationOrder()
			{
				return null;
			}

			public IList<FieldDescriptor> InFieldNumberOrder()
			{
				return null;
			}

			internal IDictionary<string, FieldDescriptor> ByJsonName()
			{
				return null;
			}
		}

		private static readonly HashSet<string> WellKnownTypeNames;

		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

		private readonly IList<FieldDescriptor> fieldsInNumberOrder;

		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

		internal readonly DescriptorProto Proto;

		public readonly Type ClrType;

		public readonly MessageParser Parser;

		public readonly MessageDescriptor ContainingType;

		public readonly FieldCollection Fields;

		public readonly IList<MessageDescriptor> NestedTypes;

		public readonly IList<EnumDescriptor> EnumTypes;

		public readonly IList<OneofDescriptor> Oneofs;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal bool IsWellKnownType
		{
			get
			{
				return false;
			}
		}

		internal bool IsWrapperType
		{
			get
			{
				return false;
			}
		}

		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo)
			: base(null, null, 0)
		{
		}

		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields)
		{
			return null;
		}

		public FieldDescriptor FindFieldByName(string name)
		{
			return null;
		}

		public FieldDescriptor FindFieldByNumber(int number)
		{
			return null;
		}

		public T FindDescriptor<T>(string name) where T : class, IDescriptor
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}
