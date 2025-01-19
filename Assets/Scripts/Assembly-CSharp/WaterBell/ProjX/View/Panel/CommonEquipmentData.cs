using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonEquipmentData : CommonArticlesData
	{
		public int needGold;

		public string effect;

		public int needCount;

		public List<long> needEquipmentList;

		public List<int> debris;

		public List<WGUFILevelData> wayList;

		public CommonEquipmentData(int _id, string _icon, int _quality, string _name, string _description, int _count, int _maxCount, int _needGold, int _needLevel, string _effect, List<CommonEquipmentData> _needEquipmentList, int _needCount, List<WGUFILevelData> _wayList, CommonEquipmentData _debris)
			: base(0L, null, 0, null, null, 0, 0)
		{
		}

		public CommonEquipmentData(ServantEquipment _servantEquipment)
			: base(0L, null, 0, null, null, 0, 0)
		{
		}

		public CommonEquipmentData(int _id)
			: base(0L, null, 0, null, null, 0, 0)
		{
		}

		public static CommonEquipmentData ServantEquipmentToCommonEquipmentData(ServantEquipment _servantEquipment)
		{
			return null;
		}
	}
}
