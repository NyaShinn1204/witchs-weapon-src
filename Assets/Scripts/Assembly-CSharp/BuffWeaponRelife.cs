public class BuffWeaponRelife : BuffEntity
{
	public long mobId;

	public int max;

	public float rate;

	public float hpPercent;

	public float hpPercentBasic;

	public float hpPercentGrow;

	public float pAtkPercent;

	public float pAtkPercentBasic;

	public float pAtkPercentGrow;

	public float mAtkPercent;

	public float mAtkPercentBasic;

	public float mAtkPercentGrow;

	public override void OnStart()
	{
	}

	protected override void _OnInterupt()
	{
	}
}
