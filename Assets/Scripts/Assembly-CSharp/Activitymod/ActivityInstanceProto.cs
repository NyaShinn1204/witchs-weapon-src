using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ActivityInstanceProto : IMessage<ActivityInstanceProto>, IMessage, IEquatable<ActivityInstanceProto>, IDeepCloneable<ActivityInstanceProto>
	{
		private static readonly MessageParser<ActivityInstanceProto> _parser;

		public const int ActivityTypeFieldNumber = 1;

		private int activityType_;

		public const int BaseIDFieldNumber = 2;

		private long baseID_;

		public const int StartTimeFieldNumber = 3;

		private long startTime_;

		public const int EndTimeFieldNumber = 4;

		private long endTime_;

		public const int CloseTimeFieldNumber = 5;

		private long closeTime_;

		public const int FinishedFieldNumber = 6;

		private bool finished_;

		public const int DaysSignFieldNumber = 100;

		private DaysSign daysSign_;

		public const int RechargeRewardFieldNumber = 101;

		private RechargeReward rechargeReward_;

		public const int RoleLevelRewardFieldNumber = 102;

		private RoleLevelReward roleLevelReward_;

		public const int InstanceRewardFieldNumber = 103;

		private InstanceReward instanceReward_;

		public const int SpecialActivityDrawFieldNumber = 104;

		private SpecialActivityDraw specialActivityDraw_;

		public const int BonusStaminaFieldNumber = 105;

		private BonusStamina bonusStamina_;

		public const int DaysSignIntimeFieldNumber = 106;

		private DaysSignIntime daysSignIntime_;

		public const int DaysSignAutoFieldNumber = 107;

		private DaysSignAuto daysSignAuto_;

		public const int DaysSignContinuityFieldNumber = 108;

		private DaysSignContinuity daysSignContinuity_;

		public const int BuyBoxFieldNumber = 109;

		private BuyBox buyBox_;

		public const int RoleStoryFieldNumber = 110;

		private RoleStory roleStory_;

		public const int RoleMissionFieldNumber = 111;

		private RoleMission roleMission_;

		public const int StoryFieldNumber = 112;

		private static readonly MapField<long, bool>.Codec _map_story_codec;

		private readonly MapField<long, bool> story_;

		public const int CampFieldNumber = 113;

		private int camp_;

		public const int CampTypeFieldNumber = 114;

		private int campType_;

		public const int DrawTimesFieldNumber = 115;

		private int drawTimes_;

		public const int ActivityCampFieldNumber = 116;

		private ActivityCamp activityCamp_;

		public const int SubActivityFieldNumber = 117;

		private SubActivity subActivity_;

		public const int ChallengeInfoFieldNumber = 118;

		private ChallengeInfo challengeInfo_;

		public const int PersonDrawFieldNumber = 119;

		private PersonDraw personDraw_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ActivityInstanceProto> Parser
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
		public int ActivityType
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
		public long BaseID
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
		public long StartTime
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
		public long EndTime
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
		public long CloseTime
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
		public bool Finished
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
		public DaysSign DaysSign
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
		public RechargeReward RechargeReward
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
		public RoleLevelReward RoleLevelReward
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
		public InstanceReward InstanceReward
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
		public SpecialActivityDraw SpecialActivityDraw
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
		public BonusStamina BonusStamina
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
		public DaysSignIntime DaysSignIntime
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
		public DaysSignAuto DaysSignAuto
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
		public DaysSignContinuity DaysSignContinuity
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
		public BuyBox BuyBox
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
		public RoleStory RoleStory
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
		public RoleMission RoleMission
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
		public MapField<long, bool> Story
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Camp
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
		public int CampType
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
		public int DrawTimes
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
		public ActivityCamp ActivityCamp
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
		public SubActivity SubActivity
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
		public ChallengeInfo ChallengeInfo
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
		public PersonDraw PersonDraw
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
		public ActivityInstanceProto()
		{
		}

		[DebuggerNonUserCode]
		public ActivityInstanceProto(ActivityInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public ActivityInstanceProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ActivityInstanceProto other)
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
		public void MergeFrom(ActivityInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
