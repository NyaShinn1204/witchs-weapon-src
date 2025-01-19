using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud
{
	public class AVLeaderboard
	{
		public string StatisticName { get; private set; }

		public AVLeaderboardOrder Order { get; private set; }

		public AVLeaderboardUpdateStrategy UpdateStrategy { get; private set; }

		public AVLeaderboardVersionChangeInterval VersionChangeInterval { get; private set; }

		public int Version { get; private set; }

		public DateTime NextResetAt { get; private set; }

		public DateTime CreatedAt { get; private set; }

		private AVLeaderboard(string statisticName)
		{
		}

		private AVLeaderboard()
		{
		}

		public static Task<AVLeaderboard> CreateLeaderboard(string statisticName, AVLeaderboardOrder order = AVLeaderboardOrder.DESCENDING, AVLeaderboardUpdateStrategy updateStrategy = AVLeaderboardUpdateStrategy.BETTER, AVLeaderboardVersionChangeInterval versionChangeInterval = AVLeaderboardVersionChangeInterval.WEEK)
		{
			return null;
		}

		public static AVLeaderboard CreateWithoutData(string statisticName)
		{
			return null;
		}

		public static Task<AVLeaderboard> GetLeaderboard(string statisticName)
		{
			return null;
		}

		public static Task<List<AVStatistic>> UpdateStatistics(AVUser user, Dictionary<string, double> statistics, bool overwrite = false)
		{
			return null;
		}

		public static Task<List<AVStatistic>> GetStatistics(AVUser user, List<string> statisticNames = null)
		{
			return null;
		}

		public static Task DeleteStatistics(AVUser user, List<string> statisticNames)
		{
			return null;
		}

		public Task<List<AVLeaderboardArchive>> GetArchives(int skip = 0, int limit = 10)
		{
			return null;
		}

		public Task<List<AVRanking>> GetResults(int version = -1, int skip = 0, int limit = 10, List<string> selectUserKeys = null, List<string> includeStatistics = null)
		{
			return null;
		}

		public Task<List<AVRanking>> GetResultsAroundUser(int version = -1, int skip = 0, int limit = 10, List<string> selectUserKeys = null, List<string> includeStatistics = null)
		{
			return null;
		}

		private Task<List<AVRanking>> GetResults(AVUser user, int version, int skip, int limit, List<string> selectUserKeys, List<string> includeStatistics)
		{
			return null;
		}

		public Task<AVLeaderboard> UpdateUpdateStrategy(AVLeaderboardUpdateStrategy updateStrategy)
		{
			return null;
		}

		public Task<AVLeaderboard> UpdateVersionChangeInterval(AVLeaderboardVersionChangeInterval versionChangeInterval)
		{
			return null;
		}

		private Task<IDictionary<string, object>> Update(Dictionary<string, object> data)
		{
			return null;
		}

		public Task<AVLeaderboard> Fetch()
		{
			return null;
		}

		public Task<AVLeaderboard> Reset()
		{
			return null;
		}

		public Task Destroy()
		{
			return null;
		}

		private static AVLeaderboard Parse(IDictionary<string, object> data)
		{
			return null;
		}

		private void Init(IDictionary<string, object> data)
		{
		}
	}
}
