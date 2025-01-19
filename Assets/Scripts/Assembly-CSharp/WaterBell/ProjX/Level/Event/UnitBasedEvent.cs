namespace WaterBell.ProjX.Level.Event
{
	public abstract class UnitBasedEvent : LevelEventBase
	{
		protected CharacterBase unitCB;

		public UnitBasedEvent(CharacterBase cb)
		{
		}

		public CharacterBase GetUnit()
		{
			return null;
		}
	}
}
