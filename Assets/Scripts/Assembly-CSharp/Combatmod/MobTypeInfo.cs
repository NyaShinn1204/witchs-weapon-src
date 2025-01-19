using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class MobTypeInfo : IMessage<MobTypeInfo>, IMessage, IEquatable<MobTypeInfo>, IDeepCloneable<MobTypeInfo>
	{
		private static readonly MessageParser<MobTypeInfo> _parser;

		public const int IDFieldNumber = 1;

		private long iD_;

		public const int ChannelGroupFieldNumber = 2;

		private int channelGroup_;

		public const int BuffId1FieldNumber = 3;

		private long buffId1_;

		public const int BuffId2FieldNumber = 4;

		private long buffId2_;

		public const int BuffLayer1FieldNumber = 5;

		private int buffLayer1_;

		public const int BuffLayer2FieldNumber = 6;

		private int buffLayer2_;

		public const int AttributeTypeHpFieldNumber = 7;

		private int attributeTypeHp_;

		public const int AttributeTypeAttackFieldNumber = 8;

		private int attributeTypeAttack_;

		public const int AttributeTypeDefenseFieldNumber = 9;

		private int attributeTypeDefense_;

		public const int MultiHpFieldNumber = 10;

		private int multiHp_;

		public const int MultiAttackFieldNumber = 11;

		private int multiAttack_;

		public const int BehaviorTreeIdFieldNumber = 12;

		private long behaviorTreeId_;

		public const int FirstAttackIntervalLowerFieldNumber = 13;

		private int firstAttackIntervalLower_;

		public const int FirstAttackIntervalUpperFieldNumber = 14;

		private int firstAttackIntervalUpper_;

		public const int AttackIntervalLowerFieldNumber = 15;

		private int attackIntervalLower_;

		public const int AttackIntervalUpperFieldNumber = 16;

		private int attackIntervalUpper_;

		public const int MobSpell1FieldNumber = 17;

		private long mobSpell1_;

		public const int MobSpell2FieldNumber = 18;

		private long mobSpell2_;

		public const int MobSpell3FieldNumber = 19;

		private long mobSpell3_;

		public const int MobSpell4FieldNumber = 20;

		private long mobSpell4_;

		public const int MobSpell5FieldNumber = 21;

		private long mobSpell5_;

		public const int MobSpell6FieldNumber = 22;

		private long mobSpell6_;

		public const int MobSpell7FieldNumber = 23;

		private long mobSpell7_;

		public const int MobSpell8FieldNumber = 24;

		private long mobSpell8_;

		public const int MobSpell9FieldNumber = 25;

		private long mobSpell9_;

		public const int MobSpell10FieldNumber = 26;

		private long mobSpell10_;

		public const int Trigger1FieldNumber = 27;

		private long trigger1_;

		public const int Trigger2FieldNumber = 28;

		private long trigger2_;

		public const int Trigger3FieldNumber = 29;

		private long trigger3_;

		public const int Trigger4FieldNumber = 30;

		private long trigger4_;

		public const int Trigger5FieldNumber = 31;

		private long trigger5_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MobTypeInfo> Parser
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
		public long BuffId1
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
		public long BuffId2
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
		public int BuffLayer1
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
		public int BuffLayer2
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
		public int AttributeTypeHp
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
		public int AttributeTypeAttack
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
		public int AttributeTypeDefense
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
		public int MultiHp
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
		public int MultiAttack
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
		public long BehaviorTreeId
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
		public int FirstAttackIntervalLower
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
		public int FirstAttackIntervalUpper
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
		public int AttackIntervalLower
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
		public int AttackIntervalUpper
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
		public long MobSpell1
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
		public long MobSpell2
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
		public long MobSpell3
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
		public long MobSpell4
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
		public long MobSpell5
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
		public long MobSpell6
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
		public long MobSpell7
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
		public long MobSpell8
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
		public long MobSpell9
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
		public long MobSpell10
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
		public long Trigger1
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
		public long Trigger2
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
		public long Trigger3
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
		public long Trigger4
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
		public long Trigger5
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
		public MobTypeInfo()
		{
		}

		[DebuggerNonUserCode]
		public MobTypeInfo(MobTypeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public MobTypeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MobTypeInfo other)
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
		public void MergeFrom(MobTypeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
