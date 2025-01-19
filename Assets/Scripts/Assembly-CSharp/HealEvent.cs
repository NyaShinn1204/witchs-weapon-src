public class HealEvent : BaseEvent
{
	public Entity healer;

	public Entity defencer;

	public float bloodCut;

	public int typeTag;

	public int damageTag;

	public float overHeal;

	public int healTag;

	public int overhealtype;

	public HealEvent(Entity healer, int typetag)
	{
	}
}
