public class HealthPack : BasePack
{
	public const int OVER_HEAL = 1;

	public Entity source;

	public float healValue;

	public int typeTag;

	public string attackerName;

	public bool isSteal;

	public bool isNoshow;

	public int healtag;

	public int overhealtype;

	public HealthPack(Entity source, float value, int healtag, int typeTag = 0)
	{
	}
}
