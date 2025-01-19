namespace WaterBell.LevelDesign
{
	public class LevelDetailDataRow : CustomDataRow
	{
		public long id;

		public string uiName;

		public string fileName;

		public LevelCatagory type;

		public bool isJsonFileExist;

		public bool isOldJsonFileExist;

		public LevelDetailDataRow(long id, int typeCode, string uiName, string fName)
		{
		}

		public string get(int i)
		{
			return null;
		}
	}
}
