using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Storymod
{
	public sealed class Story : IMessage<Story>, IMessage, IEquatable<Story>, IDeepCloneable<Story>
	{
		private static readonly MessageParser<Story> _parser;

		public const int StoryGroupFieldNumber = 1;

		private static readonly MapField<long, StoryGroupInstance>.Codec _map_storyGroup_codec;

		private readonly MapField<long, StoryGroupInstance> storyGroup_;

		public const int VersionFieldNumber = 100;

		private int version_;

		public const int ActivityListFieldNumber = 101;

		private static readonly FieldCodec<long> _repeated_activityList_codec;

		private readonly RepeatedField<long> activityList_;

		public const int OpenActivityFieldNumber = 102;

		private long openActivity_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Story> Parser
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
		public MapField<long, StoryGroupInstance> StoryGroup
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> ActivityList
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long OpenActivity
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
		public Story()
		{
		}

		[DebuggerNonUserCode]
		public Story(Story other)
		{
		}

		[DebuggerNonUserCode]
		public Story Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Story other)
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
		public void MergeFrom(Story other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
