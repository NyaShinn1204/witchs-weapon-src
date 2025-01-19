using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Activitymod
{
	public sealed class ActivityInstance : IMessage<ActivityInstance>, IMessage, IEquatable<ActivityInstance>, IDeepCloneable<ActivityInstance>
	{
		private static readonly MessageParser<ActivityInstance> _parser;

		public const int RechargeFieldNumber = 1;

		private long recharge_;

		public const int RechargeRewardFieldNumber = 2;

		private Lootmod.LootResult rechargeReward_;

		public const int RechargeRewardIntimeTagFieldNumber = 3;

		private int rechargeRewardIntimeTag_;

		public const int RechargeIntimeTimeFieldNumber = 4;

		private long rechargeIntimeTime_;

		public const int RechargeRewardIntimeFieldNumber = 5;

		private Lootmod.LootResult rechargeRewardIntime_;

		public const int ParticipationRewardTagFieldNumber = 6;

		private int participationRewardTag_;

		public const int ParticipationRewardFieldNumber = 7;

		private Lootmod.LootResult participationReward_;

		public const int DaysSignRewardTagFieldNumber = 8;

		private int daysSignRewardTag_;

		public const int DaysSignTimeFieldNumber = 9;

		private long daysSignTime_;

		public const int RechargeAccumulationTagFieldNumber = 10;

		private int rechargeAccumulationTag_;

		public const int RechargeAccumulationRewardFieldNumber = 11;

		private Lootmod.LootResult rechargeAccumulationReward_;

		public const int RechargeRewardIntimeCanReceiveTagFieldNumber = 12;

		private int rechargeRewardIntimeCanReceiveTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ActivityInstance> Parser
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
		public Lootmod.LootResult RechargeReward
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
		public int RechargeRewardIntimeTag
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
		public long RechargeIntimeTime
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
		public Lootmod.LootResult RechargeRewardIntime
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
		public int ParticipationRewardTag
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
		public Lootmod.LootResult ParticipationReward
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
		public int DaysSignRewardTag
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
		public long DaysSignTime
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
		public int RechargeAccumulationTag
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
		public Lootmod.LootResult RechargeAccumulationReward
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
		public int RechargeRewardIntimeCanReceiveTag
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
		public ActivityInstance()
		{
		}

		[DebuggerNonUserCode]
		public ActivityInstance(ActivityInstance other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityInstance other)
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
		public void MergeFrom(ActivityInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
