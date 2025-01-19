using System.Collections.Generic;

namespace WaterBell.ProjX.Guide
{
	public class UIConfigItemManager
	{
		private static UIConfigItemManager _instance;

		private Dictionary<int, UIConfigState> id2ConfigMap;

		public static UIConfigItemManager GetInstance()
		{
			return null;
		}

		private void InitConfigMap()
		{
		}

		public UIConfigState GetUIConfigState(int id)
		{
			return default(UIConfigState);
		}
	}
}
