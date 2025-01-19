namespace WaterBell.ProjX.Level.Event
{
	public abstract class ZoneBasedEvent : LevelEventBase
	{
		protected int zoneIdx;

		protected int areaIdx;

		public ZoneBasedEvent(int aIdx, int zIdx)
		{
		}

		public int GetZoneIdx()
		{
			return 0;
		}

		public int GetAreaIdx()
		{
			return 0;
		}
	}
}
