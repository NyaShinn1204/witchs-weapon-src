using System;

namespace LeanCloud.Core.Internal
{
	public class AppRouterState
	{
		private static object mutex;

		public long TTL { get; internal set; }

		public string ApiServer { get; internal set; }

		public string EngineServer { get; internal set; }

		public string PushServer { get; internal set; }

		public string RealtimeRouterServer { get; internal set; }

		public string StatsServer { get; internal set; }

		public string Source { get; internal set; }

		public DateTime FetchedAt { get; internal set; }

		public bool isExpired()
		{
			return false;
		}

		public static AppRouterState GetInitial(string appId, AVClient.Configuration.AVRegion region)
		{
			return null;
		}
	}
}
