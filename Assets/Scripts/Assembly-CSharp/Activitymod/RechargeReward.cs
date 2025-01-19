using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class RechargeReward : IMessage<RechargeReward>, IMessage, IEquatable<RechargeReward>, IDeepCloneable<RechargeReward>
	{
		private static readonly MessageParser<RechargeReward> _parser;

		public const int RechargeFieldNumber = 1;

		private long recharge_;

		public const int RechargeCanReceiveTagFieldNumber = 2;

		private int rechargeCanReceiveTag_;

		public const int RechargeRewardTagFieldNumber = 3;

		private int rechargeRewardTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RechargeReward> Parser
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
		public long Recharge
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
		public int RechargeCanReceiveTag
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
		public int RechargeRewardTag
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
		public RechargeReward()
		{
		}

		[DebuggerNonUserCode]
		public RechargeReward(RechargeReward other)
		{
		}

		[DebuggerNonUserCode]
		public RechargeReward Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RechargeReward other)
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
		public void MergeFrom(RechargeReward other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
