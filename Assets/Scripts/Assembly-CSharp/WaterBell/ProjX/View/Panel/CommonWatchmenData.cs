using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonWatchmenData : UIDataBase
	{
		public string name;

		public int level;

		public int exp;

		public int fullExp;

		public int star;

		public int rankColor;

		public int rankUpLimit;

		public int love;

		public int power;

		public int hp;

		public string weapon;

		public int soulStoneCurrent;

		public int soulStoneLevelUp;

		public string soulStoneName;

		public string image;

		public string wide;

		public List<CommonSkillData> skillDataList;

		public List<CommonEquipmentData> ownEquipment;

		public List<CommonEquipmentData> currentColorEquipment;

		public List<CommonEquipmentData> nextColorEquipment;

		public CommonWatchmenData(int _id, string _name, int _hp, string _weapon, int _level, int _exp, int _star, int _rankColor, int _love, int _power, int _soulStoneCurrent, int _soulStoneLevelUp, string _soulStoneName, List<CommonSkillData> _skillDataList, List<CommonEquipmentData> _ownEquipment, List<CommonEquipmentData> _currentColorEquipment, List<CommonEquipmentData> _nextColorEquipment)
		{
		}
	}
}
