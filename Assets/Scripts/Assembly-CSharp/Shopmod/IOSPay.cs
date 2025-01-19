using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Shopmod
{
	public sealed class IOSPay : IMessage<IOSPay>, IMessage, IEquatable<IOSPay>, IDeepCloneable<IOSPay>
	{
		private static readonly MessageParser<IOSPay> _parser;

		public const int ResultFieldNumber = 1;

		private int result_;

		public const int TransactionIDFieldNumber = 2;

		private string transactionID_;

		public const int LootsFieldNumber = 3;

		private static readonly FieldCodec<LootObject> _repeated_loots_codec;

		private readonly RepeatedField<LootObject> loots_;

		public const int ExtraInfoFieldNumber = 4;

		private ExtraInfo extraInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<IOSPay> Parser
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
		public int Result
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
		public string TransactionID
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
		public IOSPay()
		{
		}

		[DebuggerNonUserCode]
		public IOSPay(IOSPay other)
		{
		}

		[DebuggerNonUserCode]
		public IOSPay Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(IOSPay other)
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
		public void MergeFrom(IOSPay other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
