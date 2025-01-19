public class BuffDamageToHeal : BuffEntity
{
	public float rate;

	public int typeTag;

	public override void OnStart()
	{
	}

	public bool IsValid(int typeTag)
	{
		return false;
	}
}
