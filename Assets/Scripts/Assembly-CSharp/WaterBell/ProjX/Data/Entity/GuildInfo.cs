using System.Collections.Generic;
using Guildmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class GuildInfo
	{
		private string id;

		private long president;

		private List<long> admins;

		private List<GuildMemberInfo> members;

		private int shading;

		private int border;

		private int emblem;

		private string name;

		private string slogan;

		private int Logo;

		private long presidentLastOnline;

		private string notice;

		private double combatEffectiveness;

		private int MaxUsers;

		private List<GuildMemberInfo> requests;

		private bool IsSilent;

		private long recallTime;

		private long recallMember;

		private int vitality;

		private List<GuildBuff> guildBuffs;

		private List<GuildLog> guildLogs;

		public string ConversationID { get; set; }

		public long EmblemBackground { get; set; }

		public long EmblemBorder { get; set; }

		public long Emblem { get; set; }

		public int EmblemBackgroundColor { get; set; }

		public int EmblemBorderColor { get; set; }

		public int EmblemColor { get; set; }

		public long CombatEffectiveness { get; set; }

		public List<GuildBuff> GuildBuffList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GuildLog> GuildLogs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public List<long> Admins
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GuildMemberInfo> Members
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GuildMemberInfo> Requests
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public GuildInfo()
		{
		}

		public GuildInfo(Guild guild)
		{
		}

		private void RefreshBuffAddGold()
		{
		}

		private void RefreshBuffAddGuildCurrency()
		{
		}

		private void RefreshBuffAddExpeditionCurrency()
		{
		}

		private void RefreshBuffAddHP()
		{
		}

		private void RefreshBuffAddATK()
		{
		}

		private void RefreshBuffAddDEF()
		{
		}

		public void UpdateGuildMember(List<GuildMemberInfo> members)
		{
		}

		public void UpdateGuildAdmin(List<long> admins)
		{
		}

		public bool ContainUser(long id)
		{
			return false;
		}
	}
}
