using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ActivityCamp : IMessage<ActivityCamp>, IMessage, IEquatable<ActivityCamp>, IDeepCloneable<ActivityCamp>
	{
		private static readonly MessageParser<ActivityCamp> _parser;

		public const int CurStamFieldNumber = 1;

		private int curStam_;

		public const int TopStamFieldNumber = 2;

		private int topStam_;

		public const int CurRmbFieldNumber = 3;

		private int curRmb_;

		public const int TopRmbFieldNumber = 4;

		private int topRmb_;

		public const int CanRewardTagFieldNumber = 5;

		private int canRewardTag_;

		public const int RewardTagFieldNumber = 6;

		private int rewardTag_;

		public const int CampInfoFieldNumber = 7;

		private static readonly FieldCodec<ActivityCampInfo> _repeated_campInfo_codec;

		private readonly RepeatedField<ActivityCampInfo> campInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ActivityCamp> Parser
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
		public int CurStam
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
		public int TopStam
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
		public int CurRmb
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
		public int TopRmb
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
		public int CanRewardTag
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
		public int RewardTag
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
		public RepeatedField<ActivityCampInfo> CampInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ActivityCamp()
		{
		}

		[DebuggerNonUserCode]
		public ActivityCamp(ActivityCamp other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityCamp Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityCamp other)
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
		public void MergeFrom(ActivityCamp other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
