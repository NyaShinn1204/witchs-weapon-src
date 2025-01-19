using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ZoneRoleInfo
	{
		private static ZoneRoleInfo _instance;

		private Dictionary<string, string> zrDict;

		private Dictionary<string, SvrZone> svrZoneDict;

		private List<string> lastLoginZoneList;

		private SvrZone currZone;

		public static ZoneRoleInfo GetInstance()
		{
			return null;
		}

		public SvrZone GetCurrZone()
		{
			return null;
		}

		public void SetSvrZone(string zid)
		{
		}

		public void Clear()
		{
		}

		public void AddZRPair(string zid, string rid)
		{
		}

		public void AddSvrZone(SvrZone sz)
		{
		}

		public void AddLastLoginZone(string zid)
		{
		}

		public Dictionary<string, SvrZone> GetServerZoneDict()
		{
			return null;
		}

		public SvrZone GetLastVisitZone()
		{
			return null;
		}

		public SvrZone GetLatestZone()
		{
			return null;
		}

		public string GetExistedRoleIDOfZone(string zid)
		{
			return null;
		}
	}
}
