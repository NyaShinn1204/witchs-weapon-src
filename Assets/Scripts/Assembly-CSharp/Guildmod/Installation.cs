using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class Installation : IMessage<Installation>, IMessage, IEquatable<Installation>, IDeepCloneable<Installation>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Buff : IMessage<Buff>, IMessage, IEquatable<Buff>, IDeepCloneable<Buff>
			{
				private static readonly MessageParser<Buff> _parser;

				public const int Buff_FieldNumber = 1;

				private int buff_;

				public const int VatalityFieldNumber = 2;

				private int vatality_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Buff> Parser
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
				public int Buff_
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
				public int Vatality
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
				public Buff()
				{
				}

				[DebuggerNonUserCode]
				public Buff(Buff other)
				{
				}

				[DebuggerNonUserCode]
				public Buff Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Buff other)
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
				public void MergeFrom(Buff other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<Installation> _parser;

		public const int VitalityMaxFieldNumber = 1;

		private int vitalityMax_;

		public const int PopulationMaxFieldNumber = 2;

		private int populationMax_;

		public const int ManagerMaxFieldNumber = 3;

		private int managerMax_;

		public const int MercenaryMaxFieldNumber = 4;

		private int mercenaryMax_;

		public const int MercenaryRewardHFieldNumber = 5;

		private int mercenaryRewardH_;

		public const int UsedRewardFieldNumber = 6;

		private int usedReward_;

		public const int RewardMaxFieldNumber = 7;

		private int rewardMax_;

		public const int UsedRewardDailyMaxFieldNumber = 17;

		private int usedRewardDailyMax_;

		public const int DonateDiamondFieldNumber = 8;

		private int donateDiamond_;

		public const int Diamond2VitalityFieldNumber = 9;

		private int diamond2Vitality_;

		public const int Diamond2GCoinFieldNumber = 10;

		private int diamond2GCoin_;

		public const int DonateGoldFieldNumber = 11;

		private int donateGold_;

		public const int Gold2VitalityFieldNumber = 12;

		private int gold2Vitality_;

		public const int Gold2GCoinFieldNumber = 13;

		private int gold2GCoin_;

		public const int DonateDailyFieldNumber = 14;

		private int donateDaily_;

		public const int ShopIDFieldNumber = 15;

		private long shopID_;

		public const int BuffsFieldNumber = 16;

		private static readonly FieldCodec<Types.Buff> _repeated_buffs_codec;

		private readonly RepeatedField<Types.Buff> buffs_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Installation> Parser
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
		public int VitalityMax
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
		public int PopulationMax
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
		public int ManagerMax
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
		public int MercenaryMax
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
		public int MercenaryRewardH
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
		public int UsedReward
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
		public int RewardMax
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
		public int UsedRewardDailyMax
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
		public int DonateDiamond
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
		public int Diamond2Vitality
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
		public int Diamond2GCoin
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
		public int DonateGold
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
		public int Gold2Vitality
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
		public int Gold2GCoin
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
		public int DonateDaily
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
		public long ShopID
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
		public RepeatedField<Types.Buff> Buffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Installation()
		{
		}

		[DebuggerNonUserCode]
		public Installation(Installation other)
		{
		}

		[DebuggerNonUserCode]
		public Installation Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Installation other)
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
		public void MergeFrom(Installation other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
