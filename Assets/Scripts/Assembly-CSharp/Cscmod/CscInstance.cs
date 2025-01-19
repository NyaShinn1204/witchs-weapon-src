using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Svmod;

namespace Cscmod
{
	public sealed class CscInstance : IMessage<CscInstance>, IMessage, IEquatable<CscInstance>, IDeepCloneable<CscInstance>
	{
		private static readonly MessageParser<CscInstance> _parser;

		public const int ServantCardIDsFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_servantCardIDs_codec;

		private readonly RepeatedField<long> servantCardIDs_;

		public const int ServantEnegysFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_servantEnegys_codec;

		private readonly RepeatedField<int> servantEnegys_;

		public const int InstanceIDsFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_instanceIDs_codec;

		private readonly RepeatedField<long> instanceIDs_;

		public const int InstanceLevelsFieldNumber = 4;

		private static readonly FieldCodec<int> _repeated_instanceLevels_codec;

		private readonly RepeatedField<int> instanceLevels_;

		public const int ServantInstanceProtoFieldNumber = 5;

		private static readonly FieldCodec<ServantInstanceProto> _repeated_servantInstanceProto_codec;

		private readonly RepeatedField<ServantInstanceProto> servantInstanceProto_;

		public const int WeaponInstanceFieldNumber = 6;

		private static readonly FieldCodec<WeaponInstance> _repeated_weaponInstance_codec;

		private readonly RepeatedField<WeaponInstance> weaponInstance_;

		public const int ServantCardIDGroupFieldNumber = 7;

		private static readonly FieldCodec<long> _repeated_servantCardIDGroup_codec;

		private readonly RepeatedField<long> servantCardIDGroup_;

		public const int MercenaryCardIDGroupFieldNumber = 8;

		private static readonly FieldCodec<long> _repeated_mercenaryCardIDGroup_codec;

		private readonly RepeatedField<long> mercenaryCardIDGroup_;

		public const int FashionCardIDsFieldNumber = 9;

		private static readonly FieldCodec<long> _repeated_fashionCardIDs_codec;

		private readonly RepeatedField<long> fashionCardIDs_;

		public const int RoleHPFieldNumber = 17;

		private int roleHP_;

		public const int CurSelfCombatScoreFieldNumber = 18;

		private int curSelfCombatScore_;

		public const int CurEnemyCombatScoreFieldNumber = 19;

		private int curEnemyCombatScore_;

		public const int TodayCombatScoreFieldNumber = 20;

		private int todayCombatScore_;

		public const int CurSelfRoleLevelFieldNumber = 21;

		private int curSelfRoleLevel_;

		public const int CurEnemyRoleLevelFieldNumber = 22;

		private int curEnemyRoleLevel_;

		public const int TodayRoleLevelFieldNumber = 23;

		private int todayRoleLevel_;

		public const int CurInstanceSerialFieldNumber = 24;

		private int curInstanceSerial_;

		public const int EnterCountFieldNumber = 25;

		private int enterCount_;

		public const int ClientDataFieldNumber = 26;

		private string clientData_;

		public const int IsOpenFieldNumber = 27;

		private bool isOpen_;

		public const int DaysAfterCreateFieldNumber = 28;

		private int daysAfterCreate_;

		public const int CurLootSerialFieldNumber = 29;

		private int curLootSerial_;

		public const int TotalBattleScoreFieldNumber = 30;

		private int totalBattleScore_;

		public const int BattleScoresFieldNumber = 31;

		private static readonly FieldCodec<int> _repeated_battleScores_codec;

		private readonly RepeatedField<int> battleScores_;

		public const int CscScoreBonusMailedSerialFieldNumber = 32;

		private int cscScoreBonusMailedSerial_;

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
		public static MessageParser<CscInstance> Parser
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
		public RepeatedField<long> ServantCardIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ServantEnegys
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> InstanceIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> InstanceLevels
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
		public RepeatedField<long> ServantCardIDGroup
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> MercenaryCardIDGroup
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> FashionCardIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int RoleHP
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurSelfCombatScore
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurEnemyCombatScore
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TodayCombatScore
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurSelfRoleLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurEnemyRoleLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TodayRoleLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurInstanceSerial
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int EnterCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ClientData
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
		public int DaysAfterCreate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CurLootSerial
		{
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
		public int CscScoreBonusMailedSerial
		{
			get
			{
				return 0;
			}
			set
			{
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
		public CscInstance()
		{
		}

		[DebuggerNonUserCode]
		public CscInstance(CscInstance other)
		{
		}

		[DebuggerNonUserCode]
		public CscInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CscInstance other)
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
		public void MergeFrom(CscInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
