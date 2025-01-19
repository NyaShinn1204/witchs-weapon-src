using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WGURankUpEquipmentContainer : UIPanelSingle
	{
		[Space]
		public SwitchButton switchButton;

		public WGUEquipment currentEquipment;

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void Show()
		{
		}
	}
}
