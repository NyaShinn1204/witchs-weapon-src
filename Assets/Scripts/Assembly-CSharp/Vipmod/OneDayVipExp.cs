using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Vipmod
{
	public sealed class OneDayVipExp : IMessage<OneDayVipExp>, IMessage, IEquatable<OneDayVipExp>, IDeepCloneable<OneDayVipExp>
	{
		private static readonly MessageParser<OneDayVipExp> _parser;

		public const int ExpFieldNumber = 1;

		private int exp_;

		public const int ExpBySourceFieldNumber = 2;

		private static readonly FieldCodec<VipExp> _repeated_expBySource_codec;

		private readonly RepeatedField<VipExp> expBySource_;

		public const int TodayExpireVipExpFieldNumber = 3;

		private int todayExpireVipExp_;

		public const int ExpExpiredFieldNumber = 4;

		private bool expExpired_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<OneDayVipExp> Parser
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
		public int Exp
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
		public RepeatedField<VipExp> ExpBySource
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TodayExpireVipExp
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
		public bool ExpExpired
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
		public OneDayVipExp()
		{
		}

		[DebuggerNonUserCode]
		public OneDayVipExp(OneDayVipExp other)
		{
		}

		[DebuggerNonUserCode]
		public OneDayVipExp Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(OneDayVipExp other)
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
		public void MergeFrom(OneDayVipExp other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
