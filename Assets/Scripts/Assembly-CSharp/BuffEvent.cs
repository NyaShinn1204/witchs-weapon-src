public class BuffEvent : BaseEvent
{
	public const int TYPE_BUFF_START = 1;

	public const int TYPE_BUFF_TRIGGER = 2;

	public const int TYPE_BUFF_INTERUPT = 3;

	public const int TYPE_BUFF_END = 4;

	public long buffID;

	public int type;

	public BuffEvent(long buffID, int type)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
