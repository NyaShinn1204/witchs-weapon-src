public class BuffLifeLink : BuffEntity
{
	public const int TYPE_DAMAGE_AVERAGE = 1;

	public const int TYPE_DAMAGE_THE_SAME = 2;

	public int type;

	public float rate;

	public float critTimesOrigin;

	public float critTimesNotOrigin;

	public long BuffID;

	public float selfDamageRate;

	public int notSelf;

	public int noEntityDamage;

	public override void OnStart()
	{
	}
}
