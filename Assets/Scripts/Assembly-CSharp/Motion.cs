using System.Collections.Generic;
using UnityEngine;

public class Motion : IMotionEx
{
	public float lifeTime;

	protected float lifeRemaind;

	protected Vector3 stepVector;

	public bool isDead;

	protected float frameTime;

	protected string name;

	private List<IMotionEventListener> listeners;

	public GameObject source;

	public GameObject target;

	public Vector3 targetPos;

	public bool useTargetPos;

	private Rotate rot;

	public Bullet bullet;

	public virtual void SetBullet(Bullet bullet)
	{
	}

	public virtual void SetSysProp(BulletSysProperties prop)
	{
	}

	private void CaluFrameTime()
	{
	}

	public void SetRotate(Rotate rot)
	{
	}

	public Rotate GetRotate()
	{
		return null;
	}

	public void AddListener(IMotionEventListener listener)
	{
	}

	public virtual void SetSource(GameObject source)
	{
	}

	public virtual void SetTarget(GameObject target)
	{
	}

	public virtual void SetTargetPos(Vector3 pos)
	{
	}

	public string GetName()
	{
		return null;
	}

	public void SetName(string name)
	{
	}

	public void SetLIfeTime(float lifeFrame)
	{
	}

	public float GetAliveTime()
	{
		return 0f;
	}

	public virtual int Move()
	{
		return 0;
	}

	public virtual void LifeEnd()
	{
	}

	public virtual void ResetLife()
	{
	}

	public Vector3 GetStepVector()
	{
		return default(Vector3);
	}

	protected Vector3 GetDirection(int diretion, Vector3 source, Vector3 target)
	{
		return default(Vector3);
	}

	public void Reset()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
