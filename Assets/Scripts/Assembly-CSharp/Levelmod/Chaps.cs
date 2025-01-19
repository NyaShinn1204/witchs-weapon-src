using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Levelmod
{
	public sealed class Chaps : IMessage<Chaps>, IMessage, IEquatable<Chaps>, IDeepCloneable<Chaps>
	{
		private static readonly MessageParser<Chaps> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Chap> _repeated_data_codec;

		private readonly RepeatedField<Chap> data_;

		public const int MaterialLootTimesFieldNumber = 2;

		private int materialLootTimes_;

		public const int LastMaterialLootTimeFieldNumber = 3;

		private long lastMaterialLootTime_;

		public const int ExtraLootFieldNumber = 4;

		private static readonly FieldCodec<LootObject> _repeated_extraLoot_codec;

		private readonly RepeatedField<LootObject> extraLoot_;

		public const int WeaponChooseFieldNumber = 5;

		private int weaponChoose_;

		public const int EnterLevelTimeFieldNumber = 6;

		private long enterLevelTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Chaps> Parser
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
		public RepeatedField<Chap> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int MaterialLootTimes
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
		public long LastMaterialLootTime
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
		public RepeatedField<LootObject> ExtraLoot
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int WeaponChoose
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
		public long EnterLevelTime
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
		public Chaps()
		{
		}

		[DebuggerNonUserCode]
		public Chaps(Chaps other)
		{
		}

		[DebuggerNonUserCode]
		public Chaps Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Chaps other)
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
		public void MergeFrom(Chaps other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
