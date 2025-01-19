public class AnegyStateEvent : BaseEvent
{
	public const int TYPE_ENTER = 1;

	public const int TYPE_EXIST = 2;

	public int type;

	public AnegyStateEvent(int type)
	{
	}
}
