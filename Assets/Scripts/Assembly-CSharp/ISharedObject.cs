using System.Collections.Generic;

public interface ISharedObject
{
	void AppendMaster(ISharedObjectMaster master);

	void DeleteSelf();

	ISharedObjectMaster GetMaster(long hash);

	List<ISharedObjectMaster> GetMasters();
}
