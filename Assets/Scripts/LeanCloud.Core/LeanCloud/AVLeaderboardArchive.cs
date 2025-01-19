using System;
using System.Collections.Generic;

namespace LeanCloud
{
	public class AVLeaderboardArchive
	{
		public string StatisticName { get; internal set; }

		public int Version { get; internal set; }

		public string Status { get; internal set; }

		public string Url { get; internal set; }

		public DateTime ActivatedAt { get; internal set; }

		public DateTime DeactivatedAt { get; internal set; }

		private AVLeaderboardArchive()
		{
		}

		internal static AVLeaderboardArchive Parse(IDictionary<string, object> data)
		{
			return null;
		}
	}
}
