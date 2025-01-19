using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class FashionRunes : IMessage<FashionRunes>, IMessage, IEquatable<FashionRunes>, IDeepCloneable<FashionRunes>
	{
		private static readonly MessageParser<FashionRunes> _parser;

		public const int RunesFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_runes_codec;

		private readonly RepeatedField<int> runes_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FashionRunes> Parser
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
		public RepeatedField<int> Runes
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FashionRunes()
		{
		}

		[DebuggerNonUserCode]
		public FashionRunes(FashionRunes other)
		{
		}

		[DebuggerNonUserCode]
		public FashionRunes Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FashionRunes other)
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
		public void MergeFrom(FashionRunes other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
