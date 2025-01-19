using System;

namespace Google.Protobuf.Reflection
{
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		private EnumDescriptor enumType;

		private MessageDescriptor messageType;

		private FieldType fieldType;

		private readonly string propertyName;

		private IFieldAccessor accessor;

		public readonly MessageDescriptor ContainingType;

		public readonly OneofDescriptor ContainingOneof;

		public readonly string JsonName;

		internal readonly FieldDescriptorProto Proto;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public IFieldAccessor Accessor
		{
			get
			{
				return null;
			}
		}

		public bool IsRepeated
		{
			get
			{
				return false;
			}
		}

		public bool IsMap
		{
			get
			{
				return false;
			}
		}

		public bool IsPacked
		{
			get
			{
				return false;
			}
		}

		public FieldType FieldType
		{
			get
			{
				return default(FieldType);
			}
		}

		public int FieldNumber
		{
			get
			{
				return 0;
			}
		}

		public EnumDescriptor EnumType
		{
			get
			{
				return null;
			}
		}

		public MessageDescriptor MessageType
		{
			get
			{
				return null;
			}
		}

		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName)
			: base(null, null, 0)
		{
		}

		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			return default(FieldType);
		}

		public int CompareTo(FieldDescriptor other)
		{
			return 0;
		}

		internal void CrossLink()
		{
		}

		private IFieldAccessor CreateAccessor()
		{
			return null;
		}
	}
}
