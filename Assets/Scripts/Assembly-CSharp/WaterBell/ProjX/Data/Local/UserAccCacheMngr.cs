using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Data.Local
{
	public class UserAccCacheMngr
	{
		private static UserAccCacheMngr _instance;

		private readonly int cacheMaxNum;

		private readonly string FILE_NAME;

		private List<UserAccCache> cacheList;

		private UserAccCache lastLoginUserAccCache;

		private int userIndex;

		private UserAccCacheMngr()
		{
		}

		public static UserAccCacheMngr GetInstance()
		{
			return null;
		}

		private void ReadCacheFromFile()
		{
		}

		private void Sync2File()
		{
		}

		public List<UserAccCache> GetCacheList()
		{
			return null;
		}

		public UserAccCache GetCurrUser()
		{
			return null;
		}

		public bool SetCurrUserIndex(int index)
		{
			return false;
		}

		public void SetLastLoginAccCache(string userName, string token, string type, string nickName = "")
		{
		}

		public void AddLastLoginAccCache()
		{
		}

		private void InsertAndMarkCurrent(UserAccCache cache)
		{
		}

		public void ChangeUserType(string name, string usertype)
		{
		}

		public void DeleteUserInfo(int index)
		{
		}

		public void DeleteAllUserInfo()
		{
		}

		public void DeleteUserInfo(string name)
		{
		}
	}
}
