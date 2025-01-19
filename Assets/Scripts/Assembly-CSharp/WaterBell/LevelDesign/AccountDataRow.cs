namespace WaterBell.LevelDesign
{
	public class AccountDataRow
	{
		public string accName;

		public string accPass;

		public int accType;

		public string rid;

		public string zid;

		public AccountDataRow()
		{
		}

		public AccountDataRow(string name, string pw, int type)
		{
		}

		public AccountDataRow(string name, string pw, int type, string rid, string zid)
		{
		}

		public AccountDataRow(string name, string pw, int type, string zid)
		{
		}

		public string GetCacheID()
		{
			return null;
		}
	}
}
