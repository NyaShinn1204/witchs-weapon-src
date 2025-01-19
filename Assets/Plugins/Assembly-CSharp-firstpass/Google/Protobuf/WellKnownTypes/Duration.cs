using System;
using System.Diagnostics;
using System.Text;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Duration : IMessage<Duration>, ICustomDiagnosticMessage, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>
	{
		private static readonly MessageParser<Duration> _parser;

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		public const int NanosecondsPerSecond = 1000000000;

		public const int NanosecondsPerTick = 100;

		public const long MaxSeconds = 315576000000L;

		public const long MinSeconds = -315576000000L;

		internal const int MaxNanoseconds = 999999999;

		internal const int MinNanoseconds = -999999999;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Duration> Parser
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
		public Duration()
		{
		}

		[DebuggerNonUserCode]
		public Duration(Duration other)
		{
		}

		[DebuggerNonUserCode]
		public Duration Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Duration other)
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
		public void MergeFrom(Duration other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		internal static bool IsNormalized(long seconds, int nanoseconds)
		{
			return false;
		}

		public TimeSpan ToTimeSpan()
		{
			return default(TimeSpan);
		}

		public static Duration FromTimeSpan(TimeSpan timeSpan)
		{
			return null;
		}

		public static Duration operator -(Duration value)
		{
			return null;
		}

		public static Duration operator +(Duration lhs, Duration rhs)
		{
			return null;
		}

		public static Duration operator -(Duration lhs, Duration rhs)
		{
			return null;
		}

		internal static Duration Normalize(long seconds, int nanoseconds)
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

		internal static void AppendNanoseconds(StringBuilder builder, int nanos)
		{
		}
	}
}
