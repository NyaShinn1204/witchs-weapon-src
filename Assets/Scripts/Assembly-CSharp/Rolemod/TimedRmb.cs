using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class TimedRmb : IMessage<TimedRmb>, IMessage, IEquatable<TimedRmb>, IDeepCloneable<TimedRmb>
	{
		private static readonly MessageParser<TimedRmb> _parser;

		public const int ValueFieldNumber = 1;

		private long value_;

		public const int TimeFieldNumber = 2;

		private long time_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<TimedRmb> Parser
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
		public long Value
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
		public TimedRmb()
		{
		}

		[DebuggerNonUserCode]
		public TimedRmb(TimedRmb other)
		{
		}

		[DebuggerNonUserCode]
		public TimedRmb Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(TimedRmb other)
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
		public void MergeFrom(TimedRmb other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
