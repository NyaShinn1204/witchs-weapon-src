using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Shopmod
{
	public sealed class BuyResult : IMessage<BuyResult>, IMessage, IEquatable<BuyResult>, IDeepCloneable<BuyResult>
	{
		private static readonly MessageParser<BuyResult> _parser;

		public const int ResultFieldNumber = 1;

		private string result_;

		public const int OrderInfoFieldNumber = 2;

		private string orderInfo_;

		public const int ExtraInfoFieldNumber = 4;

		private ExtraInfo extraInfo_;

		public const int LootsFieldNumber = 5;

		private static readonly FieldCodec<LootObject> _repeated_loots_codec;

		private readonly RepeatedField<LootObject> loots_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<BuyResult> Parser
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
		public string Result
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
		public string OrderInfo
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
		public ExtraInfo ExtraInfo
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
		public RepeatedField<LootObject> Loots
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public BuyResult()
		{
		}

		[DebuggerNonUserCode]
		public BuyResult(BuyResult other)
		{
		}

		[DebuggerNonUserCode]
		public BuyResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BuyResult other)
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
		public void MergeFrom(BuyResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
