using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class CTLD_SelectWeaponPanel : UIPanelSingle
	{
		public static CTLD_SelectWeaponPanel current;

		public long selectID;

		public UIPanelSingleContainer weaponContainer;

		public UILabel needGoldLabel;

		public ButtonEx cancelButton;

		public ButtonEx confirmButton;

		private List<CTLD_WeaponIconData> dataList;

		private long needGold;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void Close()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SelectWeapon(long weaponID)
		{
		}

		public static long GetGoldForReset(long weaponID)
		{
			return 0L;
		}
	}
}
