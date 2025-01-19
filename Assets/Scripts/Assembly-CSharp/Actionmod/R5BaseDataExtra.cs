using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class R5BaseDataExtra : IMessage<R5BaseDataExtra>, IMessage, IEquatable<R5BaseDataExtra>, IDeepCloneable<R5BaseDataExtra>
	{
		private static readonly MessageParser<R5BaseDataExtra> _parser;

		public const int CommonRoundFieldNumber = 1;

		private R5RoundDataExtra commonRound_;

		public const int FinalRoundFieldNumber = 2;

		private R5RoundDataExtra finalRound_;

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
		public static MessageParser<R5BaseDataExtra> Parser
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
		public R5RoundDataExtra CommonRound
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
		public R5RoundDataExtra FinalRound
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
		public R5BaseDataExtra()
		{
		}

		[DebuggerNonUserCode]
		public R5BaseDataExtra(R5BaseDataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public R5BaseDataExtra Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R5BaseDataExtra other)
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
		public void MergeFrom(R5BaseDataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
