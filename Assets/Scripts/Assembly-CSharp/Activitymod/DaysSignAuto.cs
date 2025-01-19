using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class DaysSignAuto : IMessage<DaysSignAuto>, IMessage, IEquatable<DaysSignAuto>, IDeepCloneable<DaysSignAuto>
	{
		private static readonly MessageParser<DaysSignAuto> _parser;

		public const int DaysSignAutoDaysFieldNumber = 1;

		private int daysSignAutoDays_;

		public const int DaysSignAutoRewardTagFieldNumber = 2;

		private int daysSignAutoRewardTag_;

		public const int DaysSignAutoCanTagFieldNumber = 3;

		private bool daysSignAutoCanTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<DaysSignAuto> Parser
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
		public int DaysSignAutoDays
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
		public int DaysSignAutoRewardTag
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
		public bool DaysSignAutoCanTag
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
		public DaysSignAuto()
		{
		}

		[DebuggerNonUserCode]
		public DaysSignAuto(DaysSignAuto other)
		{
		}

		[DebuggerNonUserCode]
		public DaysSignAuto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DaysSignAuto other)
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
		public void MergeFrom(DaysSignAuto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
