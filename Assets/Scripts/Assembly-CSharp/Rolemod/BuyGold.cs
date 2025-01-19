using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class BuyGold : IMessage<BuyGold>, IMessage, IEquatable<BuyGold>, IDeepCloneable<BuyGold>
	{
		private static readonly MessageParser<BuyGold> _parser;

		public const int MultiFieldNumber = 1;

		private int multi_;

		public const int ExtraInfoFieldNumber = 2;

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
		public static MessageParser<BuyGold> Parser
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
		public int Multi
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
		public BuyGold()
		{
		}

		[DebuggerNonUserCode]
		public BuyGold(BuyGold other)
		{
		}

		[DebuggerNonUserCode]
		public BuyGold Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BuyGold other)
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
		public void MergeFrom(BuyGold other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
