using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection
{
	internal sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum Type
			{
				Double = 1,
				Float = 2,
				Int64 = 3,
				Uint64 = 4,
				Int32 = 5,
				Fixed64 = 6,
				Fixed32 = 7,
				Bool = 8,
				String = 9,
				Group = 10,
				Message = 11,
				Bytes = 12,
				Uint32 = 13,
				Enum = 14,
				Sfixed32 = 15,
				Sfixed64 = 16,
				Sint32 = 17,
				Sint64 = 18
			}

			internal enum Label
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int LabelFieldNumber = 4;

		private Types.Label label_;

		public const int TypeFieldNumber = 5;

		private Types.Type type_;

		public const int TypeNameFieldNumber = 6;

		private string typeName_;

		public const int ExtendeeFieldNumber = 2;

		private string extendee_;

		public const int DefaultValueFieldNumber = 7;

		private string defaultValue_;

		public const int OneofIndexFieldNumber = 9;

		private int oneofIndex_;

		public const int JsonNameFieldNumber = 10;

		private string jsonName_;

		public const int OptionsFieldNumber = 8;

		private FieldOptions options_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FieldDescriptorProto> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Types.Label Label
		{
			get
			{
				return default(Types.Label);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Types.Type Type
		{
			get
			{
				return default(Types.Type);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string TypeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Extendee
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int OneofIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string JsonName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public FieldOptions Options
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto(FieldDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldDescriptorProto other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FieldDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		private void OnConstruction()
		{
		}
	}
}
