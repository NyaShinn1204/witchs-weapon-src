using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Levelmod;

namespace Activitymod
{
	public sealed class RoleStory : IMessage<RoleStory>, IMessage, IEquatable<RoleStory>, IDeepCloneable<RoleStory>
	{
		private static readonly MessageParser<RoleStory> _parser;

		public const int DayTimesFieldNumber = 1;

		private int dayTimes_;

		public const int DayFieldNumber = 2;

		private int day_;

		public const int StorysFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_storys_codec;

		private readonly RepeatedField<long> storys_;

		public const int HighTimesFieldNumber = 4;

		private int highTimes_;

		public const int NormalInstancesFieldNumber = 5;

		private static readonly FieldCodec<Level> _repeated_normalInstances_codec;

		private readonly RepeatedField<Level> normalInstances_;

		public const int ChallengeInstancesFieldNumber = 6;

		private static readonly FieldCodec<Level> _repeated_challengeInstances_codec;

		private readonly RepeatedField<Level> challengeInstances_;

		public const int ChallengeInstanceSetFieldNumber = 7;

		private static readonly FieldCodec<ChallengeInstanceSet> _repeated_challengeInstanceSet_codec;

		private readonly RepeatedField<ChallengeInstanceSet> challengeInstanceSet_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleStory> Parser
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
		public int DayTimes
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
		public int Day
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
		public RepeatedField<long> Storys
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int HighTimes
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
		public RepeatedField<Level> NormalInstances
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Level> ChallengeInstances
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ChallengeInstanceSet> ChallengeInstanceSet
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RoleStory()
		{
		}

		[DebuggerNonUserCode]
		public RoleStory(RoleStory other)
		{
		}

		[DebuggerNonUserCode]
		public RoleStory Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleStory other)
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
		public void MergeFrom(RoleStory other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
