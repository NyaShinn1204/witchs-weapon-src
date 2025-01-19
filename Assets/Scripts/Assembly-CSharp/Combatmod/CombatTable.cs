using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class CombatTable : IMessage<CombatTable>, IMessage, IEquatable<CombatTable>, IDeepCloneable<CombatTable>
	{
		private static readonly MessageParser<CombatTable> _parser;

		public const int CharacterLevelInfoProtoFieldNumber = 1;

		private static readonly FieldCodec<CharacterLevelInfoProto> _repeated_characterLevelInfoProto_codec;

		private readonly RepeatedField<CharacterLevelInfoProto> characterLevelInfoProto_;

		public const int LevelModifyFieldNumber = 2;

		private static readonly FieldCodec<LevelModify> _repeated_levelModify_codec;

		private readonly RepeatedField<LevelModify> levelModify_;

		public const int CombatConstTypeInfoFieldNumber = 3;

		private static readonly FieldCodec<CombatConstTypeInfo> _repeated_combatConstTypeInfo_codec;

		private readonly RepeatedField<CombatConstTypeInfo> combatConstTypeInfo_;

		public const int CombatRateFieldNumber = 4;

		private static readonly FieldCodec<CombatRate> _repeated_combatRate_codec;

		private readonly RepeatedField<CombatRate> combatRate_;

		public const int CampFieldNumber = 5;

		private static readonly FieldCodec<Camp> _repeated_camp_codec;

		private readonly RepeatedField<Camp> camp_;

		public const int CommonSpellFieldNumber = 6;

		private static readonly FieldCodec<long> _repeated_commonSpell_codec;

		private readonly RepeatedField<long> commonSpell_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CombatTable> Parser
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
		public RepeatedField<CharacterLevelInfoProto> CharacterLevelInfoProto
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<LevelModify> LevelModify
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<CombatConstTypeInfo> CombatConstTypeInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<CombatRate> CombatRate
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Camp> Camp
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> CommonSpell
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public CombatTable()
		{
		}

		[DebuggerNonUserCode]
		public CombatTable(CombatTable other)
		{
		}

		[DebuggerNonUserCode]
		public CombatTable Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CombatTable other)
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
		public void MergeFrom(CombatTable other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
