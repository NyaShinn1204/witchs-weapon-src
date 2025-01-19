using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Logmod
{
	public sealed class OtherDrawInfo : IMessage<OtherDrawInfo>, IMessage, IEquatable<OtherDrawInfo>, IDeepCloneable<OtherDrawInfo>
	{
		private static readonly MessageParser<OtherDrawInfo> _parser;

		public const int RateSerialFieldNumber = 1;

		private int rateSerial_;

		public const int RateIndexFieldNumber = 2;

		private int rateIndex_;

		public const int TimeFieldNumber = 3;

		private string time_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<OtherDrawInfo> Parser
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
		public int RateSerial
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
		public int RateIndex
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
		public string Time
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
		public OtherDrawInfo()
		{
		}

		[DebuggerNonUserCode]
		public OtherDrawInfo(OtherDrawInfo other)
		{
		}

		[DebuggerNonUserCode]
		public OtherDrawInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(OtherDrawInfo other)
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
		public void MergeFrom(OtherDrawInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
