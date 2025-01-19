using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class MobInfo : IMessage<MobInfo>, IMessage, IEquatable<MobInfo>, IDeepCloneable<MobInfo>
	{
		private static readonly MessageParser<MobInfo> _parser;

		public const int SpawnBuffsFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_spawnBuffs_codec;

		private readonly RepeatedField<long> spawnBuffs_;

		public const int SpawnTriggersFieldNumber = 2;

		private static readonly FieldCodec<long> _repeated_spawnTriggers_codec;

		private readonly RepeatedField<long> spawnTriggers_;

		public const int LevelFieldNumber = 3;

		private int level_;

		public const int CurTypeFieldNumber = 4;

		private int curType_;

		public const int CampFieldNumber = 5;

		private int camp_;

		public const int IDFieldNumber = 6;

		private long iD_;

		public const int ChannelGroupFieldNumber = 7;

		private int channelGroup_;

		public const int MobKindFieldNumber = 8;

		private int mobKind_;

		public const int ModelFieldNumber = 9;

		private string model_;

		public const int BehaviorPatternsFieldNumber = 10;

		private int behaviorPatterns_;

		public const int ProtogenesisFieldNumber = 11;

		private int protogenesis_;

		public const int ShadowFieldNumber = 12;

		private int shadow_;

		public const int BeSelectedFieldNumber = 13;

		private int beSelected_;

		public const int CanMoveFieldNumber = 14;

		private int canMove_;

		public const int CanTurnFieldNumber = 15;

		private int canTurn_;

		public const int FollowMasterFieldNumber = 16;

		private int followMaster_;

		public const int FollowDistanceFieldNumber = 17;

		private int followDistance_;

		public const int TurnBoneFieldNumber = 18;

		private string turnBone_;

		public const int CollideWithAgentFieldNumber = 19;

		private int collideWithAgent_;

		public const int ImmuneBlinkWhiteFieldNumber = 20;

		private int immuneBlinkWhite_;

		public const int LifeTimeFieldNumber = 21;

		private int lifeTime_;

		public const int InheritModeFieldNumber = 22;

		private int inheritMode_;

		public const int InheritTypeFieldNumber = 23;

		private string inheritType_;

		public const int SpawnPositionAdjustTypeFieldNumber = 24;

		private int spawnPositionAdjustType_;

		public const int MobTypeFieldNumber = 25;

		private int mobType_;

		public const int MobTypeInfoNormalFieldNumber = 26;

		private long mobTypeInfoNormal_;

		public const int MobTypeInfoEliteFieldNumber = 27;

		private long mobTypeInfoElite_;

		public const int MobTypeInfoBossFieldNumber = 28;

		private long mobTypeInfoBoss_;

		public const int MobStateTagFieldNumber = 29;

		private int mobStateTag_;

		public const int HpFieldNumber = 30;

		private int hp_;

		public const int PhysicalAttackFieldNumber = 31;

		private int physicalAttack_;

		public const int MagicalAttackFieldNumber = 32;

		private int magicalAttack_;

		public const int PhysicalDefenseFieldNumber = 33;

		private int physicalDefense_;

		public const int MagicalDefenseFieldNumber = 34;

		private int magicalDefense_;

		public const int HitFieldNumber = 35;

		private int hit_;

		public const int DodgeFieldNumber = 36;

		private int dodge_;

		public const int IgnorePhysicalDefenseFieldNumber = 37;

		private int ignorePhysicalDefense_;

		public const int IgnoreMagicalDefenseFieldNumber = 38;

		private int ignoreMagicalDefense_;

		public const int PhysicalCriticalFieldNumber = 39;

		private int physicalCritical_;

		public const int MagicalCriticalFieldNumber = 40;

		private int magicalCritical_;

		public const int PhysicalCriticalMultiFieldNumber = 41;

		private int physicalCriticalMulti_;

		public const int MagicalCriticalMultiFieldNumber = 42;

		private int magicalCriticalMulti_;

		public const int CombatConstTypeFieldNumber = 43;

		private int combatConstType_;

		public const int SummonMob1FieldNumber = 44;

		private long summonMob1_;

		public const int SummonMob2FieldNumber = 45;

		private long summonMob2_;

		public const int SummonMob3FieldNumber = 46;

		private long summonMob3_;

		public const int SummonNum1FieldNumber = 47;

		private int summonNum1_;

		public const int SummonNum2FieldNumber = 48;

		private int summonNum2_;

		public const int SummonNum3FieldNumber = 49;

		private int summonNum3_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MobInfo> Parser
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
		public RepeatedField<long> SpawnBuffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> SpawnTriggers
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
		public int CurType
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
		public int Camp
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
		public int ChannelGroup
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
		public int MobKind
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
		public string Model
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
		public int BehaviorPatterns
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
		public int Protogenesis
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
		public int Shadow
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
		public int BeSelected
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
		public int CanMove
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
		public int CanTurn
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
		public int FollowMaster
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
		public int FollowDistance
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
		public string TurnBone
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
		public int CollideWithAgent
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
		public int ImmuneBlinkWhite
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
		public int LifeTime
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
		public int InheritMode
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
		public string InheritType
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
		public int SpawnPositionAdjustType
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
		public int MobType
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
		public long MobTypeInfoNormal
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
		public long MobTypeInfoElite
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
		public long MobTypeInfoBoss
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
		public int MobStateTag
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
		public int Hp
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
		public int PhysicalAttack
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
		public int MagicalAttack
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
		public int PhysicalDefense
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
		public int MagicalDefense
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
		public int Hit
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
		public int Dodge
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
		public int IgnorePhysicalDefense
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
		public int IgnoreMagicalDefense
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
		public int PhysicalCritical
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
		public int MagicalCritical
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
		public int PhysicalCriticalMulti
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
		public int MagicalCriticalMulti
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
		public int CombatConstType
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
		public long SummonMob1
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
		public long SummonMob2
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
		public long SummonMob3
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
		public int SummonNum1
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
		public int SummonNum2
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
		public int SummonNum3
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
		public MobInfo()
		{
		}

		[DebuggerNonUserCode]
		public MobInfo(MobInfo other)
		{
		}

		[DebuggerNonUserCode]
		public MobInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MobInfo other)
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
		public void MergeFrom(MobInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
