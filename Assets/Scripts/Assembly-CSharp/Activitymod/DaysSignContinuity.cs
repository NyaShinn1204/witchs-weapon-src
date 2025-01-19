using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class DaysSignContinuity : IMessage<DaysSignContinuity>, IMessage, IEquatable<DaysSignContinuity>, IDeepCloneable<DaysSignContinuity>
	{
		private static readonly MessageParser<DaysSignContinuity> _parser;

		public const int DaysSignContinuityRewardTagFieldNumber = 1;

		private int daysSignContinuityRewardTag_;

		public const int DaysSignContinuityTimeFieldNumber = 2;

		private long daysSignContinuityTime_;

		public const int DaySignContinuityCanTagFieldNumber = 3;

		private bool daySignContinuityCanTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<DaysSignContinuity> Parser
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
		public int DaysSignContinuityRewardTag
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
		public long DaysSignContinuityTime
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
		public bool DaySignContinuityCanTag
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
		public DaysSignContinuity()
		{
		}

		[DebuggerNonUserCode]
		public DaysSignContinuity(DaysSignContinuity other)
		{
		}

		[DebuggerNonUserCode]
		public DaysSignContinuity Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DaysSignContinuity other)
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
		public void MergeFrom(DaysSignContinuity other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
