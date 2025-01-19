using System.Collections.Generic;
using UnityEngine;

public class Emit
{
	public string id;

	public string uuid;

	protected BulletTPL bulletTPL;

	public BulletSysProperties prop;

	protected GameObject target;

	protected List<Bullet> bullets;

	protected IBulletLogicDelegate logic;

	public virtual void Init(GameObject obj, GameObject target, BulletTPL tpl, BulletSysProperties prop)
	{
	}

	public virtual void fire(IBulletLogicDelegate logic)
	{
	}

	public virtual void Update()
	{
	}

	public virtual void SetSource(GameObject src)
	{
	}

	public List<Bullet> GetBullets()
	{
		return null;
	}

	public Bullet GetSingleBullet()
	{
		return null;
	}

	public void FireTo(GameObject target, IBulletLogicDelegate logic)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void DestroyAll()
	{
	}

	public void Remove(Bullet bullet)
	{
	}
}
