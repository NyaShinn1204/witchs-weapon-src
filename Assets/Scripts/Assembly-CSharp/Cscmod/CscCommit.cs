using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Cscmod
{
	public sealed class CscCommit : IMessage<CscCommit>, IMessage, IEquatable<CscCommit>, IDeepCloneable<CscCommit>
	{
		private static readonly MessageParser<CscCommit> _parser;

		public const int CscInstanceFieldNumber = 1;

		private CscInstance cscInstance_;

		public const int CscLootFieldNumber = 2;

		private Lootmod.LootResult cscLoot_;

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
		public static MessageParser<CscCommit> Parser
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
		public CscInstance CscInstance
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
		public Lootmod.LootResult CscLoot
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
		public CscCommit()
		{
		}

		[DebuggerNonUserCode]
		public CscCommit(CscCommit other)
		{
		}

		[DebuggerNonUserCode]
		public CscCommit Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CscCommit other)
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
		public void MergeFrom(CscCommit other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
