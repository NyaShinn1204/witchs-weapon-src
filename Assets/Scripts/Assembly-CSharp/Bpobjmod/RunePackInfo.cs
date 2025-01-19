using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class RunePackInfo : IMessage<RunePackInfo>, IMessage, IEquatable<RunePackInfo>, IDeepCloneable<RunePackInfo>
	{
		private static readonly MessageParser<RunePackInfo> _parser;

		public const int RuneInfosFieldNumber = 1;

		private static readonly FieldCodec<RuneInfo> _repeated_runeInfos_codec;

		private readonly RepeatedField<RuneInfo> runeInfos_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RunePackInfo> Parser
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
		public RepeatedField<RuneInfo> RuneInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RunePackInfo()
		{
		}

		[DebuggerNonUserCode]
		public RunePackInfo(RunePackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RunePackInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RunePackInfo other)
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
		public void MergeFrom(RunePackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
