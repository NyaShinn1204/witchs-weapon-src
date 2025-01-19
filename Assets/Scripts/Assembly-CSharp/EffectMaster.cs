using System.Collections.Generic;

public class EffectMaster : ISharedObjectMaster
{
	private List<ISharedObject> list;

	public virtual void Awake()
	{
	}

	public void AddSharedObject(ISharedObject obj)
	{
	}

	public void ClearAll()
	{
	}

	public void RemoveEffectByURL(string URL)
	{
	}

	public void Remove(ISharedObject obj1)
	{
	}

	public void RemoveByID(long id)
	{
	}

	public EffectBase GetEffectByURL(string URL)
	{
		return null;
	}
}
