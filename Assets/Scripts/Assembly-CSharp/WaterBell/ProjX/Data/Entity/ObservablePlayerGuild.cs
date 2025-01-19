using System.Collections.Generic;
using Guildmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservablePlayerGuild : PropertyChangeedObservable
	{
		private bool isOpen;

		private int guildState;

		private string guildID;

		private int privilege;

		private long lastTimeLeaveGuild;

		private List<GuildSimple> requestGuildIDs;

		private GuildInfo guildInfo;

		private List<GuildSimple> cacheGuildList;

		private List<MercenaryServant> guildMercenaryList;

		private List<MercenaryServant> ownGuildMercenaryList;

		private List<int> mercenaryRewards;

		private Dictionary<int, List<MercenaryServant>> hiredMercenaryList;

		private long recallSuccessTime;

		private long canRecallTime;

		public int DonateCount { get; set; }

		public int TotalVitality { get; set; }

		public int DailyVitality { get; set; }

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int GuildState
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string GuildID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Privilege
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long LastTimeLeaveGuild
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public List<GuildSimple> RequestGuildIDs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GuildInfo GuildInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GuildSimple> CacheGuildList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long CanRecallTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long RecallSuccessTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public List<MercenaryServant> GuildMercenaryList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<MercenaryServant> OwnGuildMercenaryList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> MercenaryRewards
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<int, List<MercenaryServant>> HiredMercenaryList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObservablePlayerGuild()
		{
		}

		public ObservablePlayerGuild(Guild commmonInfo, UserGuild userInfo)
		{
		}

		public void UpdatePlayer(PropertyChangeedObservable target)
		{
		}

		public void SetContentByPro()
		{
		}

		private void CaculateRecall()
		{
		}

		public void UpdateContent(Guild commmonInfo, UserGuild userInfo)
		{
		}

		public void setContent(ObservablePlayerGuild guild)
		{
		}

		public void KickMember(long id)
		{
		}

		public void PromoteMember(long id)
		{
		}

		public void DemotionMember(long id)
		{
		}

		public void ResetPresident(long id)
		{
		}

		public void DismissPresident()
		{
		}

		public void Disbanded()
		{
		}

		public void Quit()
		{
		}

		public void Approve(long id)
		{
		}

		public GuildMemberInfo GetMember(long id)
		{
			return null;
		}

		private void RefreshCurrentRemainSeconds()
		{
		}

		public List<MercenaryServant> GetHiredMercenaryListByMode(int mode)
		{
			return null;
		}

		public MercenaryServant GetHiredMercenaryByModeAndId(int mode, long id)
		{
			return null;
		}

		public bool isHiredMercenaryListByMode(int mode, long id)
		{
			return false;
		}

		public MercenaryServant GetMercenaryServantBySvIDAndRoleID(long svID, long rid)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
