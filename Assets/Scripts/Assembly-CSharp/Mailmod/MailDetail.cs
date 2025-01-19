using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Mailmod
{
	public sealed class MailDetail : IMessage<MailDetail>, IMessage, IEquatable<MailDetail>, IDeepCloneable<MailDetail>
	{
		private static readonly MessageParser<MailDetail> _parser;

		public const int MailIDFieldNumber = 1;

		private string mailID_;

		public const int TitleFieldNumber = 2;

		private string title_;

		public const int FromFieldNumber = 3;

		private string from_;

		public const int ContentFieldNumber = 4;

		private string content_;

		public const int HaveAttachFieldNumber = 5;

		private bool haveAttach_;

		public const int ReceiveTimeFieldNumber = 6;

		private string receiveTime_;

		public const int StatusFieldNumber = 7;

		private string status_;

		public const int AttachIDFieldNumber = 8;

		private long attachID_;

		public const int AttachsFieldNumber = 9;

		private static readonly FieldCodec<LootObject> _repeated_attachs_codec;

		private readonly RepeatedField<LootObject> attachs_;

		public const int ReadedFieldNumber = 12;

		private bool readed_;

		public const int ContentArgsFieldNumber = 13;

		private static readonly FieldCodec<string> _repeated_contentArgs_codec;

		private readonly RepeatedField<string> contentArgs_;

		public const int MailTempletIDFieldNumber = 16;

		private long mailTempletID_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MailDetail> Parser
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
		public string MailID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string From
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HaveAttach
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
		public string ReceiveTime
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long AttachID
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
		public RepeatedField<LootObject> Attachs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool Readed
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
		public RepeatedField<string> ContentArgs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long MailTempletID
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
		public MailDetail()
		{
		}

		[DebuggerNonUserCode]
		public MailDetail(MailDetail other)
		{
		}

		[DebuggerNonUserCode]
		public MailDetail Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MailDetail other)
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
		public void MergeFrom(MailDetail other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
