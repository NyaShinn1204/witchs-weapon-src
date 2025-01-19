using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Ratemod
{
	public sealed class RateTemplets : IMessage<RateTemplets>, IMessage, IEquatable<RateTemplets>, IDeepCloneable<RateTemplets>
	{
		private static readonly MessageParser<RateTemplets> _parser;

		public const int TempletsFieldNumber = 1;

		private static readonly FieldCodec<RateTemplet> _repeated_templets_codec;

		private readonly RepeatedField<RateTemplet> templets_;

		public const int VersionFieldNumber = 100;

		private int version_;

		public const int IDFieldNumber = 101;

		private long iD_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RateTemplets> Parser
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
		public RepeatedField<RateTemplet> Templets
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Version
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
		public long ID
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
		public RateTemplets()
		{
		}

		[DebuggerNonUserCode]
		public RateTemplets(RateTemplets other)
		{
		}

		[DebuggerNonUserCode]
		public RateTemplets Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RateTemplets other)
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
		public void MergeFrom(RateTemplets other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
