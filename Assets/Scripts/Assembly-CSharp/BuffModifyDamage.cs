public class BuffModifyDamage : BuffEntity
{
	public float PDmgMP;

	public float PDmgMV;

	public float MPDmgMV;

	public float MDmgMP;

	public float MDmgMV;

	public float MMDmgMV;

	public float CDmgMP;

	public float CDmgMV;

	public float MCDmgMV;

	public int typeTag;

	public int modifyType;

	public int attributeId;

	public float rate;

	public int damagetype;

	public override void OnStart()
	{
	}

	public bool IsValid(int typeTag)
	{
		return false;
	}

	public float getattributeValue()
	{
		return 0f;
	}
}
