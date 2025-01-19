using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>
	{
		public enum KindOneofCase
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}

		private static readonly MessageParser<Value> _parser;

		public const int NullValueFieldNumber = 1;

		public const int NumberValueFieldNumber = 2;

		public const int StringValueFieldNumber = 3;

		public const int BoolValueFieldNumber = 4;

		public const int StructValueFieldNumber = 5;

		public const int ListValueFieldNumber = 6;

		private object kind_;

		private KindOneofCase kindCase_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Value> Parser
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
		public NullValue NullValue
		{
			get
			{
				return default(NullValue);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double NumberValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string StringValue
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
		public bool BoolValue
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
		public Struct StructValue
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
		public ListValue ListValue
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
		public KindOneofCase KindCase
		{
			get
			{
				return default(KindOneofCase);
			}
		}

		[DebuggerNonUserCode]
		public Value()
		{
		}

		[DebuggerNonUserCode]
		public Value(Value other)
		{
		}

		[DebuggerNonUserCode]
		public Value Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void ClearKind()
		{
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Value other)
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
		public void MergeFrom(Value other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public static Value ForString(string value)
		{
			return null;
		}

		public static Value ForNumber(double value)
		{
			return null;
		}

		public static Value ForBool(bool value)
		{
			return null;
		}

		public static Value ForNull()
		{
			return null;
		}

		public static Value ForList(params Value[] values)
		{
			return null;
		}

		public static Value ForStruct(Struct value)
		{
			return null;
		}
	}
}
