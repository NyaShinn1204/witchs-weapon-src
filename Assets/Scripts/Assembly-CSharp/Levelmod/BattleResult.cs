using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Levelmod
{
	public sealed class BattleResult : IMessage<BattleResult>, IMessage, IEquatable<BattleResult>, IDeepCloneable<BattleResult>
	{
		private static readonly MessageParser<BattleResult> _parser;

		public const int StaminaFieldNumber = 1;

		private int stamina_;

		public const int StaminaTimeFieldNumber = 2;

		private long staminaTime_;

		public const int AddedExpFieldNumber = 5;

		private int addedExp_;

		public const int LootResultFieldNumber = 3;

		private static readonly FieldCodec<LootObject> _repeated_lootResult_codec;

		private readonly RepeatedField<LootObject> lootResult_;

		public const int ExtraInfoFieldNumber = 4;

		private ExtraInfo extraInfo_;

		public const int SpecifiedLootFieldNumber = 6;

		private static readonly FieldCodec<LootObject> _repeated_specifiedLoot_codec;

		private readonly RepeatedField<LootObject> specifiedLoot_;

		public const int RandomLootFieldNumber = 7;

		private static readonly FieldCodec<LootObject> _repeated_randomLoot_codec;

		private readonly RepeatedField<LootObject> randomLoot_;

		public const int OneOfRandomFieldNumber = 8;

		private LootObject oneOfRandom_;

		public const int ExtraContentFieldNumber = 9;

		private string extraContent_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<BattleResult> Parser
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
		public int Stamina
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
		public long StaminaTime
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
		public int AddedExp
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
		public RepeatedField<LootObject> LootResult
		{
			get
			{
				return null;
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
		public RepeatedField<LootObject> SpecifiedLoot
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<LootObject> RandomLoot
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public LootObject OneOfRandom
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
		public string ExtraContent
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
		public BattleResult()
		{
		}

		[DebuggerNonUserCode]
		public BattleResult(BattleResult other)
		{
		}

		[DebuggerNonUserCode]
		public BattleResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BattleResult other)
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
		public void MergeFrom(BattleResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
