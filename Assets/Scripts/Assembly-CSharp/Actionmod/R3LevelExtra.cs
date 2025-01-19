using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class R3LevelExtra : IMessage<R3LevelExtra>, IMessage, IEquatable<R3LevelExtra>, IDeepCloneable<R3LevelExtra>
	{
		private static readonly MessageParser<R3LevelExtra> _parser;

		public const int LowLevelFieldNumber = 1;

		private bool lowLevel_;

		public const int LevelIDFieldNumber = 2;

		private long levelID_;

		public const int LevelBuffFieldNumber = 3;

		private long levelBuff_;

		public const int WinCountFieldNumber = 4;

		private int winCount_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R3LevelExtra> Parser
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
		public bool LowLevel
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
		public long LevelID
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
		public long LevelBuff
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
		public int WinCount
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
		public R3LevelExtra()
		{
		}

		[DebuggerNonUserCode]
		public R3LevelExtra(R3LevelExtra other)
		{
		}

		[DebuggerNonUserCode]
		public R3LevelExtra Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R3LevelExtra other)
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
		public void MergeFrom(R3LevelExtra other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
