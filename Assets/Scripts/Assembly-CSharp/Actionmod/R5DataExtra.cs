using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class R5DataExtra : IMessage<R5DataExtra>, IMessage, IEquatable<R5DataExtra>, IDeepCloneable<R5DataExtra>
	{
		private static readonly MessageParser<R5DataExtra> _parser;

		public const int R5DataLowerFieldNumber = 100;

		private R5BaseDataExtra r5DataLower_;

		public const int R5DataUpperFieldNumber = 101;

		private R5BaseDataExtra r5DataUpper_;

		public const int UpperUnlockFieldNumber = 102;

		private bool upperUnlock_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R5DataExtra> Parser
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
		public R5BaseDataExtra R5DataLower
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
		public R5BaseDataExtra R5DataUpper
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
		public bool UpperUnlock
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
		public R5DataExtra()
		{
		}

		[DebuggerNonUserCode]
		public R5DataExtra(R5DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public R5DataExtra Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R5DataExtra other)
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
		public void MergeFrom(R5DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
