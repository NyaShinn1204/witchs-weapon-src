using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Achievemod
{
	public sealed class Jobs : IMessage<Jobs>, IMessage, IEquatable<Jobs>, IDeepCloneable<Jobs>
	{
		private static readonly MessageParser<Jobs> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Job> _repeated_data_codec;

		private readonly RepeatedField<Job> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Jobs> Parser
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
		public RepeatedField<Job> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Jobs()
		{
		}

		[DebuggerNonUserCode]
		public Jobs(Jobs other)
		{
		}

		[DebuggerNonUserCode]
		public Jobs Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Jobs other)
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
		public void MergeFrom(Jobs other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
