using System;

namespace WaterBell.ProjX.View.Panel
{
	public class SingleServantEvent
	{
		private static SingleServantEvent current;

		private SingleServantViewModel servantViewModel;

		private CurrentServantWeaponInfoViewModel weaponViewModel;

		public SingleServantInfo servantInfo;

		public Action OnDataChange;

		public static SingleServantEvent GetInstance()
		{
			return null;
		}

		public void Rebind()
		{
		}

		public void Bind(SingleServantViewModel servantViewModel, CurrentServantWeaponInfoViewModel weaponViewModel)
		{
		}

		public void TryInvoke()
		{
		}
	}
}
