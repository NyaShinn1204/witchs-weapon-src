using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class SetData : IMessage<SetData>, IMessage, IEquatable<SetData>, IDeepCloneable<SetData>
	{
		private static readonly MessageParser<SetData> _parser;

		public const int SetsFieldNumber = 1;

		private static readonly FieldCodec<Set> _repeated_sets_codec;

		private readonly RepeatedField<Set> sets_;

		public const int GoodsRMBBoughtFieldNumber = 2;

		private static readonly FieldCodec<long> _repeated_goodsRMBBought_codec;

		private readonly RepeatedField<long> goodsRMBBought_;

		public const int GoodsRMBTimesFieldNumber = 3;

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
		public static MessageParser<SetData> Parser
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
		public RepeatedField<Set> Sets
		{
			get
			{
				return null;
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
		public SetData()
		{
		}

		[DebuggerNonUserCode]
		public SetData(SetData other)
		{
		}

		[DebuggerNonUserCode]
		public SetData Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SetData other)
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
		public void MergeFrom(SetData other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
