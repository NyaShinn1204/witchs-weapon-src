using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ActivityListLua : IMessage<ActivityListLua>, IMessage, IEquatable<ActivityListLua>, IDeepCloneable<ActivityListLua>
	{
		private static readonly MessageParser<ActivityListLua> _parser;

		public const int ActivityInstanceProtosFieldNumber = 1;

		private static readonly FieldCodec<ActivityInstanceProto> _repeated_activityInstanceProtos_codec;

		private readonly RepeatedField<ActivityInstanceProto> activityInstanceProtos_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ActivityListLua> Parser
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
		public RepeatedField<ActivityInstanceProto> ActivityInstanceProtos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ActivityListLua()
		{
		}

		[DebuggerNonUserCode]
		public ActivityListLua(ActivityListLua other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityListLua Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityListLua other)
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
		public void MergeFrom(ActivityListLua other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
