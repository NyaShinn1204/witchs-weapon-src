using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Achievemod
{
	public sealed class Metadata : IMessage<Metadata>, IMessage, IEquatable<Metadata>, IDeepCloneable<Metadata>
	{
		private static readonly MessageParser<Metadata> _parser;

		public const int MapFieldNumber = 1;

		private static readonly MapField<string, MetaCM>.Codec _map_map_codec;

		private readonly MapField<string, MetaCM> map_;

		public const int StartTimeFieldNumber = 2;

		private long startTime_;

		public const int EndTimeFieldNumber = 3;

		private long endTime_;

		public const int APSerialFieldNumber = 4;

		private int aPSerial_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Metadata> Parser
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
		public MapField<string, MetaCM> Map
		{
			get
			{
				return null;
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
		public long EndTime
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
		public int APSerial
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
		public Metadata()
		{
		}

		[DebuggerNonUserCode]
		public Metadata(Metadata other)
		{
		}

		[DebuggerNonUserCode]
		public Metadata Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Metadata other)
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
		public void MergeFrom(Metadata other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
