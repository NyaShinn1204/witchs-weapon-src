using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class FashionInstances : IMessage<FashionInstances>, IMessage, IEquatable<FashionInstances>, IDeepCloneable<FashionInstances>
	{
		private static readonly MessageParser<FashionInstances> _parser;

		public const int FashionInstanceFieldNumber = 1;

		private static readonly FieldCodec<FashionInstance> _repeated_fashionInstance_codec;

		private readonly RepeatedField<FashionInstance> fashionInstance_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FashionInstances> Parser
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
		public RepeatedField<FashionInstance> FashionInstance
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FashionInstances()
		{
		}

		[DebuggerNonUserCode]
		public FashionInstances(FashionInstances other)
		{
		}

		[DebuggerNonUserCode]
		public FashionInstances Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FashionInstances other)
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
		public void MergeFrom(FashionInstances other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
