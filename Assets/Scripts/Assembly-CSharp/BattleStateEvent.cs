public class BattleStateEvent : BaseEvent
{
	public const int TYPE_ENTER = 1;

	public const int TYPE_EXIST = 2;

	public int type;

	public BattleStateEvent(int type)
	{
	}
}
