using System.Collections.Generic;

namespace LeanCloud
{
	public class AVRanking
	{
		public int Rank { get; private set; }

		public AVUser User { get; private set; }

		public string StatisticName { get; private set; }

		public double Value { get; private set; }

		public List<AVStatistic> IncludedStatistics { get; private set; }

		private AVRanking()
		{
		}

		internal static AVRanking Parse(IDictionary<string, object> data)
		{
			return null;
		}
	}
}
