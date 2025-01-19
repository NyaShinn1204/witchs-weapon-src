public interface ISharedObjectMaster
{
	void AddSharedObject(ISharedObject obj);

	void RemoveByID(long id);

	void Remove(ISharedObject obj);

	void ClearAll();
}
