using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class Employed : IMessage<Employed>, IMessage, IEquatable<Employed>, IDeepCloneable<Employed>
	{
		private static readonly MessageParser<Employed> _parser;

		public const int PlayModeFieldNumber = 1;

		private int playMode_;

		public const int MercenariesFieldNumber = 2;

		private static readonly FieldCodec<Mercenary> _repeated_mercenaries_codec;

		private readonly RepeatedField<Mercenary> mercenaries_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Employed> Parser
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
		public int PlayMode
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
		public RepeatedField<Mercenary> Mercenaries
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Employed()
		{
		}

		[DebuggerNonUserCode]
		public Employed(Employed other)
		{
		}

		[DebuggerNonUserCode]
		public Employed Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Employed other)
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
		public void MergeFrom(Employed other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
