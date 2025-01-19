using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mailmod
{
	public sealed class MailDetails : IMessage<MailDetails>, IMessage, IEquatable<MailDetails>, IDeepCloneable<MailDetails>
	{
		private static readonly MessageParser<MailDetails> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<MailDetail> _repeated_data_codec;

		private readonly RepeatedField<MailDetail> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MailDetails> Parser
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
		public RepeatedField<MailDetail> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MailDetails()
		{
		}

		[DebuggerNonUserCode]
		public MailDetails(MailDetails other)
		{
		}

		[DebuggerNonUserCode]
		public MailDetails Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MailDetails other)
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
		public void MergeFrom(MailDetails other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
