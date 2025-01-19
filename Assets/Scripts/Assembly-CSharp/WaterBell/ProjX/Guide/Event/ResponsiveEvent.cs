using WaterBell.Framework.Event;

namespace WaterBell.ProjX.Guide.Event
{
	public class ResponsiveEvent : EventBase
	{
		public ResponsiveEvtType type;

		public ResponsiveEvent()
		{
		}

		public ResponsiveEvent(ResponsiveEvtType evtType)
		{
		}
	}
}
