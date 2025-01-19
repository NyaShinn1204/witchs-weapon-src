using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;

namespace Logmod
{
	public sealed class DrawResultByVersion : IMessage<DrawResultByVersion>, IMessage, IEquatable<DrawResultByVersion>, IDeepCloneable<DrawResultByVersion>
	{
		private static readonly MessageParser<DrawResultByVersion> _parser;

		public const int LootObjectFieldNumber = 1;

		private static readonly FieldCodec<LootObject> _repeated_lootObject_codec;

		private readonly RepeatedField<LootObject> lootObject_;

		public const int OtherDrawInfoFieldNumber = 2;

		private static readonly FieldCodec<OtherDrawInfo> _repeated_otherDrawInfo_codec;

		private readonly RepeatedField<OtherDrawInfo> otherDrawInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<DrawResultByVersion> Parser
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
		public RepeatedField<LootObject> LootObject
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<OtherDrawInfo> OtherDrawInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public DrawResultByVersion()
		{
		}

		[DebuggerNonUserCode]
		public DrawResultByVersion(DrawResultByVersion other)
		{
		}

		[DebuggerNonUserCode]
		public DrawResultByVersion Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DrawResultByVersion other)
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
		public void MergeFrom(DrawResultByVersion other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
