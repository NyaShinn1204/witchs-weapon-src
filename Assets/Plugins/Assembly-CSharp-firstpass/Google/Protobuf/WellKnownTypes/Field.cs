using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Kind
			{
				TypeUnknown = 0,
				TypeDouble = 1,
				TypeFloat = 2,
				TypeInt64 = 3,
				TypeUint64 = 4,
				TypeInt32 = 5,
				TypeFixed64 = 6,
				TypeFixed32 = 7,
				TypeBool = 8,
				TypeString = 9,
				TypeGroup = 10,
				TypeMessage = 11,
				TypeBytes = 12,
				TypeUint32 = 13,
				TypeEnum = 14,
				TypeSfixed32 = 15,
				TypeSfixed64 = 16,
				TypeSint32 = 17,
				TypeSint64 = 18
			}

			public enum Cardinality
			{
				Unknown = 0,
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}

		private static readonly MessageParser<Field> _parser;

		public const int KindFieldNumber = 1;

		private Types.Kind kind_;

		public const int CardinalityFieldNumber = 2;

		private Types.Cardinality cardinality_;

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int NameFieldNumber = 4;

		private string name_;

		public const int TypeUrlFieldNumber = 6;

		private string typeUrl_;

		public const int OneofIndexFieldNumber = 7;

		private int oneofIndex_;

		public const int PackedFieldNumber = 8;

		private bool packed_;

		public const int OptionsFieldNumber = 9;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		public const int JsonNameFieldNumber = 10;

		private string jsonName_;

		public const int DefaultValueFieldNumber = 11;

		private string defaultValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Field> Parser
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
		public Types.Kind Kind
		{
			get
			{
				return default(Types.Kind);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Types.Cardinality Cardinality
		{
			get
			{
				return default(Types.Cardinality);
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
		public string TypeUrl
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
		public bool Packed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			get
			{
				return null;
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
		public Field()
		{
		}

		[DebuggerNonUserCode]
		public Field(Field other)
		{
		}

		[DebuggerNonUserCode]
		public Field Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Field other)
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
		public void MergeFrom(Field other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
