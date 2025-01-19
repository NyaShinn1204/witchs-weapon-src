using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class BackpackAddup : IMessage<BackpackAddup>, IMessage, IEquatable<BackpackAddup>, IDeepCloneable<BackpackAddup>
	{
		private static readonly MessageParser<BackpackAddup> _parser;

		public const int AddupFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_addup_codec;

		private readonly RepeatedField<int> addup_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<BackpackAddup> Parser
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
		public RepeatedField<int> Addup
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public BackpackAddup()
		{
		}

		[DebuggerNonUserCode]
		public BackpackAddup(BackpackAddup other)
		{
		}

		[DebuggerNonUserCode]
		public BackpackAddup Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BackpackAddup other)
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
		public void MergeFrom(BackpackAddup other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
