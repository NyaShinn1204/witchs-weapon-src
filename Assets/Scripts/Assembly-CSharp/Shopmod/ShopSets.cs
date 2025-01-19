using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class ShopSets : IMessage<ShopSets>, IMessage, IEquatable<ShopSets>, IDeepCloneable<ShopSets>
	{
		private static readonly MessageParser<ShopSets> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<ShopSet> _repeated_data_codec;

		private readonly RepeatedField<ShopSet> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ShopSets> Parser
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
		public RepeatedField<ShopSet> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ShopSets()
		{
		}

		[DebuggerNonUserCode]
		public ShopSets(ShopSets other)
		{
		}

		[DebuggerNonUserCode]
		public ShopSets Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ShopSets other)
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
		public void MergeFrom(ShopSets other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
