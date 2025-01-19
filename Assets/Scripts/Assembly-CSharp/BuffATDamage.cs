using System.Collections.Generic;

public class BuffATDamage : BuffEntity
{
	public const int TYPE_PHYSIC = 1;

	public const int TYPE_MAGIC = 2;

	public const int TYPE_CONFIRM = 3;

	public int type;

	public float confirmRate;

	public float confirmDamage;

	public float physicRate;

	public float physicP;

	public float physicV;

	public float magicRate;

	public float magicP;

	public float magicV;

	public List<Entity> collection;

	public float rate;

	public int argType;

	public int arg1;

	public int arg2;

	public int arg3;

	public int arg4;

	public long arg5;

	public float limit;

	public override void OnStart()
	{
	}
}
