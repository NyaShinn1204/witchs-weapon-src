using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Ratemod
{
	public sealed class RateInstance : IMessage<RateInstance>, IMessage, IEquatable<RateInstance>, IDeepCloneable<RateInstance>
	{
		private static readonly MessageParser<RateInstance> _parser;

		public const int RateMapFieldNumber = 1;

		private static readonly MapField<long, SingleRate>.Codec _map_rateMap_codec;

		private readonly MapField<long, SingleRate> rateMap_;

		public const int FirstSpecialFieldNumber = 100;

		private bool firstSpecial_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RateInstance> Parser
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
		public MapField<long, SingleRate> RateMap
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool FirstSpecial
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
		public RateInstance()
		{
		}

		[DebuggerNonUserCode]
		public RateInstance(RateInstance other)
		{
		}

		[DebuggerNonUserCode]
		public RateInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RateInstance other)
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
		public void MergeFrom(RateInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
