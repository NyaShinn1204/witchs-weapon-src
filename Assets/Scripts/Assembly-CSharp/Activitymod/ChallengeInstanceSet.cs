using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ChallengeInstanceSet : IMessage<ChallengeInstanceSet>, IMessage, IEquatable<ChallengeInstanceSet>, IDeepCloneable<ChallengeInstanceSet>
	{
		private static readonly MessageParser<ChallengeInstanceSet> _parser;

		public const int SetIDFieldNumber = 1;

		private long setID_;

		public const int StartTimeFieldNumber = 2;

		private long startTime_;

		public const int EndTImeFieldNumber = 3;

		private long endTIme_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ChallengeInstanceSet> Parser
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
		public long SetID
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
		public long StartTime
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
		public long EndTIme
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
		public ChallengeInstanceSet()
		{
		}

		[DebuggerNonUserCode]
		public ChallengeInstanceSet(ChallengeInstanceSet other)
		{
		}

		[DebuggerNonUserCode]
		public ChallengeInstanceSet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ChallengeInstanceSet other)
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
		public void MergeFrom(ChallengeInstanceSet other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
