public class PowerEvent : BaseEvent
{
	public const int POWER_FULL = 1;

	public const int POWER_NOT_FULL = 2;

	public long servantID;

	public int type;

	public PowerEvent(long servantID, int type)
	{
	}
}
