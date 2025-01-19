using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class RoleInstanceProto : IMessage<RoleInstanceProto>, IMessage, IEquatable<RoleInstanceProto>, IDeepCloneable<RoleInstanceProto>
	{
		private static readonly MessageParser<RoleInstanceProto> _parser;

		public const int HeadFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_head_codec;

		private readonly RepeatedField<int> head_;

		public const int HeadBoxFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_headBox_codec;

		private readonly RepeatedField<int> headBox_;

		public const int TitleFieldNumber = 3;

		private static readonly FieldCodec<int> _repeated_title_codec;

		private readonly RepeatedField<int> title_;

		public const int ActionFieldNumber = 4;

		private static readonly FieldCodec<int> _repeated_action_codec;

		private readonly RepeatedField<int> action_;

		public const int BoardFieldNumber = 5;

		private static readonly FieldCodec<int> _repeated_board_codec;

		private readonly RepeatedField<int> board_;

		public const int MonthCardDaysFieldNumber = 6;

		private static readonly FieldCodec<int> _repeated_monthCardDays_codec;

		private readonly RepeatedField<int> monthCardDays_;

		public const int MonthCardSendFieldNumber = 7;

		private static readonly FieldCodec<bool> _repeated_monthCardSend_codec;

		private readonly RepeatedField<bool> monthCardSend_;

		public const int TimedRmbFieldNumber = 8;

		private static readonly FieldCodec<TimedRmb> _repeated_timedRmb_codec;

		private readonly RepeatedField<TimedRmb> timedRmb_;

		public const int GameCampFieldNumber = 9;

		private static readonly MapField<int, int>.Codec _map_gameCamp_codec;

		private readonly MapField<int, int> gameCamp_;

		public const int PrivilegesFieldNumber = 10;

		private static readonly MapField<int, Privilege>.Codec _map_privileges_codec;

		private readonly MapField<int, Privilege> privileges_;

		public const int RoleIDFieldNumber = 101;

		private long roleID_;

		public const int VipFieldNumber = 102;

		private int vip_;

		public const int RmbFieldNumber = 103;

		private long rmb_;

		public const int LevelFieldNumber = 104;

		private int level_;

		public const int GoldFieldNumber = 105;

		private long gold_;

		public const int ExpFieldNumber = 106;

		private long exp_;

		public const int StaminaFieldNumber = 107;

		private int stamina_;

		public const int StaminaTimeFieldNumber = 108;

		private long staminaTime_;

		public const int FavorFieldNumber = 109;

		private long favor_;

		public const int FirstDrawsFieldNumber = 110;

		private int firstDraws_;

		public const int NameFieldNumber = 111;

		private string name_;

		public const int CscCurrencyFieldNumber = 112;

		private int cscCurrency_;

		public const int ActiveCurrencyRedFieldNumber = 113;

		private int activeCurrencyRed_;

		public const int ActiveCurrencyYellowFieldNumber = 114;

		private int activeCurrencyYellow_;

		public const int ActiveCurrencyBlueFieldNumber = 115;

		private int activeCurrencyBlue_;

		public const int ActiveCurrencyGreenFieldNumber = 116;

		private int activeCurrencyGreen_;

		public const int ChallengeFieldNumber = 117;

		private int challenge_;

		public const int CurHeadFieldNumber = 118;

		private int curHead_;

		public const int CurHeadBoxFieldNumber = 119;

		private int curHeadBox_;

		public const int GuildCurrencyFieldNumber = 120;

		private int guildCurrency_;

		public const int ActivityStaminaFieldNumber = 121;

		private int activityStamina_;

		public const int ActivityStaminaTimeFieldNumber = 122;

		private long activityStaminaTime_;

		public const int CurTitleFieldNumber = 123;

		private int curTitle_;

		public const int VipExpFieldNumber = 124;

		private int vipExp_;

		public const int VipPointFieldNumber = 125;

		private int vipPoint_;

		public const int DrawCurrencyFieldNumber = 126;

		private int drawCurrency_;

		public const int CurBoardFieldNumber = 127;

		private int curBoard_;

		public const int StoryCurrencyFieldNumber = 128;

		private int storyCurrency_;

		public const int ActivityStoryCurrencyFieldNumber = 129;

		private int activityStoryCurrency_;

		public const int PlatFormFieldNumber = 130;

		private int platForm_;

		public const int HackFieldNumber = 131;

		private Hack hack_;

		public const int CredibleFieldNumber = 132;

		private int credible_;

		public const int BindPhoneFieldNumber = 133;

		private int bindPhone_;

		public const int BindIdentityFieldNumber = 134;

		private int bindIdentity_;

		public const int RecycleCurrencyFieldNumber = 135;

		private int recycleCurrency_;

		public const int RealRmbFieldNumber = 136;

		private long realRmb_;

		public const int RmbScoreFieldNumber = 137;

		private int rmbScore_;

		public const int CreateDateFieldNumber = 138;

		private string createDate_;

		public const int UpdateDateFieldNumber = 139;

		private string updateDate_;

		public const int UpdateIpFieldNumber = 140;

		private string updateIp_;

		public const int RealRmbIosFieldNumber = 141;

		private long realRmbIos_;

		public const int TwCBTRewardFieldNumber = 142;

		private bool twCBTReward_;

		public const int UserIDFieldNumber = 143;

		private long userID_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleInstanceProto> Parser
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
		public RepeatedField<int> Head
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> HeadBox
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Title
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Action
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Board
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> MonthCardDays
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<bool> MonthCardSend
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<TimedRmb> TimedRmb
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<int, int> GameCamp
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<int, Privilege> Privileges
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long RoleID
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
		public int Vip
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
		public long Rmb
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
		public int Level
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
		public long Gold
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
		public long Exp
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
		public int Stamina
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
		public long StaminaTime
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
		public long Favor
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
		public int FirstDraws
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
		public string Name
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
		public int CscCurrency
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
		public int ActiveCurrencyRed
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
		public int ActiveCurrencyYellow
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
		public int ActiveCurrencyBlue
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
		public int ActiveCurrencyGreen
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
		public int Challenge
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
		public int CurHead
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
		public int CurHeadBox
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
		public int GuildCurrency
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
		public int ActivityStamina
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
		public long ActivityStaminaTime
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
		public int CurTitle
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
		public int VipExp
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
		public int VipPoint
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
		public int DrawCurrency
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
		public int CurBoard
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
		public int StoryCurrency
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
		public int ActivityStoryCurrency
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
		public int PlatForm
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
		public Hack Hack
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
		public int Credible
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
		public int BindPhone
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
		public int BindIdentity
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
		public int RecycleCurrency
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
		public long RealRmb
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
		public int RmbScore
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
		public string CreateDate
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
		public string UpdateDate
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
		public string UpdateIp
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
		public long RealRmbIos
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
		public bool TwCBTReward
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
		public long UserID
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
		public RoleInstanceProto()
		{
		}

		[DebuggerNonUserCode]
		public RoleInstanceProto(RoleInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public RoleInstanceProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleInstanceProto other)
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
		public void MergeFrom(RoleInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
