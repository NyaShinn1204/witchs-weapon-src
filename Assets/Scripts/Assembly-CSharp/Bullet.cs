using UnityEngine;

public class Bullet : BaseCorrectable, IResource
{
	public static bool isModelReverse;

	public GameObject obj;

	public GameObject target;

	private BulletTPL tpl;

	private Motion motion;

	protected HitListener hitListener;

	protected CompleteListener completeListener;

	protected IBulletLogicDelegate logic;

	private bool isComplete;

	private Vector3 lastPosition;

	private bool lastIsSet;

	public bool statusMotionEnd;

	public bool statusTargetLost;

	public bool statusHitComplete;

	public bool statusLifeEnd;

	public BulletSysProperties prop;

	public Emit emit;

	public string prefab;

	private bool lookAtEnd;

	public string groupID;

	private bool isActive;

	public Vector3 GetLastPosition()
	{
		return default(Vector3);
	}

	public void SetLogicDelegate(IBulletLogicDelegate logic)
	{
	}

	public IBulletLogicDelegate GetLogic()
	{
		return null;
	}

	public void SetSysProp(BulletSysProperties prop)
	{
	}

	public BulletSysProperties GetProp()
	{
		return null;
	}

	public void SetTargetVector(GameObject target)
	{
	}

	public void SetHitListener(HitListener listener)
	{
	}

	public void SetCompleteListener(CompleteListener listener)
	{
	}

	public void SetSourceObject(GameObject obj)
	{
	}

	public void SetSourcePrefab(string prefab)
	{
	}

	public void OnFullFill()
	{
	}

	public static void Reverse(GameObject obj)
	{
	}

	public GameObject GetSourceObj()
	{
		return null;
	}

	public void SetEmit(Emit emit)
	{
	}

	public void SetTPL(BulletTPL tpl)
	{
	}

	private void createHitListenerByTPL(BulletTPL tpl)
	{
	}

	private void createCompleteListenerByTPL(BulletTPL tpl)
	{
	}

	public BulletTPL GetTPL()
	{
		return null;
	}

	public void SetMotion(IMotionEx motion)
	{
	}

	public IMotionEx GetMotion()
	{
		return null;
	}

	private void createMotionByTPL(BulletTPL tpl)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void Update()
	{
	}

	private void UpdateHitListener()
	{
	}

	private void UpdateCompleteListener()
	{
	}

	public void UpdateMove()
	{
	}

	public void OnHit(int hitIndex, int hitMax)
	{
	}

	public void OnComplete()
	{
	}

	public void OnDestried()
	{
	}

	public void _OnDestried(Bullet bullet)
	{
	}

	public bool IsDestroied()
	{
		return false;
	}

	public void OnBorrow()
	{
	}

	public void OnReturn()
	{
	}

	public void OnCloneComplete()
	{
	}

	public void Reset()
	{
	}
}
