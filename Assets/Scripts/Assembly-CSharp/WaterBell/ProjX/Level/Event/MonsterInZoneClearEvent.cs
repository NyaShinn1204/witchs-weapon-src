namespace WaterBell.ProjX.Level.Event
{
	public class MonsterInZoneClearEvent : ZoneBasedEvent
	{
		public bool isCombatOver;

		public MonsterInZoneClearEvent(int aIdx, int zIdx, bool isOver)
			: base(0, 0)
		{
		}
	}
}
