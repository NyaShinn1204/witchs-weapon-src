using UnityEngine;

public class Emit4GameObject : Emit
{
	public const string FORWARD = "forward";

	public const string UP = "up";

	public const string RIGHT = "right";

	protected string dir;

	protected Vector3 rotateOffset;

	protected int endAtIndex;

	protected int count;

	protected GameObject src;

	protected GameObject self;

	public Emit4GameObject(string dir, Vector3 offset, int endIndex, int count)
	{
	}

	public override void SetSource(GameObject src)
	{
	}

	public override void fire(IBulletLogicDelegate logic)
	{
	}
}
