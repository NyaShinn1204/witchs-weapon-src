using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>
	{
		private static readonly MessageParser<Struct> _parser;

		public const int FieldsFieldNumber = 1;

		private static readonly MapField<string, Value>.Codec _map_fields_codec;

		private readonly MapField<string, Value> fields_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Struct> Parser
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
		public MapField<string, Value> Fields
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Struct()
		{
		}

		[DebuggerNonUserCode]
		public Struct(Struct other)
		{
		}

		[DebuggerNonUserCode]
		public Struct Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Struct other)
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
		public void MergeFrom(Struct other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
