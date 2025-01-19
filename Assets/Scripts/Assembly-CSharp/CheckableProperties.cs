public class CheckableProperties : ICheckable
{
	private float[] baseProps;

	private float[] compareProps;

	private float maxWeaponAtk;

	private float suspect;

	public double Check()
	{
		return 0.0;
	}

	public void CollectProp(PropertiesVO vo, bool forBase = false)
	{
	}

	public void SetMaxWeaponAtk(float weaponAtk)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
