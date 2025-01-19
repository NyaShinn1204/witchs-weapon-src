using System.Collections.Generic;

public class VectorPackProcessor : IPackProcessor
{
	private Entity entity;

	private List<VectorPack> oldPackList;

	private List<VectorPack> newPackList;

	private bool _isRemoveColliderInBattleOnce;

	public VectorPackProcessor(Entity target)
	{
	}

	public void Collect(BasePack pack)
	{
	}

	public void Calulate()
	{
	}

	private void CombinOldAndNewPacks()
	{
	}

	private void PushPackFromNewListToOldList()
	{
	}

	private void CancelColliderRemove(VectorPack pack)
	{
	}

	private void ColliderRemove(VectorPack pack)
	{
	}

	public void Reset()
	{
	}

	private void ShowNonDamageInfo(BasePack pack)
	{
	}

	private void ShowDamageInfo()
	{
	}
}
