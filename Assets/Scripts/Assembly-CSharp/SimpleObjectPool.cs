using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectPool
{
	public Dictionary<int, bool> dic;

	public Dictionary<int, IResource> dicContent;

	public string id;

	protected string path;

	public int Count
	{
		get
		{
			return 0;
		}
	}

	public int InFreeCount
	{
		get
		{
			return 0;
		}
	}

	public virtual IResource Borrow<T>() where T : IResource
	{
		return null;
	}

	public virtual IResource BorrowBT<T>() where T : Object, IResource
	{
		return null;
	}

	private IResource GetExistOne()
	{
		return null;
	}

	private void CreateAndSaveNewOne(IResource btNew)
	{
	}

	public virtual void Return<T>(T bttree) where T : IResource
	{
	}

	public static SimpleObjectPool NewObjectPool<T>(string id, string path, int count) where T : IResource
	{
		return null;
	}

	public static BTPool NewBTPool<T>(string id, string path, int count) where T : Object, IResource
	{
		return null;
	}

	public void OnFullFill()
	{
	}

	private IResource Clone<T>(string path) where T : IResource
	{
		return null;
	}

	private IResource CloneBT<T>(string path) where T : Object, IResource
	{
		return null;
	}

	public static string GetID(string content)
	{
		return null;
	}
}
