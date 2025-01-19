public class WeaponEvent : BaseEvent
{
	public const int TYPE_ON = 1;

	public const int TYPE_OFF = 2;

	public const int TYPE_INIT = 3;

	public long servantId;

	public long weaponId;

	public int type;

	public WeaponEvent(long weaponId, int type)
	{
	}
}
