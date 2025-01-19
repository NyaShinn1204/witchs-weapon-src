using UnityEngine;

public class Emit4TimeGameObject : Emit4GameObject
{
	protected bool groupReverse;

	protected Vector3 groupBaseDirRotate;

	protected float groupInterval;

	protected int groupTimes;

	private int _count;

	private float _time;

	public Emit4TimeGameObject(string baseDir, Vector3 offset, int endAt, int count, bool groupReverse, Vector3 groupBaseDirRotate, float groupInterval, int groupTimes)
		: base(null, default(Vector3), 0, 0)
	{
	}

	public void Update(IBulletLogicDelegate logic)
	{
	}
}
