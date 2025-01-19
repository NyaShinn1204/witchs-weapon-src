using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class Set : IMessage<Set>, IMessage, IEquatable<Set>, IDeepCloneable<Set>
	{
		private static readonly MessageParser<Set> _parser;

		public const int SetIDFieldNumber = 1;

		private long setID_;

		public const int ShopsFieldNumber = 2;

		private static readonly FieldCodec<Shop> _repeated_shops_codec;

		private readonly RepeatedField<Shop> shops_;

		public const int VersionFieldNumber = 3;

		private int version_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Set> Parser
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
		public long SetID
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
		public RepeatedField<Shop> Shops
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
		public Set()
		{
		}

		[DebuggerNonUserCode]
		public Set(Set other)
		{
		}

		[DebuggerNonUserCode]
		public Set Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Set other)
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
		public void MergeFrom(Set other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
