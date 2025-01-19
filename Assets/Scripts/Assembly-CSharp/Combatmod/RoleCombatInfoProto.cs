using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class RoleCombatInfoProto : IMessage<RoleCombatInfoProto>, IMessage, IEquatable<RoleCombatInfoProto>, IDeepCloneable<RoleCombatInfoProto>
	{
		private static readonly MessageParser<RoleCombatInfoProto> _parser;

		public const int CommonAttrFieldNumber = 1;

		private static readonly FieldCodec<double> _repeated_commonAttr_codec;

		private readonly RepeatedField<double> commonAttr_;

		public const int SvCombatInfoFieldNumber = 2;

		private static readonly FieldCodec<ServantCombatInfo> _repeated_svCombatInfo_codec;

		private readonly RepeatedField<ServantCombatInfo> svCombatInfo_;

		public const int SpawnBuffFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_spawnBuff_codec;

		private readonly RepeatedField<long> spawnBuff_;

		public const int TriggerListFieldNumber = 4;

		private static readonly FieldCodec<long> _repeated_triggerList_codec;

		private readonly RepeatedField<long> triggerList_;

		public const int SummonBuffFieldNumber = 5;

		private static readonly FieldCodec<long> _repeated_summonBuff_codec;

		private readonly RepeatedField<long> summonBuff_;

		public const int SpawnBuffLayerFieldNumber = 6;

		private static readonly FieldCodec<int> _repeated_spawnBuffLayer_codec;

		private readonly RepeatedField<int> spawnBuffLayer_;

		public const int SummonBuffLayerFieldNumber = 7;

		private static readonly FieldCodec<int> _repeated_summonBuffLayer_codec;

		private readonly RepeatedField<int> summonBuffLayer_;

		public const int PlayerAttrFieldNumber = 8;

		private static readonly FieldCodec<int> _repeated_playerAttr_codec;

		private readonly RepeatedField<int> playerAttr_;

		public const int RoleLvFieldNumber = 100;

		private int roleLv_;

		public const int CombatConstFieldNumber = 101;

		private CombatConstInfo combatConst_;

		public const int UnitFieldNumber = 102;

		private Basket unit_;

		public const int FashionSerialFieldNumber = 103;

		private int fashionSerial_;

		public const int TargetDamageFieldNumber = 104;

		private long targetDamage_;

		public const int SweepDamageFieldNumber = 105;

		private long sweepDamage_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleCombatInfoProto> Parser
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
		public RepeatedField<double> CommonAttr
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ServantCombatInfo> SvCombatInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> SpawnBuff
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> TriggerList
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> SummonBuff
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> SpawnBuffLayer
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> SummonBuffLayer
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> PlayerAttr
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int RoleLv
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public CombatConstInfo CombatConst
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
		public Basket Unit
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
		public int FashionSerial
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long TargetDamage
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
		public long SweepDamage
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
		public RoleCombatInfoProto()
		{
		}

		[DebuggerNonUserCode]
		public RoleCombatInfoProto(RoleCombatInfoProto other)
		{
		}

		[DebuggerNonUserCode]
		public RoleCombatInfoProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleCombatInfoProto other)
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
		public void MergeFrom(RoleCombatInfoProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
