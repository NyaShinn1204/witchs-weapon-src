using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class TriggerInfo : IMessage<TriggerInfo>, IMessage, IEquatable<TriggerInfo>, IDeepCloneable<TriggerInfo>
	{
		private static readonly MessageParser<TriggerInfo> _parser;

		public const int LevelFieldNumber = 1;

		private int level_;

		public const int IDFieldNumber = 2;

		private long iD_;

		public const int TypeFieldNumber = 3;

		private int type_;

		public const int MaxTimesFieldNumber = 4;

		private int maxTimes_;

		public const int ActivateConditionFieldNumber = 5;

		private int activateCondition_;

		public const int ActivateConditionTargetTypeFieldNumber = 6;

		private int activateConditionTargetType_;

		public const int ActivateConditionTargetArgu1FieldNumber = 7;

		private long activateConditionTargetArgu1_;

		public const int ActivateConditionArgu1FieldNumber = 8;

		private long activateConditionArgu1_;

		public const int ActivateConditionArgu2FieldNumber = 9;

		private int activateConditionArgu2_;

		public const int ActivateConditionArgu3FieldNumber = 10;

		private int activateConditionArgu3_;

		public const int ActivateConditionArgu4FieldNumber = 11;

		private int activateConditionArgu4_;

		public const int ActivateConditionArgu5FieldNumber = 12;

		private int activateConditionArgu5_;

		public const int ActivateConditionArgu6FieldNumber = 13;

		private int activateConditionArgu6_;

		public const int ActivateConditionArgu7FieldNumber = 14;

		private int activateConditionArgu7_;

		public const int ActivateConditionArgu8FieldNumber = 15;

		private int activateConditionArgu8_;

		public const int ActivateCondition1FieldNumber = 16;

		private int activateCondition1_;

		public const int ActivateCondition1TargetTypeFieldNumber = 17;

		private int activateCondition1TargetType_;

		public const int ActivateCondition1TargetArgu1FieldNumber = 18;

		private long activateCondition1TargetArgu1_;

		public const int ActivateCondition1Argu1FieldNumber = 19;

		private long activateCondition1Argu1_;

		public const int ActivateCondition1Argu2FieldNumber = 20;

		private int activateCondition1Argu2_;

		public const int ActivateCondition1Argu3FieldNumber = 21;

		private int activateCondition1Argu3_;

		public const int ActivateCondition1Argu4FieldNumber = 22;

		private int activateCondition1Argu4_;

		public const int ActivateCondition1Argu5FieldNumber = 23;

		private int activateCondition1Argu5_;

		public const int ActivateCondition1Argu6FieldNumber = 24;

		private int activateCondition1Argu6_;

		public const int ActivateCondition1Argu7FieldNumber = 25;

		private int activateCondition1Argu7_;

		public const int ActivateCondition1Argu8FieldNumber = 26;

		private int activateCondition1Argu8_;

		public const int InactivateConditionFieldNumber = 27;

		private int inactivateCondition_;

		public const int InactivateConditionTargetTypeFieldNumber = 28;

		private int inactivateConditionTargetType_;

		public const int InactivateConditionTargetArgu1FieldNumber = 29;

		private long inactivateConditionTargetArgu1_;

		public const int InactivateConditionArgu1FieldNumber = 30;

		private long inactivateConditionArgu1_;

		public const int InactivateConditionArgu2FieldNumber = 31;

		private int inactivateConditionArgu2_;

		public const int InactivateConditionArgu3FieldNumber = 32;

		private int inactivateConditionArgu3_;

		public const int InactivateConditionArgu4FieldNumber = 33;

		private int inactivateConditionArgu4_;

		public const int InactivateConditionArgu5FieldNumber = 34;

		private int inactivateConditionArgu5_;

		public const int InactivateConditionArgu6FieldNumber = 35;

		private int inactivateConditionArgu6_;

		public const int InactivateConditionArgu7FieldNumber = 36;

		private int inactivateConditionArgu7_;

		public const int InactivateConditionArgu8FieldNumber = 37;

		private int inactivateConditionArgu8_;

		public const int InactivateCondition1FieldNumber = 38;

		private int inactivateCondition1_;

		public const int InactivateCondition1TargetTypeFieldNumber = 39;

		private int inactivateCondition1TargetType_;

		public const int InactivateCondition1TargetArgu1FieldNumber = 40;

		private long inactivateCondition1TargetArgu1_;

		public const int InactivateCondition1Argu1FieldNumber = 41;

		private long inactivateCondition1Argu1_;

		public const int InactivateCondition1Argu2FieldNumber = 42;

		private int inactivateCondition1Argu2_;

		public const int InactivateCondition1Argu3FieldNumber = 43;

		private int inactivateCondition1Argu3_;

		public const int InactivateCondition1Argu4FieldNumber = 44;

		private int inactivateCondition1Argu4_;

		public const int InactivateCondition1Argu5FieldNumber = 45;

		private int inactivateCondition1Argu5_;

		public const int InactivateCondition1Argu6FieldNumber = 46;

		private int inactivateCondition1Argu6_;

		public const int InactivateCondition1Argu7FieldNumber = 47;

		private int inactivateCondition1Argu7_;

		public const int InactivateCondition1Argu8FieldNumber = 48;

		private int inactivateCondition1Argu8_;

		public const int TimerStartConditionFieldNumber = 49;

		private int timerStartCondition_;

		public const int TimerStartConditionTargetTypeFieldNumber = 50;

		private int timerStartConditionTargetType_;

		public const int TimerStartConditionTargetArgu1FieldNumber = 51;

		private long timerStartConditionTargetArgu1_;

		public const int TimerStartConditionArgu1FieldNumber = 52;

		private long timerStartConditionArgu1_;

		public const int TimerStartConditionArgu2FieldNumber = 53;

		private int timerStartConditionArgu2_;

		public const int TimerStartConditionArgu3FieldNumber = 54;

		private int timerStartConditionArgu3_;

		public const int TimerStartConditionArgu4FieldNumber = 55;

		private int timerStartConditionArgu4_;

		public const int TimerStartConditionArgu5FieldNumber = 56;

		private int timerStartConditionArgu5_;

		public const int TimerStartConditionArgu6FieldNumber = 57;

		private int timerStartConditionArgu6_;

		public const int TimerStartConditionArgu7FieldNumber = 58;

		private int timerStartConditionArgu7_;

		public const int TimerStartConditionArgu8FieldNumber = 59;

		private int timerStartConditionArgu8_;

		public const int TimerPauseConditionFieldNumber = 60;

		private int timerPauseCondition_;

		public const int TimerPauseConditionTargetTypeFieldNumber = 61;

		private int timerPauseConditionTargetType_;

		public const int TimerPauseConditionTargetArgu1FieldNumber = 62;

		private long timerPauseConditionTargetArgu1_;

		public const int TimerPauseConditionArgu1FieldNumber = 63;

		private long timerPauseConditionArgu1_;

		public const int TimerPauseConditionArgu2FieldNumber = 64;

		private int timerPauseConditionArgu2_;

		public const int TimerPauseConditionArgu3FieldNumber = 65;

		private int timerPauseConditionArgu3_;

		public const int TimerPauseConditionArgu4FieldNumber = 66;

		private int timerPauseConditionArgu4_;

		public const int TimerPauseConditionArgu5FieldNumber = 67;

		private int timerPauseConditionArgu5_;

		public const int TimerPauseConditionArgu6FieldNumber = 68;

		private int timerPauseConditionArgu6_;

		public const int TimerPauseConditionArgu7FieldNumber = 69;

		private int timerPauseConditionArgu7_;

		public const int TimerPauseConditionArgu8FieldNumber = 70;

		private int timerPauseConditionArgu8_;

		public const int TimerStopConditionFieldNumber = 71;

		private int timerStopCondition_;

		public const int TimerStopConditionTargetTypeFieldNumber = 72;

		private int timerStopConditionTargetType_;

		public const int TimerStopConditionTargetArgu1FieldNumber = 73;

		private long timerStopConditionTargetArgu1_;

		public const int TimerStopConditionArgu1FieldNumber = 74;

		private long timerStopConditionArgu1_;

		public const int TimerStopConditionArgu2FieldNumber = 75;

		private int timerStopConditionArgu2_;

		public const int TimerStopConditionArgu3FieldNumber = 76;

		private int timerStopConditionArgu3_;

		public const int TimerStopConditionArgu4FieldNumber = 77;

		private int timerStopConditionArgu4_;

		public const int TimerStopConditionArgu5FieldNumber = 78;

		private int timerStopConditionArgu5_;

		public const int TimerStopConditionArgu6FieldNumber = 79;

		private int timerStopConditionArgu6_;

		public const int TimerStopConditionArgu7FieldNumber = 80;

		private int timerStopConditionArgu7_;

		public const int TimerStopConditionArgu8FieldNumber = 81;

		private int timerStopConditionArgu8_;

		public const int TimerTimeFieldNumber = 82;

		private int timerTime_;

		public const int TimerTimesFieldNumber = 83;

		private int timerTimes_;

		public const int RestrictPeriodFieldNumber = 84;

		private int restrictPeriod_;

		public const int RestrictNumFieldNumber = 85;

		private int restrictNum_;

		public const int TriggerConditionFieldNumber = 86;

		private int triggerCondition_;

		public const int TriggerConditionTargetTypeFieldNumber = 87;

		private int triggerConditionTargetType_;

		public const int TriggerConditionTargetArgu1FieldNumber = 88;

		private long triggerConditionTargetArgu1_;

		public const int TriggerConditionArgu1FieldNumber = 89;

		private long triggerConditionArgu1_;

		public const int TriggerConditionArgu2FieldNumber = 90;

		private int triggerConditionArgu2_;

		public const int TriggerConditionArgu3FieldNumber = 91;

		private int triggerConditionArgu3_;

		public const int TriggerConditionArgu4FieldNumber = 92;

		private int triggerConditionArgu4_;

		public const int TriggerConditionArgu5FieldNumber = 93;

		private int triggerConditionArgu5_;

		public const int TriggerConditionArgu6FieldNumber = 94;

		private int triggerConditionArgu6_;

		public const int TriggerConditionArgu7FieldNumber = 95;

		private int triggerConditionArgu7_;

		public const int TriggerConditionArgu8FieldNumber = 96;

		private int triggerConditionArgu8_;

		public const int TimesFieldNumber = 97;

		private int times_;

		public const int IsRateFieldNumber = 98;

		private int isRate_;

		public const int RateTypeFieldNumber = 99;

		private int rateType_;

		public const int RateFieldNumber = 100;

		private int rate_;

		public const int TriggerSureTimesFieldNumber = 101;

		private int triggerSureTimes_;

		public const int TriggerSureTimesTwoHandedFieldNumber = 102;

		private int triggerSureTimesTwoHanded_;

		public const int TriggerSureTimesSingleHandedFieldNumber = 103;

		private int triggerSureTimesSingleHanded_;

		public const int TriggerSureTimesDualWieldFieldNumber = 104;

		private int triggerSureTimesDualWield_;

		public const int SpellFieldNumber = 105;

		private long spell_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<TriggerInfo> Parser
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
		public int Type
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
		public int MaxTimes
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
		public int ActivateCondition
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
		public int ActivateConditionTargetType
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
		public long ActivateConditionTargetArgu1
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
		public long ActivateConditionArgu1
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
		public int ActivateConditionArgu2
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
		public int ActivateConditionArgu3
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
		public int ActivateConditionArgu4
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
		public int ActivateConditionArgu5
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
		public int ActivateConditionArgu6
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
		public int ActivateConditionArgu7
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
		public int ActivateConditionArgu8
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
		public int ActivateCondition1
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
		public int ActivateCondition1TargetType
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
		public long ActivateCondition1TargetArgu1
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
		public long ActivateCondition1Argu1
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
		public int ActivateCondition1Argu2
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
		public int ActivateCondition1Argu3
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
		public int ActivateCondition1Argu4
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
		public int ActivateCondition1Argu5
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
		public int ActivateCondition1Argu6
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
		public int ActivateCondition1Argu7
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
		public int ActivateCondition1Argu8
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
		public int InactivateCondition
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
		public int InactivateConditionTargetType
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
		public long InactivateConditionTargetArgu1
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
		public long InactivateConditionArgu1
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
		public int InactivateConditionArgu2
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
		public int InactivateConditionArgu3
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
		public int InactivateConditionArgu4
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
		public int InactivateConditionArgu5
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
		public int InactivateConditionArgu6
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
		public int InactivateConditionArgu7
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
		public int InactivateConditionArgu8
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
		public int InactivateCondition1
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
		public int InactivateCondition1TargetType
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
		public long InactivateCondition1TargetArgu1
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
		public long InactivateCondition1Argu1
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
		public int InactivateCondition1Argu2
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
		public int InactivateCondition1Argu3
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
		public int InactivateCondition1Argu4
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
		public int InactivateCondition1Argu5
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
		public int InactivateCondition1Argu6
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
		public int InactivateCondition1Argu7
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
		public int InactivateCondition1Argu8
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
		public int TimerStartCondition
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
		public int TimerStartConditionTargetType
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
		public long TimerStartConditionTargetArgu1
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
		public long TimerStartConditionArgu1
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
		public int TimerStartConditionArgu2
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
		public int TimerStartConditionArgu3
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
		public int TimerStartConditionArgu4
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
		public int TimerStartConditionArgu5
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
		public int TimerStartConditionArgu6
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
		public int TimerStartConditionArgu7
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
		public int TimerStartConditionArgu8
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
		public int TimerPauseCondition
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
		public int TimerPauseConditionTargetType
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
		public long TimerPauseConditionTargetArgu1
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
		public long TimerPauseConditionArgu1
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
		public int TimerPauseConditionArgu2
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
		public int TimerPauseConditionArgu3
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
		public int TimerPauseConditionArgu4
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
		public int TimerPauseConditionArgu5
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
		public int TimerPauseConditionArgu6
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
		public int TimerPauseConditionArgu7
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
		public int TimerPauseConditionArgu8
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
		public int TimerStopCondition
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
		public int TimerStopConditionTargetType
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
		public long TimerStopConditionTargetArgu1
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
		public long TimerStopConditionArgu1
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
		public int TimerStopConditionArgu2
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
		public int TimerStopConditionArgu3
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
		public int TimerStopConditionArgu4
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
		public int TimerStopConditionArgu5
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
		public int TimerStopConditionArgu6
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
		public int TimerStopConditionArgu7
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
		public int TimerStopConditionArgu8
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
		public int TimerTime
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
		public int TimerTimes
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
		public int RestrictPeriod
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
		public int RestrictNum
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
		public int TriggerCondition
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
		public int TriggerConditionTargetType
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
		public long TriggerConditionTargetArgu1
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
		public long TriggerConditionArgu1
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
		public int TriggerConditionArgu2
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
		public int TriggerConditionArgu3
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
		public int TriggerConditionArgu4
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
		public int TriggerConditionArgu5
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
		public int TriggerConditionArgu6
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
		public int TriggerConditionArgu7
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
		public int TriggerConditionArgu8
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
		public int Times
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
		public int IsRate
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
		public int RateType
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
		public int Rate
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
		public int TriggerSureTimes
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
		public int TriggerSureTimesTwoHanded
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
		public int TriggerSureTimesSingleHanded
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
		public int TriggerSureTimesDualWield
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
		public long Spell
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
		public TriggerInfo()
		{
		}

		[DebuggerNonUserCode]
		public TriggerInfo(TriggerInfo other)
		{
		}

		[DebuggerNonUserCode]
		public TriggerInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(TriggerInfo other)
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
		public void MergeFrom(TriggerInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
