using System.Collections.Generic;

public class DispelPack : BasePack
{
	public const int TYPE_ALL = 0;

	public const int TYPE_INCREASE = 1;

	public const int TYPE_DECREASE = 2;

	public List<long> buffIds;

	public List<int> layers;

	public List<int> types;

	public int increaseOrDecreaseType;

	public int limit;

	public bool isForce;

	public bool isRemove;

	public DispelPack(List<long> buffIds, List<int> layers, List<int> types, bool isforce, bool isremove, int increaseOrDecreaseType = 0, int limit = 1)
	{
	}
}
