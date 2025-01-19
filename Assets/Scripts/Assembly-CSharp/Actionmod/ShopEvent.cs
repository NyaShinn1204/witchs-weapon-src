using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class ShopEvent : IMessage<ShopEvent>, IMessage, IEquatable<ShopEvent>, IDeepCloneable<ShopEvent>
	{
		private static readonly MessageParser<ShopEvent> _parser;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int ValueFieldNumber = 2;

		private static readonly FieldCodec<long> _repeated_value_codec;

		private readonly RepeatedField<long> value_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ShopEvent> Parser
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
		public RepeatedField<long> Value
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ShopEvent()
		{
		}

		[DebuggerNonUserCode]
		public ShopEvent(ShopEvent other)
		{
		}

		[DebuggerNonUserCode]
		public ShopEvent Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ShopEvent other)
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
		public void MergeFrom(ShopEvent other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
