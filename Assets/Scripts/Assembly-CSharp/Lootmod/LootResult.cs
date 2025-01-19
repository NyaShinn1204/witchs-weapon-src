using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Lootmod
{
	public sealed class LootResult : IMessage<LootResult>, IMessage, IEquatable<LootResult>, IDeepCloneable<LootResult>
	{
		private static readonly MessageParser<LootResult> _parser;

		public const int LootObjectsFieldNumber = 1;

		private static readonly FieldCodec<LootObject> _repeated_lootObjects_codec;

		private readonly RepeatedField<LootObject> lootObjects_;

		public const int ExtraInfoFieldNumber = 2;

		private ExtraInfo extraInfo_;

		public const int DrawCurrency2AttachedIDsFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_drawCurrency2AttachedIDs_codec;

		private readonly RepeatedField<long> drawCurrency2AttachedIDs_;

		public const int IsSpecialRCodeFieldNumber = 100;

		private bool isSpecialRCode_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LootResult> Parser
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
		public RepeatedField<LootObject> LootObjects
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
		public RepeatedField<long> DrawCurrency2AttachedIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool IsSpecialRCode
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
		public LootResult()
		{
		}

		[DebuggerNonUserCode]
		public LootResult(LootResult other)
		{
		}

		[DebuggerNonUserCode]
		public LootResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LootResult other)
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
		public void MergeFrom(LootResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
