using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	internal class SystemNoticeMngr
	{
		private static SystemNoticeMngr _instance;

		public GameEntryNotice gameEntryNotice;

		public List<ZoneEntryNotice> zoneEntryNoticeList;

		public List<ZoneEntryNotice> popZoneEntryNoticeList;

		public int CurrentZoneNoticeIndex;

		public int CurrentPopZoneNoticeIndex;

		public static SystemNoticeMngr GetInstance()
		{
			return null;
		}
	}
}
