namespace WaterBell.ProjX.Data.Entity
{
	public class UserAccCache
	{
		public string name;

		public string token;

		public UserLoginType logintype;

		public string nickName;

		private static char spliterChar;

		public string typeStr
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserAccCache()
		{
		}

		public UserAccCache(string uName, string token, string uTypeStr, string nickName)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static UserAccCache ParseCacheLine(string cacheLine)
		{
			return null;
		}
	}
}
