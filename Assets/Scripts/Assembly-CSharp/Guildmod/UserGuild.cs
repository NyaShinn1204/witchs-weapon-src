using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class UserGuild : IMessage<UserGuild>, IMessage, IEquatable<UserGuild>, IDeepCloneable<UserGuild>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Guild : IMessage<Guild>, IMessage, IEquatable<Guild>, IDeepCloneable<Guild>
			{
				private static readonly MessageParser<Guild> _parser;

				public const int IDFieldNumber = 1;

				private string iD_;

				public const int NameFieldNumber = 2;

				private string name_;

				public const int TimeFieldNumber = 3;

				private long time_;

				public const int EmblemFieldNumber = 4;

				private long emblem_;

				public const int EmblemColorFieldNumber = 7;

				private int emblemColor_;

				public const int EmblemBorderFieldNumber = 5;

				private long emblemBorder_;

				public const int EmblemBorderColorFieldNumber = 8;

				private int emblemBorderColor_;

				public const int EmblemBackgroundFieldNumber = 6;

				private long emblemBackground_;

				public const int EmblemBackgroundColorFieldNumber = 9;

				private int emblemBackgroundColor_;

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
				public long Time
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

		private static readonly MessageParser<UserGuild> _parser;

		public const int BelongToFieldNumber = 2;

		private string belongTo_;

		public const int RequestsFieldNumber = 3;

		private static readonly FieldCodec<Types.Guild> _repeated_requests_codec;

		private readonly RepeatedField<Types.Guild> requests_;

		public const int LeaveTimeFieldNumber = 5;

		private long leaveTime_;

		public const int MercenariesFieldNumber = 6;

		private static readonly FieldCodec<long> _repeated_mercenaries_codec;

		private readonly RepeatedField<long> mercenaries_;

		public const int DonateCountFieldNumber = 7;

		private int donateCount_;

		public const int LastDonateFieldNumber = 8;

		private long lastDonate_;

		public const int TotalVitalityFieldNumber = 9;

		private int totalVitality_;

		public const int DailyVitalityFieldNumber = 10;

		private int dailyVitality_;

		public const int JoinCountFieldNumber = 11;

		private int joinCount_;

		public const int TotalEmployCountFieldNumber = 12;

		private int totalEmployCount_;

		public const int UnsettledGoldFieldNumber = 13;

		private int unsettledGold_;

		public const int UnsettledGuildCoinFieldNumber = 14;

		private int unsettledGuildCoin_;

		public const int TodayMercenaryGoldFieldNumber = 15;

		private int todayMercenaryGold_;

		public const int MercenaryGoldTimeFieldNumber = 16;

		private long mercenaryGoldTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<UserGuild> Parser
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
		public string BelongTo
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
		public RepeatedField<Types.Guild> Requests
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long LeaveTime
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
		public RepeatedField<long> Mercenaries
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int DonateCount
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
		public long LastDonate
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
		public int TotalVitality
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
		public int DailyVitality
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
		public int JoinCount
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
		public int TotalEmployCount
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
		public int UnsettledGold
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
		public int UnsettledGuildCoin
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
		public int TodayMercenaryGold
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
		public long MercenaryGoldTime
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
		public UserGuild()
		{
		}

		[DebuggerNonUserCode]
		public UserGuild(UserGuild other)
		{
		}

		[DebuggerNonUserCode]
		public UserGuild Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UserGuild other)
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
		public void MergeFrom(UserGuild other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
