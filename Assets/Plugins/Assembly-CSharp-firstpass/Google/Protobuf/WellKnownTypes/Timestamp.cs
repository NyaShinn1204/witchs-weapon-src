using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Timestamp : IMessage<Timestamp>, ICustomDiagnosticMessage, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>
	{
		private static readonly MessageParser<Timestamp> _parser;

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		private static readonly DateTime UnixEpoch;

		private const long BclSecondsAtUnixEpoch = 62135596800L;

		internal const long UnixSecondsAtBclMaxValue = 253402300799L;

		internal const long UnixSecondsAtBclMinValue = -62135596800L;

		internal const int MaxNanos = 999999999;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Timestamp> Parser
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
		public long Seconds
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
		public int Nanos
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
		public Timestamp()
		{
		}

		[DebuggerNonUserCode]
		public Timestamp(Timestamp other)
		{
		}

		[DebuggerNonUserCode]
		public Timestamp Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Timestamp other)
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
		public void MergeFrom(Timestamp other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		private static bool IsNormalized(long seconds, int nanoseconds)
		{
			return false;
		}

		public static Duration operator -(Timestamp lhs, Timestamp rhs)
		{
			return null;
		}

		public static Timestamp operator +(Timestamp lhs, Duration rhs)
		{
			return null;
		}

		public static Timestamp operator -(Timestamp lhs, Duration rhs)
		{
			return null;
		}

		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		public DateTimeOffset ToDateTimeOffset()
		{
			return default(DateTimeOffset);
		}

		public static Timestamp FromDateTime(DateTime dateTime)
		{
			return null;
		}

		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
			return null;
		}

		internal static Timestamp Normalize(long seconds, int nanoseconds)
		{
			return null;
		}

		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			return null;
		}

		public string ToDiagnosticString()
		{
			return null;
		}
	}
}
