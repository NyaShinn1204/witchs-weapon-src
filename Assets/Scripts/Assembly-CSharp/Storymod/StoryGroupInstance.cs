using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Storymod
{
	public sealed class StoryGroupInstance : IMessage<StoryGroupInstance>, IMessage, IEquatable<StoryGroupInstance>, IDeepCloneable<StoryGroupInstance>
	{
		private static readonly MessageParser<StoryGroupInstance> _parser;

		public const int SequenceStoryFieldNumber = 1;

		private static readonly FieldCodec<StoryInstance> _repeated_sequenceStory_codec;

		private readonly RepeatedField<StoryInstance> sequenceStory_;

		public const int SeparatedStoryFieldNumber = 2;

		private static readonly MapField<long, StoryInstance>.Codec _map_separatedStory_codec;

		private readonly MapField<long, StoryInstance> separatedStory_;

		public const int UnlockFieldNumber = 100;

		private bool unlock_;

		public const int ActivityFieldNumber = 101;

		private bool activity_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<StoryGroupInstance> Parser
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
		public RepeatedField<StoryInstance> SequenceStory
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, StoryInstance> SeparatedStory
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool Unlock
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
		public bool Activity
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
		public StoryGroupInstance()
		{
		}

		[DebuggerNonUserCode]
		public StoryGroupInstance(StoryGroupInstance other)
		{
		}

		[DebuggerNonUserCode]
		public StoryGroupInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(StoryGroupInstance other)
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
		public void MergeFrom(StoryGroupInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
