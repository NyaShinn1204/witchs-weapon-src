using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Ratemod
{
	public sealed class RateTemplet : IMessage<RateTemplet>, IMessage, IEquatable<RateTemplet>, IDeepCloneable<RateTemplet>
	{
		private static readonly MessageParser<RateTemplet> _parser;

		public const int RateArrFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_rateArr_codec;

		private readonly RepeatedField<int> rateArr_;

		public const int FirstGroupFirstNumFieldNumber = 100;

		private int firstGroupFirstNum_;

		public const int TypeFieldNumber = 101;

		private int type_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RateTemplet> Parser
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
		public RepeatedField<int> RateArr
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int FirstGroupFirstNum
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
		public int Type
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
		public RateTemplet()
		{
		}

		[DebuggerNonUserCode]
		public RateTemplet(RateTemplet other)
		{
		}

		[DebuggerNonUserCode]
		public RateTemplet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RateTemplet other)
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
		public void MergeFrom(RateTemplet other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
