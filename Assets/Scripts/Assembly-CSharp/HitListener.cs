using UnityEngine;

public class HitListener
{
	public int maxCount;

	public int Count;

	public Bullet bullet;

	public float radius;

	public GameObject source;

	public GameObject target;

	public string bindBone;

	public bool isHitTarget;

	public bool isHitGround;

	public bool isHitBlock;

	public bool checkHitTarget;

	public bool checkHitGround;

	public bool checkHitBlock;

	private bool isHitting;

	private bool isBind;

	private bool isBinded;

	private bool isRayCheck;

	public int MaxCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public GameObject Source
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsBind
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsRayCheck
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Update()
	{
	}

	private Vector3 RayCheck(string targetName)
	{
		return default(Vector3);
	}

	private bool CheckHitTarget(GameObject target, GameObject source, float hit_distance)
	{
		return false;
	}

	private bool CheckHitGround(float groundHeight = 0f)
	{
		return false;
	}

	private bool CheckHitBlock()
	{
		return false;
	}

	public void Trigger()
	{
	}

	private void BindToBone(string bone)
	{
	}

	private void BindToTarget()
	{
	}

	public void Reset()
	{
	}

	public void SetSysProp(BulletSysProperties property)
	{
	}
}
