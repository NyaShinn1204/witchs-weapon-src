using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Lootmod;
using Storymod;

namespace Api
{
	public sealed class StoryResult : IMessage<StoryResult>, IMessage, IEquatable<StoryResult>, IDeepCloneable<StoryResult>
	{
		private static readonly MessageParser<StoryResult> _parser;

		public const int StoryFieldNumber = 1;

		private Story story_;

		public const int LootResultFieldNumber = 2;

		private static readonly FieldCodec<LootObject> _repeated_lootResult_codec;

		private readonly RepeatedField<LootObject> lootResult_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<StoryResult> Parser
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
		public Story Story
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
		public RepeatedField<LootObject> LootResult
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public StoryResult()
		{
		}

		[DebuggerNonUserCode]
		public StoryResult(StoryResult other)
		{
		}

		[DebuggerNonUserCode]
		public StoryResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(StoryResult other)
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
		public void MergeFrom(StoryResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
