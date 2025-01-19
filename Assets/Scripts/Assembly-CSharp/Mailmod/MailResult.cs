using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mailmod
{
	public sealed class MailResult : IMessage<MailResult>, IMessage, IEquatable<MailResult>, IDeepCloneable<MailResult>
	{
		private static readonly MessageParser<MailResult> _parser;

		public const int NormalMailFieldNumber = 1;

		private static readonly FieldCodec<MailDetail> _repeated_normalMail_codec;

		private readonly RepeatedField<MailDetail> normalMail_;

		public const int SpecialMailFieldNumber = 2;

		private static readonly FieldCodec<MailDetail> _repeated_specialMail_codec;

		private readonly RepeatedField<MailDetail> specialMail_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MailResult> Parser
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
		public RepeatedField<MailDetail> NormalMail
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MailDetail> SpecialMail
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MailResult()
		{
		}

		[DebuggerNonUserCode]
		public MailResult(MailResult other)
		{
		}

		[DebuggerNonUserCode]
		public MailResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MailResult other)
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
		public void MergeFrom(MailResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
