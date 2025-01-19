public class BuffModifyAtkInterval : BuffEntity
{
	public float rate;

	public float basic;

	public int grow;

	private float first_attack_interval_lower;

	private float first_attack_interval_upper;

	private float attack_interval_lower;

	private float attack_interval_upper;

	private float baseValue;

	public override void OnStart()
	{
	}

	protected override void AfterInit(int beforeLayerCount, int afterLayerCount)
	{
	}

	public override void OnDestory()
	{
	}
}
