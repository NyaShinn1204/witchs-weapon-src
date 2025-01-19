public class BuffModifyHeal : BuffEntity
{
	public float HealMP;

	public float HealMV;

	public float MHealMV;

	public int typeTag;

	public override void OnStart()
	{
	}

	public bool IsValid(int typeTag)
	{
		return false;
	}
}
