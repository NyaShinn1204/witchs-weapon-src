using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class GuildInfoHelper
	{
		private static Dictionary<GlobalEnum.GuildPrivilege, List<GuildOperateEnum>> GuildPrivilegeToOpType;

		private static readonly GuildInfoHelper instance;

		public GuildUserManagerViewModel CacheGuildUserManagerViewModel { get; set; }

		private GuildInfoHelper()
		{
		}

		public static GuildInfoHelper GetInstance()
		{
			return null;
		}

		public static string CheckPrivilege(GuildOperateEnum op)
		{
			return null;
		}

		public static string CheckGuildOperation(GuildOperateEnum op, string argu)
		{
			return null;
		}

		public static bool CanDismissPresident()
		{
			return false;
		}

		public static long GetCanDismissPresidentRemainSecond()
		{
			return 0L;
		}

		public static long GetDismissPresidentSuccessRemainSecond()
		{
			return 0L;
		}

		public static string CanCreateGuild()
		{
			return null;
		}

		public static string CanRequestGuild(string id)
		{
			return null;
		}

		public static string CanHireServant(int mode, long svid, long rid)
		{
			return null;
		}

		public static int CanRecallOwnServant(long svid)
		{
			return 0;
		}

		public static TypeCsvInstallation GetGuildLevelCsv()
		{
			return null;
		}

		public static List<GuildLogAndTime> GetGuildLogContentList()
		{
			return null;
		}

		public static string ConvertGuildLog(GuildLog guildLog)
		{
			return null;
		}

		private static string GetGuildMemberName(List<string> input, string arguname)
		{
			return null;
		}

		public static List<GuildBuffData> GetGuildBuffs()
		{
			return null;
		}

		public static bool CanSendGuildInvite()
		{
			return false;
		}

		public static int GuildBuffBitToID(uint state)
		{
			return 0;
		}
	}
}
