using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Svmod;

namespace Apmod
{
	public sealed class ActivityGameInstance : IMessage<ActivityGameInstance>, IMessage, IEquatable<ActivityGameInstance>, IDeepCloneable<ActivityGameInstance>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Mercenary : IMessage<Mercenary>, IMessage, IEquatable<Mercenary>, IDeepCloneable<Mercenary>
			{
				private static readonly MessageParser<Mercenary> _parser;

				public const int ServantInstanceProtoFieldNumber = 1;

				private static readonly FieldCodec<ServantInstanceProto> _repeated_servantInstanceProto_codec;

				private readonly RepeatedField<ServantInstanceProto> servantInstanceProto_;

				public const int WeaponInstanceFieldNumber = 2;

				private static readonly FieldCodec<WeaponInstance> _repeated_weaponInstance_codec;

				private readonly RepeatedField<WeaponInstance> weaponInstance_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Mercenary> Parser
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
				public RepeatedField<ServantInstanceProto> ServantInstanceProto
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public RepeatedField<WeaponInstance> WeaponInstance
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public Mercenary()
				{
				}

				[DebuggerNonUserCode]
				public Mercenary(Mercenary other)
				{
				}

				[DebuggerNonUserCode]
				public Mercenary Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Mercenary other)
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
				public void MergeFrom(Mercenary other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<ActivityGameInstance> _parser;

		public const int IsOpenFieldNumber = 1;

		private bool isOpen_;

		public const int SerialFieldNumber = 2;

		private int serial_;

		public const int ActivityStaminaInitFieldNumber = 3;

		private bool activityStaminaInit_;

		public const int ActivityStaminaDailyFieldNumber = 4;

		private bool activityStaminaDaily_;

		public const int LastResetTimeFieldNumber = 5;

		private long lastResetTime_;

		public const int TotalCurrencyFieldNumber = 6;

		private long totalCurrency_;

		public const int TotalCombatFieldNumber = 7;

		private long totalCombat_;

		public const int LootBuffNumFieldNumber = 8;

		private int lootBuffNum_;

		public const int AccSetFieldNumber = 9;

		private AccSet accSet_;

		public const int UnlockStoryFieldNumber = 10;

		private bool unlockStory_;

		public const int MercenaryInfoFieldNumber = 11;

		private Types.Mercenary mercenaryInfo_;

		public const int ActOpenFieldNumber = 12;

		private bool actOpen_;

		public const int ConsumedStaminaFieldNumber = 13;

		private long consumedStamina_;

		public const int ActivityCurrencyBonusMailedSerialFieldNumber = 14;

		private int activityCurrencyBonusMailedSerial_;

		public const int TendencyPoolFieldNumber = 15;

		private static readonly FieldCodec<int> _repeated_tendencyPool_codec;

		private readonly RepeatedField<int> tendencyPool_;

		public const int AttributePointMaxFieldNumber = 16;

		private int attributePointMax_;

		public const int AttributePointNowFieldNumber = 17;

		private int attributePointNow_;

		public const int AttributeLevelFieldNumber = 18;

		private static readonly FieldCodec<int> _repeated_attributeLevel_codec;

		private readonly RepeatedField<int> attributeLevel_;

		public const int AttributeLastRestFieldNumber = 19;

		private long attributeLastRest_;

		public const int AttrResetCountFieldNumber = 20;

		private int attrResetCount_;

		public const int DelayOpenFieldNumber = 21;

		private bool delayOpen_;

		public const int TotalCurrency2FieldNumber = 22;

		private long totalCurrency2_;

		public const int TotalCombat2FieldNumber = 23;

		private long totalCombat2_;

		public const int ConsumedStamina2FieldNumber = 24;

		private long consumedStamina2_;

		public const int ActivityScoreBonusMailedSerialFieldNumber = 25;

		private int activityScoreBonusMailedSerial_;

		public const int TotalBattleScoreFieldNumber = 26;

		private int totalBattleScore_;

		public const int BattleScoresFieldNumber = 27;

		private static readonly FieldCodec<int> _repeated_battleScores_codec;

		private readonly RepeatedField<int> battleScores_;

		public const int TotalBattleScore2FieldNumber = 28;

		private int totalBattleScore2_;

		public const int BattleScores2FieldNumber = 29;

		private static readonly FieldCodec<int> _repeated_battleScores2_codec;

		private readonly RepeatedField<int> battleScores2_;

		public const int ActivityScoreBonusMailedSerial2FieldNumber = 30;

		private int activityScoreBonusMailedSerial2_;

		public const int TotalBattleScore3FieldNumber = 31;

		private int totalBattleScore3_;

		public const int BattleScores3FieldNumber = 32;

		private static readonly FieldCodec<int> _repeated_battleScores3_codec;

		private readonly RepeatedField<int> battleScores3_;

		public const int ActivityScoreBonusMailedSerial3FieldNumber = 33;

		private int activityScoreBonusMailedSerial3_;

		public const int FirstEnterFieldNumber = 34;

		private static readonly MapField<long, bool>.Codec _map_firstEnter_codec;

		private readonly MapField<long, bool> firstEnter_;

		public const int ExtraInfoFieldNumber = 100;

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
		public static MessageParser<ActivityGameInstance> Parser
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
		public bool IsOpen
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
		public int Serial
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
		public bool ActivityStaminaInit
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
		public bool ActivityStaminaDaily
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
		public long LastResetTime
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
		public long TotalCurrency
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
		public long TotalCombat
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
		public int LootBuffNum
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
		public AccSet AccSet
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
		public bool UnlockStory
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
		public Types.Mercenary MercenaryInfo
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
		public bool ActOpen
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
		public long ConsumedStamina
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
		public int ActivityCurrencyBonusMailedSerial
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
		public RepeatedField<int> TendencyPool
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int AttributePointMax
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
		public int AttributePointNow
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
		public RepeatedField<int> AttributeLevel
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long AttributeLastRest
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
		public int AttrResetCount
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
		public bool DelayOpen
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
		public long TotalCurrency2
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
		public long TotalCombat2
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
		public long ConsumedStamina2
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
		public int ActivityScoreBonusMailedSerial
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
		public int TotalBattleScore
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
		public RepeatedField<int> BattleScores
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TotalBattleScore2
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
		public RepeatedField<int> BattleScores2
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int ActivityScoreBonusMailedSerial2
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
		public int TotalBattleScore3
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
		public RepeatedField<int> BattleScores3
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int ActivityScoreBonusMailedSerial3
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
		public MapField<long, bool> FirstEnter
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
		public ActivityGameInstance()
		{
		}

		[DebuggerNonUserCode]
		public ActivityGameInstance(ActivityGameInstance other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityGameInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityGameInstance other)
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
		public void MergeFrom(ActivityGameInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
