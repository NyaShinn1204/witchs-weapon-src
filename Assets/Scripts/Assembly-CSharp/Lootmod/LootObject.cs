using System;
using System.Diagnostics;
using Bpobjmod;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Lootmod
{
	public sealed class LootObject : IMessage<LootObject>, IMessage, IEquatable<LootObject>, IDeepCloneable<LootObject>
	{
		private static readonly MessageParser<LootObject> _parser;

		public const int TypeFieldNumber = 1;

		private int type_;

		public const int IdFieldNumber = 2;

		private long id_;

		public const int ValueFieldNumber = 3;

		private long value_;

		public const int NumFieldNumber = 4;

		private long num_;

		public const int RuneInfoFieldNumber = 5;

		private RuneInfo runeInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LootObject> Parser
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
		public int Type
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
		public long Id
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
		public long Value
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
		public long Num
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
		public RuneInfo RuneInfo
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
		public LootObject()
		{
		}

		[DebuggerNonUserCode]
		public LootObject(LootObject other)
		{
		}

		[DebuggerNonUserCode]
		public LootObject Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LootObject other)
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
		public void MergeFrom(LootObject other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
