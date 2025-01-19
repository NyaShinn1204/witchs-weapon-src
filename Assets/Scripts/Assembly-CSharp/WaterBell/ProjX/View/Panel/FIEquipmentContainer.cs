using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class FIEquipmentContainer : UIPanelSingle
	{
		protected List<CommonEquipmentData> needEquipmentList;

		protected UIPanelSingle currentPanel;

		public void OpenPanel(List<CommonEquipmentData> _needEquipmentList)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		protected void Check(int _equipmentCount)
		{
		}
	}
}
