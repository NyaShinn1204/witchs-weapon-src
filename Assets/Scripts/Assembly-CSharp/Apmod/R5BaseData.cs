using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class R5BaseData : IMessage<R5BaseData>, IMessage, IEquatable<R5BaseData>, IDeepCloneable<R5BaseData>
	{
		private static readonly MessageParser<R5BaseData> _parser;

		public const int CommonRoundFieldNumber = 1;

		private R5RoundData commonRound_;

		public const int FinalRoundFieldNumber = 2;

		private R5RoundData finalRound_;

		public const int FinalUnlockFieldNumber = 3;

		private bool finalUnlock_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R5BaseData> Parser
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
		public R5RoundData CommonRound
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
		public R5RoundData FinalRound
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
		public bool FinalUnlock
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
		public R5BaseData()
		{
		}

		[DebuggerNonUserCode]
		public R5BaseData(R5BaseData other)
		{
		}

		[DebuggerNonUserCode]
		public R5BaseData Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R5BaseData other)
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
		public void MergeFrom(R5BaseData other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
