using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Logmod
{
	public sealed class LogInstance : IMessage<LogInstance>, IMessage, IEquatable<LogInstance>, IDeepCloneable<LogInstance>
	{
		private static readonly MessageParser<LogInstance> _parser;

		public const int ChallengeTimesFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_challengeTimes_codec;

		private readonly RepeatedField<int> challengeTimes_;

		public const int RechargeFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_recharge_codec;

		private readonly RepeatedField<int> recharge_;

		public const int RechargeTimeFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_rechargeTime_codec;

		private readonly RepeatedField<long> rechargeTime_;

		public const int RechargeGoodsFieldNumber = 4;

		private static readonly FieldCodec<long> _repeated_rechargeGoods_codec;

		private readonly RepeatedField<long> rechargeGoods_;

		public const int DrawResultFieldNumber = 5;

		private static readonly MapField<long, DrawResult>.Codec _map_drawResult_codec;

		private readonly MapField<long, DrawResult> drawResult_;

		public const int TotalRMBFieldNumber = 100;

		private int totalRMB_;

		public const int TodayRMBFieldNumber = 101;

		private int todayRMB_;

		public const int TotalLoginDaysFieldNumber = 102;

		private int totalLoginDays_;

		public const int TotalLoginTimesFieldNumber = 103;

		private int totalLoginTimes_;

		public const int LastLoginTimeFieldNumber = 104;

		private long lastLoginTime_;

		public const int RegisterTimeFieldNumber = 105;

		private long registerTime_;

		public const int TodayLoginTimesFieldNumber = 106;

		private int todayLoginTimes_;

		public const int TodayRMBUsedFieldNumber = 107;

		private bool todayRMBUsed_;

		public const int TotalRMBUsedUnitsFieldNumber = 108;

		private int totalRMBUsedUnits_;

		public const int TotalLoginDaysUsedUnitsFieldNumber = 109;

		private int totalLoginDaysUsedUnits_;

		public const int TotalLoginTimesUsedUnitsFieldNumber = 110;

		private int totalLoginTimesUsedUnits_;

		public const int TotalGoldDrawTimesFieldNumber = 111;

		private int totalGoldDrawTimes_;

		public const int TotalRmbDrawTimesFieldNumber = 112;

		private int totalRmbDrawTimes_;

		public const int TotalActDrawTimesFieldNumber = 113;

		private int totalActDrawTimes_;

		public const int Record1FieldNumber = 114;

		private long record1_;

		public const int Record2FieldNumber = 115;

		private long record2_;

		public const int Record3FieldNumber = 116;

		private long record3_;

		public const int Record4FieldNumber = 117;

		private long record4_;

		public const int Record5FieldNumber = 118;

		private long record5_;

		public const int Record6FieldNumber = 119;

		private long record6_;

		public const int Record7FieldNumber = 120;

		private long record7_;

		public const int Record8FieldNumber = 121;

		private long record8_;

		public const int Record9FieldNumber = 122;

		private long record9_;

		public const int Record10FieldNumber = 123;

		private long record10_;

		public const int Record11FieldNumber = 124;

		private long record11_;

		public const int Record12FieldNumber = 125;

		private long record12_;

		public const int Record13FieldNumber = 126;

		private long record13_;

		public const int Record14FieldNumber = 127;

		private long record14_;

		public const int Record15FieldNumber = 128;

		private long record15_;

		public const int Record16FieldNumber = 129;

		private long record16_;

		public const int Record17FieldNumber = 130;

		private long record17_;

		public const int Record18FieldNumber = 131;

		private long record18_;

		public const int Record19FieldNumber = 132;

		private long record19_;

		public const int Record20FieldNumber = 133;

		private long record20_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LogInstance> Parser
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
		public RepeatedField<int> ChallengeTimes
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Recharge
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> RechargeTime
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> RechargeGoods
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, DrawResult> DrawResult
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TotalRMB
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
		public int TodayRMB
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
		public int TotalLoginDays
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
		public int TotalLoginTimes
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
		public long LastLoginTime
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
		public long RegisterTime
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
		public int TodayLoginTimes
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
		public bool TodayRMBUsed
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
		public int TotalRMBUsedUnits
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
		public int TotalLoginDaysUsedUnits
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
		public int TotalLoginTimesUsedUnits
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
		public int TotalGoldDrawTimes
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
		public int TotalRmbDrawTimes
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
		public int TotalActDrawTimes
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
		public long Record1
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
		public long Record2
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
		public long Record3
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
		public long Record4
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
		public long Record5
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
		public long Record6
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
		public long Record7
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
		public long Record8
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
		public long Record9
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
		public long Record10
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
		public long Record11
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
		public long Record12
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
		public long Record13
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
		public long Record14
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
		public long Record15
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
		public long Record16
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
		public long Record17
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
		public long Record18
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
		public long Record19
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
		public long Record20
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
		public LogInstance()
		{
		}

		[DebuggerNonUserCode]
		public LogInstance(LogInstance other)
		{
		}

		[DebuggerNonUserCode]
		public LogInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LogInstance other)
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
		public void MergeFrom(LogInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
