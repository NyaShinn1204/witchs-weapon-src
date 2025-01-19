namespace WaterBell.ProjX.Level.Event
{
	public abstract class AreaBasedEvent : LevelEventBase
	{
		protected int currAreaIdx;

		public AreaBasedEvent(int currAreaIdx)
		{
		}

		public int GetAreaIdx()
		{
			return 0;
		}
	}
}
