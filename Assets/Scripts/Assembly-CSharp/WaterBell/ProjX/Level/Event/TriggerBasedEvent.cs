namespace WaterBell.ProjX.Level.Event
{
	public abstract class TriggerBasedEvent : LevelEventBase
	{
		protected int srcTriggerID;

		public TriggerBasedEvent(int srcID)
		{
		}

		public int GetSrcTriggerID()
		{
			return 0;
		}
	}
}
