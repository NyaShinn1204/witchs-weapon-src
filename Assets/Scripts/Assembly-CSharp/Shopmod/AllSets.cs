using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class AllSets : IMessage<AllSets>, IMessage, IEquatable<AllSets>, IDeepCloneable<AllSets>
	{
		private static readonly MessageParser<AllSets> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<SetInfo> _repeated_data_codec;

		private readonly RepeatedField<SetInfo> data_;

		public const int CanPayFieldNumber = 2;

		private bool canPay_;

		public const int GoodsRMBBoughtFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_goodsRMBBought_codec;

		private readonly RepeatedField<long> goodsRMBBought_;

		public const int GoodsRMBTimesFieldNumber = 4;

		private long goodsRMBTimes_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AllSets> Parser
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
		public RepeatedField<SetInfo> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool CanPay
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
		public RepeatedField<long> GoodsRMBBought
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long GoodsRMBTimes
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public AllSets()
		{
		}

		[DebuggerNonUserCode]
		public AllSets(AllSets other)
		{
		}

		[DebuggerNonUserCode]
		public AllSets Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AllSets other)
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
		public void MergeFrom(AllSets other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
