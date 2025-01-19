using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ActivityList : IMessage<ActivityList>, IMessage, IEquatable<ActivityList>, IDeepCloneable<ActivityList>
	{
		private static readonly MessageParser<ActivityList> _parser;

		public const int ActivityInstanceProtoMapFieldNumber = 1;

		private static readonly MapField<long, ActivityInstanceProto>.Codec _map_activityInstanceProtoMap_codec;

		private readonly MapField<long, ActivityInstanceProto> activityInstanceProtoMap_;

		public const int UniqueFieldNumber = 2;

		private static readonly MapField<long, bool>.Codec _map_unique_codec;

		private readonly MapField<long, bool> unique_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ActivityList> Parser
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
		public MapField<long, ActivityInstanceProto> ActivityInstanceProtoMap
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, bool> Unique
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ActivityList()
		{
		}

		[DebuggerNonUserCode]
		public ActivityList(ActivityList other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityList Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityList other)
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
		public void MergeFrom(ActivityList other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
