namespace WaterBell.LevelDesign
{
	public class MobDataRow
	{
		public long id;

		public bool isSelected;

		public string mobName;

		public string modelName;

		public string iconFileName;

		public int mobPowerRank;

		public int currLv;

		public MobLvRange mobLvRange;

		public MobDataRow(long id, string mob, string model, string icon, MobLvRange lvRng, int rank = 1)
		{
		}

		public MobDataRow(MobDataRow dr)
		{
		}

		public MobDataRow clone()
		{
			return null;
		}
	}
}
