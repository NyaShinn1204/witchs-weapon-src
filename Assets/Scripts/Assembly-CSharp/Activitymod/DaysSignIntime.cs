using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class DaysSignIntime : IMessage<DaysSignIntime>, IMessage, IEquatable<DaysSignIntime>, IDeepCloneable<DaysSignIntime>
	{
		private static readonly MessageParser<DaysSignIntime> _parser;

		public const int DaysSignIntimeRewardTagFieldNumber = 1;

		private int daysSignIntimeRewardTag_;

		public const int DaysSignIntimeTimeFieldNumber = 2;

		private long daysSignIntimeTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<DaysSignIntime> Parser
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
		public int DaysSignIntimeRewardTag
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
		public long DaysSignIntimeTime
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
		public DaysSignIntime()
		{
		}

		[DebuggerNonUserCode]
		public DaysSignIntime(DaysSignIntime other)
		{
		}

		[DebuggerNonUserCode]
		public DaysSignIntime Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DaysSignIntime other)
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
		public void MergeFrom(DaysSignIntime other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
