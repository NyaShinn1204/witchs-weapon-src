using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class SpellInfo : IMessage<SpellInfo>, IMessage, IEquatable<SpellInfo>, IDeepCloneable<SpellInfo>
	{
		private static readonly MessageParser<SpellInfo> _parser;

		public const int LevelFieldNumber = 1;

		private int level_;

		public const int IDFieldNumber = 2;

		private long iD_;

		public const int SpellTempletIdFieldNumber = 3;

		private string spellTempletId_;

		public const int SpellPriorityFieldNumber = 4;

		private int spellPriority_;

		public const int HasSpecialAnimationFieldNumber = 5;

		private int hasSpecialAnimation_;

		public const int CanPushFieldNumber = 6;

		private int canPush_;

		public const int NormalAttackTimePerHitFieldNumber = 7;

		private int normalAttackTimePerHit_;

		public const int SpellTypeFieldNumber = 8;

		private int spellType_;

		public const int IsAttributeTypeFieldNumber = 9;

		private int isAttributeType_;

		public const int AttributeType1FieldNumber = 10;

		private int attributeType1_;

		public const int AttributeProportionValue1FieldNumber = 11;

		private int attributeProportionValue1_;

		public const int AttributeInitValue1FieldNumber = 12;

		private int attributeInitValue1_;

		public const int AttributeGrowValue1FieldNumber = 13;

		private int attributeGrowValue1_;

		public const int AttributeType2FieldNumber = 14;

		private int attributeType2_;

		public const int AttributeProportionValue2FieldNumber = 15;

		private int attributeProportionValue2_;

		public const int AttributeInitValue2FieldNumber = 16;

		private int attributeInitValue2_;

		public const int AttributeGrowValue2FieldNumber = 17;

		private int attributeGrowValue2_;

		public const int AttributeType3FieldNumber = 18;

		private int attributeType3_;

		public const int AttributeProportionValue3FieldNumber = 19;

		private int attributeProportionValue3_;

		public const int AttributeInitValue3FieldNumber = 20;

		private int attributeInitValue3_;

		public const int AttributeGrowValue3FieldNumber = 21;

		private int attributeGrowValue3_;

		public const int SpellCanCastTagFieldNumber = 22;

		private int spellCanCastTag_;

		public const int SpellTypeTagFieldNumber = 23;

		private int spellTypeTag_;

		public const int SpellScriptIdFieldNumber = 24;

		private string spellScriptId_;

		public const int TargetTypeTrueFieldNumber = 25;

		private int targetTypeTrue_;

		public const int TargetTypeTrue1FieldNumber = 26;

		private int targetTypeTrue1_;

		public const int TargetTypeNominalFieldNumber = 27;

		private int targetTypeNominal_;

		public const int TargetArgu1FieldNumber = 28;

		private int targetArgu1_;

		public const int TargetArgu2FieldNumber = 29;

		private int targetArgu2_;

		public const int TargetArgu3FieldNumber = 30;

		private int targetArgu3_;

		public const int TargetArgu4FieldNumber = 31;

		private int targetArgu4_;

		public const int TargetArgu5FieldNumber = 32;

		private int targetArgu5_;

		public const int DistanceTypeFieldNumber = 33;

		private int distanceType_;

		public const int MaxDistanceCastFieldNumber = 34;

		private int maxDistanceCast_;

		public const int MaxDistanceFieldNumber = 35;

		private int maxDistance_;

		public const int SpellRangeCenterTypeFieldNumber = 36;

		private int spellRangeCenterType_;

		public const int SpellRangeTypeFieldNumber = 37;

		private int spellRangeType_;

		public const int RangeArgu1FieldNumber = 38;

		private int rangeArgu1_;

		public const int RangeArgu2FieldNumber = 39;

		private int rangeArgu2_;

		public const int RangeArgu3FieldNumber = 40;

		private int rangeArgu3_;

		public const int RangeArgu4FieldNumber = 41;

		private int rangeArgu4_;

		public const int WarningRangeTimeFieldNumber = 42;

		private int warningRangeTime_;

		public const int FacetoTargetFieldNumber = 43;

		private int facetoTarget_;

		public const int ChargeTimeFieldNumber = 44;

		private int chargeTime_;

		public const int LoadingTimeFieldNumber = 45;

		private int loadingTime_;

		public const int ChargeInterruptSelfFieldNumber = 46;

		private int chargeInterruptSelf_;

		public const int ChargeInterruptTargetFieldNumber = 47;

		private int chargeInterruptTarget_;

		public const int ChargeBlinkFieldNumber = 48;

		private int chargeBlink_;

		public const int ChargeCanTurnFieldNumber = 49;

		private int chargeCanTurn_;

		public const int ChargePrefabStartFieldNumber = 50;

		private string chargePrefabStart_;

		public const int SpecialAnimationFieldNumber = 51;

		private string specialAnimation_;

		public const int DriveByAnimationFieldNumber = 52;

		private int driveByAnimation_;

		public const int ChannelTimeFieldNumber = 53;

		private int channelTime_;

		public const int ChannelCanTurnFieldNumber = 54;

		private int channelCanTurn_;

		public const int ChannelCanMoveFieldNumber = 55;

		private int channelCanMove_;

		public const int ChannelInterruptSelfFieldNumber = 56;

		private int channelInterruptSelf_;

		public const int ChannelInterruptTargetFieldNumber = 57;

		private int channelInterruptTarget_;

		public const int ChannelPrefabStartFieldNumber = 58;

		private string channelPrefabStart_;

		public const int ChannelPrefabEndFieldNumber = 59;

		private string channelPrefabEnd_;

		public const int SpellDFieldNumber = 60;

		private int spellD_;

		public const int SpellEffectArguFieldNumber = 61;

		private long spellEffectArgu_;

		public const int SpellSpell1FieldNumber = 62;

		private long spellSpell1_;

		public const int SpellSpell2FieldNumber = 63;

		private long spellSpell2_;

		public const int SpellSpell3FieldNumber = 64;

		private long spellSpell3_;

		public const int SpellSpell4FieldNumber = 65;

		private long spellSpell4_;

		public const int SpellSpell5FieldNumber = 66;

		private long spellSpell5_;

		public const int SpellBuff1FieldNumber = 67;

		private long spellBuff1_;

		public const int SpellBuff2FieldNumber = 68;

		private long spellBuff2_;

		public const int SpellBuff3FieldNumber = 69;

		private long spellBuff3_;

		public const int SpellSummon1FieldNumber = 70;

		private long spellSummon1_;

		public const int SpellSummon2FieldNumber = 71;

		private long spellSummon2_;

		public const int SpellAgent1FieldNumber = 72;

		private long spellAgent1_;

		public const int SpellAgent2FieldNumber = 73;

		private long spellAgent2_;

		public const int CombatScoreBaseValueFieldNumber = 74;

		private int combatScoreBaseValue_;

		public const int CombatScoreGrowValueFieldNumber = 75;

		private int combatScoreGrowValue_;

		public const int HitEffectsFieldNumber = 76;

		private long hitEffects_;

		public const int LinkSpell1FieldNumber = 77;

		private long linkSpell1_;

		public const int LinkSpell2FieldNumber = 78;

		private long linkSpell2_;

		public const int LinkSpell3FieldNumber = 79;

		private long linkSpell3_;

		public const int LinkSpell4FieldNumber = 80;

		private long linkSpell4_;

		public const int LinkSpell5FieldNumber = 81;

		private long linkSpell5_;

		public const int LinkSpell6FieldNumber = 82;

		private long linkSpell6_;

		public const int LinkSpell7FieldNumber = 83;

		private long linkSpell7_;

		public const int LinkSpell8FieldNumber = 84;

		private long linkSpell8_;

		public const int LinkSpell9FieldNumber = 85;

		private long linkSpell9_;

		public const int LinkSpell10FieldNumber = 86;

		private long linkSpell10_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SpellInfo> Parser
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
		public int Level
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
		public long ID
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
		public string SpellTempletId
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
		public int SpellPriority
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
		public int HasSpecialAnimation
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
		public int CanPush
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
		public int NormalAttackTimePerHit
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
		public int SpellType
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
		public int IsAttributeType
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
		public int AttributeType1
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
		public int AttributeProportionValue1
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
		public int AttributeInitValue1
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
		public int AttributeGrowValue1
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
		public int AttributeType2
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
		public int AttributeProportionValue2
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
		public int AttributeInitValue2
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
		public int AttributeGrowValue2
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
		public int AttributeType3
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
		public int AttributeProportionValue3
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
		public int AttributeInitValue3
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
		public int AttributeGrowValue3
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
		public int SpellCanCastTag
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
		public int SpellTypeTag
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
		public string SpellScriptId
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
		public int TargetTypeTrue
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
		public int TargetTypeTrue1
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
		public int TargetTypeNominal
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
		public int TargetArgu1
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
		public int TargetArgu2
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
		public int TargetArgu3
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
		public int TargetArgu4
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
		public int TargetArgu5
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
		public int DistanceType
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
		public int MaxDistanceCast
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
		public int MaxDistance
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
		public int SpellRangeCenterType
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
		public int SpellRangeType
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
		public int RangeArgu1
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
		public int RangeArgu2
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
		public int RangeArgu3
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
		public int RangeArgu4
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
		public int WarningRangeTime
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
		public int FacetoTarget
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
		public int ChargeTime
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
		public int LoadingTime
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
		public int ChargeInterruptSelf
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
		public int ChargeInterruptTarget
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
		public int ChargeBlink
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
		public int ChargeCanTurn
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
		public string ChargePrefabStart
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
		public string SpecialAnimation
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
		public int DriveByAnimation
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
		public int ChannelTime
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
		public int ChannelCanTurn
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
		public int ChannelCanMove
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
		public int ChannelInterruptSelf
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
		public int ChannelInterruptTarget
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
		public string ChannelPrefabStart
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
		public string ChannelPrefabEnd
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
		public int SpellD
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
		public long SpellEffectArgu
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
		public long SpellSpell1
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
		public long SpellSpell2
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
		public long SpellSpell3
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
		public long SpellSpell4
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
		public long SpellSpell5
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
		public long SpellBuff1
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
		public long SpellBuff2
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
		public long SpellBuff3
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
		public long SpellSummon1
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
		public long SpellSummon2
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
		public long SpellAgent1
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
		public long SpellAgent2
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
		public int CombatScoreBaseValue
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
		public int CombatScoreGrowValue
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
		public long HitEffects
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
		public long LinkSpell1
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
		public long LinkSpell2
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
		public long LinkSpell3
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
		public long LinkSpell4
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
		public long LinkSpell5
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
		public long LinkSpell6
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
		public long LinkSpell7
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
		public long LinkSpell8
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
		public long LinkSpell9
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
		public long LinkSpell10
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
		public SpellInfo()
		{
		}

		[DebuggerNonUserCode]
		public SpellInfo(SpellInfo other)
		{
		}

		[DebuggerNonUserCode]
		public SpellInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SpellInfo other)
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
		public void MergeFrom(SpellInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
