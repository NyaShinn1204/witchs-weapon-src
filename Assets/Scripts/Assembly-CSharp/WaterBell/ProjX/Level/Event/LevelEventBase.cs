using WaterBell.Framework.Event;

namespace WaterBell.ProjX.Level.Event
{
	public abstract class LevelEventBase : EventBase
	{
		protected LevelEventName evtName;

		public LevelEventName getEventName()
		{
			return default(LevelEventName);
		}
	}
}
