using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Ratemod
{
	public sealed class RateInfos : IMessage<RateInfos>, IMessage, IEquatable<RateInfos>, IDeepCloneable<RateInfos>
	{
		private static readonly MessageParser<RateInfos> _parser;

		public const int RateMapFieldNumber = 1;

		private static readonly MapField<long, RateInfo>.Codec _map_rateMap_codec;

		private readonly MapField<long, RateInfo> rateMap_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RateInfos> Parser
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
		public MapField<long, RateInfo> RateMap
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RateInfos()
		{
		}

		[DebuggerNonUserCode]
		public RateInfos(RateInfos other)
		{
		}

		[DebuggerNonUserCode]
		public RateInfos Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RateInfos other)
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
		public void MergeFrom(RateInfos other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
