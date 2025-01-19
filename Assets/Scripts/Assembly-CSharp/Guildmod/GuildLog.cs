using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class GuildLog : IMessage<GuildLog>, IMessage, IEquatable<GuildLog>, IDeepCloneable<GuildLog>
	{
		private static readonly MessageParser<GuildLog> _parser;

		public const int IDFieldNumber = 1;

		private int iD_;

		public const int TimeFieldNumber = 2;

		private long time_;

		public const int StringIDFieldNumber = 4;

		private int stringID_;

		public const int VarsFieldNumber = 5;

		private static readonly FieldCodec<string> _repeated_vars_codec;

		private readonly RepeatedField<string> vars_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<GuildLog> Parser
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
		public int ID
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
		public long Time
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
		public int StringID
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
		public RepeatedField<string> Vars
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public GuildLog()
		{
		}

		[DebuggerNonUserCode]
		public GuildLog(GuildLog other)
		{
		}

		[DebuggerNonUserCode]
		public GuildLog Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GuildLog other)
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
		public void MergeFrom(GuildLog other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
