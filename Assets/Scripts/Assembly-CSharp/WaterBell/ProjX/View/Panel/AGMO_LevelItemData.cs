using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AGMO_LevelItemData : UIDataBase
	{
		public int index;

		public bool isPass;

		public string mobEnhance;

		public long score;

		public AGMO_LevelItemData(long id, bool isPass, int index, string mobEnhance, long score)
		{
		}
	}
}
