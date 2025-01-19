using UnityEngine;

public class VectorPack : BasePack
{
	public const int STACK_TYPE_POSITIVE = 1;

	public const int STACK_TYPE_NAGETIVE = 2;

	public float maxDuration;

	public float speed;

	public Vector3 direction;

	public Skill skill;

	public int stackType;

	public bool isRemoveCollider;

	public bool isStun;

	public string performance;

	public bool isInvoke;

	public bool invokedRemoveCollider;

	public VectorPack(float maxDuration, Vector3 direction, float speed, int stackType, Skill sourceSkill)
	{
	}

	public void Invoke(Entity entity)
	{
	}

	public void InvokeEnd(Entity entity)
	{
	}
}
