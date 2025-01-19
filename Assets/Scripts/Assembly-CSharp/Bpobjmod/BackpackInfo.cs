using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class BackpackInfo : IMessage<BackpackInfo>, IMessage, IEquatable<BackpackInfo>, IDeepCloneable<BackpackInfo>
	{
		private static readonly MessageParser<BackpackInfo> _parser;

		public const int BackpackContentFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_backpackContent_codec;

		private readonly RepeatedField<int> backpackContent_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<BackpackInfo> Parser
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
		public RepeatedField<int> BackpackContent
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public BackpackInfo()
		{
		}

		[DebuggerNonUserCode]
		public BackpackInfo(BackpackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public BackpackInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(BackpackInfo other)
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
		public void MergeFrom(BackpackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
