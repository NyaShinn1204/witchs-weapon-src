using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Levelmod
{
	public sealed class SweepResult : IMessage<SweepResult>, IMessage, IEquatable<SweepResult>, IDeepCloneable<SweepResult>
	{
		private static readonly MessageParser<SweepResult> _parser;

		public const int LootResultFieldNumber = 1;

		private static readonly FieldCodec<Lootmod.LootResult> _repeated_lootResult_codec;

		private readonly RepeatedField<Lootmod.LootResult> lootResult_;

		public const int ExtraInfoFieldNumber = 2;

		private ExtraInfo extraInfo_;

		public const int StaminaFieldNumber = 3;

		private int stamina_;

		public const int ExpFieldNumber = 4;

		private int exp_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SweepResult> Parser
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
		public RepeatedField<Lootmod.LootResult> LootResult
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
		public int Exp
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
		public SweepResult()
		{
		}

		[DebuggerNonUserCode]
		public SweepResult(SweepResult other)
		{
		}

		[DebuggerNonUserCode]
		public SweepResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SweepResult other)
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
		public void MergeFrom(SweepResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
