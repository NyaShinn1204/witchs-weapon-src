using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class MercenaryList : IMessage<MercenaryList>, IMessage, IEquatable<MercenaryList>, IDeepCloneable<MercenaryList>
	{
		private static readonly MessageParser<MercenaryList> _parser;

		public const int GuildIDFieldNumber = 1;

		private string guildID_;

		public const int MercenariesFieldNumber = 2;

		private static readonly MapField<string, Mercenary>.Codec _map_mercenaries_codec;

		private readonly MapField<string, Mercenary> mercenaries_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MercenaryList> Parser
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
		public string GuildID
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
		public MapField<string, Mercenary> Mercenaries
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MercenaryList()
		{
		}

		[DebuggerNonUserCode]
		public MercenaryList(MercenaryList other)
		{
		}

		[DebuggerNonUserCode]
		public MercenaryList Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MercenaryList other)
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
		public void MergeFrom(MercenaryList other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
