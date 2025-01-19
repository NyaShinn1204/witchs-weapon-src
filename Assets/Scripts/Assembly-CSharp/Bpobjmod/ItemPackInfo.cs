using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class ItemPackInfo : IMessage<ItemPackInfo>, IMessage, IEquatable<ItemPackInfo>, IDeepCloneable<ItemPackInfo>
	{
		private static readonly MessageParser<ItemPackInfo> _parser;

		public const int ItemIDFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_itemID_codec;

		private readonly RepeatedField<long> itemID_;

		public const int ItemNumFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_itemNum_codec;

		private readonly RepeatedField<int> itemNum_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ItemPackInfo> Parser
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
		public RepeatedField<long> ItemID
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ItemNum
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ItemPackInfo()
		{
		}

		[DebuggerNonUserCode]
		public ItemPackInfo(ItemPackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public ItemPackInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ItemPackInfo other)
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
		public void MergeFrom(ItemPackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
