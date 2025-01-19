using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class IntensifyPropItemData : UIDataBase
	{
		[Space]
		public string name;

		public double prevValue;

		public double nextValue;

		public string icon;

		public IntensifyPropItemData(long id, double prevValue, double nextValue)
		{
		}
	}
}
