namespace WaterBell.Framework.Event
{
	public delegate void EventHandler<T>(T e) where T : EventBase;
}
