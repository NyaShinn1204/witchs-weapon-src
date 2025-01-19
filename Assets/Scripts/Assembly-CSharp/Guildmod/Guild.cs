using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class Guild : IMessage<Guild>, IMessage, IEquatable<Guild>, IDeepCloneable<Guild>
	{
		private static readonly MessageParser<Guild> _parser;

		public const int IDFieldNumber = 1;

		private string iD_;

		public const int PresidentFieldNumber = 2;

		private long president_;

		public const int AdminsFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_admins_codec;

		private readonly RepeatedField<long> admins_;

		public const int MembersFieldNumber = 4;

		private static readonly FieldCodec<SimpleInfo> _repeated_members_codec;

		private readonly RepeatedField<SimpleInfo> members_;

		public const int NameFieldNumber = 5;

		private string name_;

		public const int LevelFieldNumber = 18;

		private int level_;

		public const int SloganFieldNumber = 6;

		private string slogan_;

		public const int LogoFieldNumber = 7;

		private int logo_;

		public const int PresidentLastOnlineFieldNumber = 8;

		private long presidentLastOnline_;

		public const int NoticeFieldNumber = 9;

		private string notice_;

		public const int CEFieldNumber = 10;

		private long cE_;

		public const int MaxUsersFieldNumber = 11;

		private int maxUsers_;

		public const int RequestsFieldNumber = 12;

		private static readonly FieldCodec<SimpleInfo> _repeated_requests_codec;

		private readonly RepeatedField<SimpleInfo> requests_;

		public const int VitalityFieldNumber = 13;

		private int vitality_;

		public const int IsSilentFieldNumber = 14;

		private bool isSilent_;

		public const int RecallTimeFieldNumber = 15;

		private long recallTime_;

		public const int RecallMemberFieldNumber = 16;

		private long recallMember_;

		public const int LogsFieldNumber = 17;

		private static readonly FieldCodec<GuildLog> _repeated_logs_codec;

		private readonly RepeatedField<GuildLog> logs_;

		public const int AVGPTFieldNumber = 19;

		private int aVGPT_;

		public const int ApplyCountFieldNumber = 20;

		private int applyCount_;

		public const int ConversationIDFieldNumber = 21;

		private string conversationID_;

		public const int BuffFieldNumber = 22;

		private uint buff_;

		public const int LastBuffTimeFieldNumber = 27;

		private long lastBuffTime_;

		public const int EmblemFieldNumber = 24;

		private long emblem_;

		public const int EmblemColorFieldNumber = 28;

		private int emblemColor_;

		public const int EmblemBorderFieldNumber = 25;

		private long emblemBorder_;

		public const int EmblemBorderColorFieldNumber = 29;

		private int emblemBorderColor_;

		public const int EmblemBackgroundFieldNumber = 26;

		private long emblemBackground_;

		public const int EmblemBackgroundColorFieldNumber = 30;

		private int emblemBackgroundColor_;

		public const int RoleCEFieldNumber = 31;

		private static readonly MapField<long, double>.Codec _map_roleCE_codec;

		private readonly MapField<long, double> roleCE_;

		public const int LastCETimeFieldNumber = 32;

		private long lastCETime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Guild> Parser
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
		public string ID
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
		public long President
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
		public RepeatedField<long> Admins
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<SimpleInfo> Members
		{
			get
			{
				return null;
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
		public string Slogan
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
		public int Logo
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
		public long PresidentLastOnline
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
		public string Notice
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
		public long CE
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
		public int MaxUsers
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
		public RepeatedField<SimpleInfo> Requests
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Vitality
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
		public bool IsSilent
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
		public long RecallTime
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
		public long RecallMember
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
		public RepeatedField<GuildLog> Logs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int AVGPT
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
		public int ApplyCount
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
		public string ConversationID
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
		public uint Buff
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long LastBuffTime
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
		public long Emblem
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
		public int EmblemColor
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
		public long EmblemBorder
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
		public int EmblemBorderColor
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
		public long EmblemBackground
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
		public int EmblemBackgroundColor
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
		public MapField<long, double> RoleCE
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long LastCETime
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
		public Guild()
		{
		}

		[DebuggerNonUserCode]
		public Guild(Guild other)
		{
		}

		[DebuggerNonUserCode]
		public Guild Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Guild other)
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
		public void MergeFrom(Guild other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
