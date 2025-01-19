using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class BuffInfo : IMessage<BuffInfo>, IMessage, IEquatable<BuffInfo>, IDeepCloneable<BuffInfo>
	{
		private static readonly MessageParser<BuffInfo> _parser;

		public const int LevelFieldNumber = 1;

		private int level_;

		public const int LayerFieldNumber = 2;

		private int layer_;

		public const int IDFieldNumber = 3;

		private long iD_;

		public const int BuffTempletIdFieldNumber = 4;

		private string buffTempletId_;

		public const int BuffPrefabAddFieldNumber = 5;

		private long buffPrefabAdd_;

		public const int BuffPrefabLoopFieldNumber = 6;

		private long buffPrefabLoop_;

		public const int BuffPrefabTickFieldNumber = 7;

		private long buffPrefabTick_;

		public const int BuffPrefabEndFieldNumber = 8;

		private long buffPrefabEnd_;

		public const int ModelChangeFieldNumber = 9;

		private string modelChange_;

		public const int BuffGroupFieldNumber = 10;

		private string buffGroup_;

		public const int BuffTypeFieldNumber = 11;

		private int buffType_;

		public const int IsPositiveFieldNumber = 12;

		private int isPositive_;

		public const int MaxDurationFieldNumber = 13;

		private int maxDuration_;

		public const int AddConditionFieldNumber = 14;

		private int addCondition_;

		public const int InterruptTypeFieldNumber = 15;

		private int interruptType_;

		public const int InterruptedByHitFieldNumber = 16;

		private int interruptedByHit_;

		public const int InterruptedByAttackFieldNumber = 17;

		private int interruptedByAttack_;

		public const int InterruptedByDamageFieldNumber = 18;

		private int interruptedByDamage_;

		public const int InterruptedByPlayerNormalAttackFieldNumber = 19;

		private int interruptedByPlayerNormalAttack_;

		public const int InterruptedByHpForwardThresholdFieldNumber = 20;

		private int interruptedByHpForwardThreshold_;

		public const int InterruptedByHpBackwardThresholdFieldNumber = 21;

		private int interruptedByHpBackwardThreshold_;

		public const int BuffTypeTagFieldNumber = 22;

		private int buffTypeTag_;

		public const int ReplaceTypeFieldNumber = 23;

		private int replaceType_;

		public const int ReplaceLevelFieldNumber = 24;

		private int replaceLevel_;

		public const int StackTypeFieldNumber = 25;

		private int stackType_;

		public const int MaxStackFieldNumber = 26;

		private int maxStack_;

		public const int TickTypeFieldNumber = 27;

		private int tickType_;

		public const int PeriodicTimeFieldNumber = 28;

		private int periodicTime_;

		public const int TickInactiveOutOfBattleFieldNumber = 29;

		private int tickInactiveOutOfBattle_;

		public const int BuffScriptIdFieldNumber = 30;

		private string buffScriptId_;

		public const int BuffEffectArguFieldNumber = 31;

		private long buffEffectArgu_;

		public const int BuffTriggerTickFieldNumber = 32;

		private long buffTriggerTick_;

		public const int BuffTriggerInterruptFieldNumber = 33;

		private long buffTriggerInterrupt_;

		public const int BuffTriggerSublayerFieldNumber = 34;

		private long buffTriggerSublayer_;

		public const int BuffTriggerEndFieldNumber = 35;

		private long buffTriggerEnd_;

		public const int TriggerRatePerLayerFieldNumber = 36;

		private int triggerRatePerLayer_;

		public const int AttachedBuff1FieldNumber = 37;

		private long attachedBuff1_;

		public const int AttachedBuff2FieldNumber = 38;

		private long attachedBuff2_;

		public const int AttachedBuff3FieldNumber = 39;

		private long attachedBuff3_;

		public const int BuffTrigger1FieldNumber = 40;

		private long buffTrigger1_;

		public const int BuffTrigger2FieldNumber = 41;

		private long buffTrigger2_;

		public const int BuffTrigger3FieldNumber = 42;

		private long buffTrigger3_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<BuffInfo> Parser
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
		public int Layer
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
		public string BuffTempletId
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
		public long BuffPrefabAdd
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
		public long BuffPrefabLoop
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
		public long BuffPrefabTick
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
		public long BuffPrefabEnd
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
		public string ModelChange
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
		public string BuffGroup
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
		public int BuffType
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
		public int IsPositive
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
		public int MaxDuration
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
		public int AddCondition
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
		public int InterruptType
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
		public int InterruptedByHit
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
		public int InterruptedByAttack
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
		public int InterruptedByDamage
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
		public int InterruptedByPlayerNormalAttack
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
		public int InterruptedByHpForwardThreshold
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
		public int InterruptedByHpBackwardThreshold
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
		public int BuffTypeTag
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
		public int ReplaceType
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
		public int ReplaceLevel
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
		public int StackType
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
		public int MaxStack
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
		public int TickType
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
		public int PeriodicTime
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
		public int TickInactiveOutOfBattle
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
		public string BuffScriptId
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
		public long BuffEffectArgu
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
		public long BuffTriggerTick
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
		public long BuffTriggerInterrupt
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
		public long BuffTriggerSublayer
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
		public long BuffTriggerEnd
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
		public int TriggerRatePerLayer
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
		public long AttachedBuff1
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
		public long AttachedBuff2
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
		public long AttachedBuff3
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
		public long BuffTrigger1
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
		public long BuffTrigger2
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
		public long BuffTrigger3
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
		public BuffInfo()
		{
		}

		[DebuggerNonUserCode]
		public BuffInfo(BuffInfo other)
		{
		}

		[DebuggerNonUserCode]
		public BuffInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BuffInfo other)
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
		public void MergeFrom(BuffInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
