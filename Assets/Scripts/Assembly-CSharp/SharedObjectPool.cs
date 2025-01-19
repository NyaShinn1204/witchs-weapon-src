using System.Collections.Generic;

internal class SharedObjectPool
{
	private static SharedObjectPool _instance;

	private Dictionary<long, ISharedObjectMaster> dic;

	private List<ISharedObject> list;

	private SharedObjectPool()
	{
	}

	public static SharedObjectPool GetInstance()
	{
		return null;
	}

	public void AddSharedObject(ISharedObject obj)
	{
	}

	public void RemoveSharedObject(ISharedObject obj)
	{
	}

	public void RemoveSharedObjectMaster(ISharedObjectMaster master)
	{
	}

	public void ClearAll()
	{
	}
}
