using System.Collections.Generic;
using UnityEngine;

public class EffectBase : MonoBehaviour, ISharedObject, IResource
{
	public int bindPoint;

	public bool bind;

	public string url;

	public bool isMulScale;

	public Vector3 offset;

	public Vector3 baseRotate;

	public EffectBase[] subEffects;

	public EffectsBander father;

	private bool isSuciding;

	public Vector3 direction;

	public bool isAlwaysFaceTo;

	private Dictionary<long, ISharedObjectMaster> masters;

	private Vector3 targetPos;

	public void Update()
	{
	}

	public void SetAlwaysLookAt(Vector3 dir)
	{
	}

	public virtual void Bind(EffectsBander effectsBander, CharacterBase source = null, Transform faceTo = null)
	{
	}

	public virtual void Sucide()
	{
	}

	public void resetTransform()
	{
	}

	public void AppendMaster(ISharedObjectMaster master)
	{
	}

	public void DeleteSelf()
	{
	}

	public List<ISharedObjectMaster> GetMasters()
	{
		return null;
	}

	public ISharedObjectMaster GetMaster(long hash)
	{
		return null;
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

	public void OnFullFill()
	{
	}
}
