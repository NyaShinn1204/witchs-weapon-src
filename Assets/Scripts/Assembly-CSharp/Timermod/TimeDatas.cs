using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Timermod
{
	public sealed class TimeDatas : IMessage<TimeDatas>, IMessage, IEquatable<TimeDatas>, IDeepCloneable<TimeDatas>
	{
		private static readonly MessageParser<TimeDatas> _parser;

		public const int DataFieldNumber = 1;

		private static readonly MapField<long, TimeData>.Codec _map_data_codec;

		private readonly MapField<long, TimeData> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<TimeDatas> Parser
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
		public MapField<long, TimeData> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public TimeDatas()
		{
		}

		[DebuggerNonUserCode]
		public TimeDatas(TimeDatas other)
		{
		}

		[DebuggerNonUserCode]
		public TimeDatas Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(TimeDatas other)
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
		public void MergeFrom(TimeDatas other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
