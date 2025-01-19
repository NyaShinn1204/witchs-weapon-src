using System.Collections.Generic;

public class MobVOWrapper
{
	private MonsterVO item;

	private MobVOWrapper parent;

	private Dictionary<MobVOWrapper, int> subDic;

	private int count;

	public int Count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MobVOWrapper(MonsterVO vo)
	{
	}

	public bool HasParent()
	{
		return false;
	}

	public bool HasChildren()
	{
		return false;
	}

	public void SetParent(MobVOWrapper parent)
	{
	}

	public void AppendChild(MobVOWrapper child, int count)
	{
	}

	public bool IsRoot()
	{
		return false;
	}

	public MonsterVO GetItem()
	{
		return null;
	}
}
