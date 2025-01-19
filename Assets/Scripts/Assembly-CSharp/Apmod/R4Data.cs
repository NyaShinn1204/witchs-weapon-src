using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class R4Data : IMessage<R4Data>, IMessage, IEquatable<R4Data>, IDeepCloneable<R4Data>
	{
		private static readonly MessageParser<R4Data> _parser;

		public const int InstancesFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_instances_codec;

		private readonly RepeatedField<long> instances_;

		public const int BuffsFieldNumber = 2;

		private static readonly FieldCodec<long> _repeated_buffs_codec;

		private readonly RepeatedField<long> buffs_;

		public const int BuffLayersFieldNumber = 3;

		private static readonly FieldCodec<int> _repeated_buffLayers_codec;

		private readonly RepeatedField<int> buffLayers_;

		public const int RoundTypesFieldNumber = 4;

		private static readonly FieldCodec<int> _repeated_roundTypes_codec;

		private readonly RepeatedField<int> roundTypes_;

		public const int MobEnhanceFieldNumber = 5;

		private static readonly FieldCodec<string> _repeated_mobEnhance_codec;

		private readonly RepeatedField<string> mobEnhance_;

		public const int MobBuffsFieldNumber = 6;

		private static readonly FieldCodec<long> _repeated_mobBuffs_codec;

		private readonly RepeatedField<long> mobBuffs_;

		public const int FloorFieldNumber = 100;

		private int floor_;

		public const int RoundTypeFieldNumber = 101;

		private int roundType_;

		public const int ProfitFloorFieldNumber = 102;

		private int profitFloor_;

		public const int RoundLootModulusFieldNumber = 103;

		private double roundLootModulus_;

		public const int ExtraLootLayerFieldNumber = 104;

		private int extraLootLayer_;

		public const int ExtraLootTypeFieldNumber = 105;

		private int extraLootType_;

		public const int MainBuffFieldNumber = 106;

		private long mainBuff_;

		public const int CurProfitFieldNumber = 107;

		private int curProfit_;

		public const int CombatFloorFieldNumber = 108;

		private int combatFloor_;

		public const int TempExtraLootLayerFieldNumber = 109;

		private int tempExtraLootLayer_;

		public const int TempExtraLootTypeFieldNumber = 110;

		private int tempExtraLootType_;

		public const int RoundCombatNumFieldNumber = 111;

		private int roundCombatNum_;

		public const int MobLevelFieldNumber = 112;

		private int mobLevel_;

		public const int MaxMobLevelFieldNumber = 113;

		private int maxMobLevel_;

		public const int BeforeMobLevelFieldNumber = 114;

		private int beforeMobLevel_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R4Data> Parser
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
		public RepeatedField<long> Instances
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> Buffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> BuffLayers
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> RoundTypes
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<string> MobEnhance
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> MobBuffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Floor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int RoundType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int ProfitFloor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double RoundLootModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int ExtraLootLayer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int ExtraLootType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long MainBuff
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
		public int CurProfit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CombatFloor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TempExtraLootLayer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TempExtraLootType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int RoundCombatNum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MobLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MaxMobLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int BeforeMobLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public R4Data()
		{
		}

		[DebuggerNonUserCode]
		public R4Data(R4Data other)
		{
		}

		[DebuggerNonUserCode]
		public R4Data Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R4Data other)
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
		public void MergeFrom(R4Data other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
