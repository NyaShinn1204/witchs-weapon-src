using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Resourcemod
{
	public sealed class RecycleInstance : IMessage<RecycleInstance>, IMessage, IEquatable<RecycleInstance>, IDeepCloneable<RecycleInstance>
	{
		private static readonly MessageParser<RecycleInstance> _parser;

		public const int RecycleItemFieldNumber = 1;

		private static readonly FieldCodec<RecycleItem> _repeated_recycleItem_codec;

		private readonly RepeatedField<RecycleItem> recycleItem_;

		public const int TotalPriceFieldNumber = 100;

		private int totalPrice_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RecycleInstance> Parser
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
		public RepeatedField<RecycleItem> RecycleItem
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TotalPrice
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
		public RecycleInstance()
		{
		}

		[DebuggerNonUserCode]
		public RecycleInstance(RecycleInstance other)
		{
		}

		[DebuggerNonUserCode]
		public RecycleInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RecycleInstance other)
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
		public void MergeFrom(RecycleInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
