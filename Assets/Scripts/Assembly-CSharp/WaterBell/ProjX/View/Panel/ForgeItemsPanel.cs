using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class ForgeItemsPanel : UIPanelSingle
	{
		[Space]
		public CommonEquipment currentEquipmentContainer;

		private CommonEquipmentData eDataCurrent;

		[Space]
		public UIPanelSingle detailPanel;

		public UILabel effectLabel;

		[Space]
		public UIPanelSingle composePanel;

		public FIEquipmentContainer equipmentsStaticContainer;

		private List<CommonEquipmentData> composeEquipmentDataList;

		public UIPanelSingle stepPanel;

		private List<CommonEquipmentData> eDataList;

		[Space]
		public UIPanelSingle wayPanel;

		[Space]
		public UIPanelSingle useButton;

		public UIPanelSingle synthesisFormulaButton;

		public UIPanelSingle wayButton;

		public UIPanelSingle sureButton;

		[Space]
		public GameObject useEquipIcon;

		[HideInInspector]
		public CommonEquipment selectEquipment;

		public void OpenPanel(CommonEquipment _equipment)
		{
		}

		public void UpdateInfoMain()
		{
		}

		public void UpdateCurrentEquip()
		{
		}

		private void UpdateCount(CommonEquipmentData _eData)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void GotoDetailPanel()
		{
		}

		private void SetButton()
		{
		}

		public void GotoComposePanel()
		{
		}

		private void SetEquipment()
		{
		}

		private void UpdateComposePanel()
		{
		}

		public void GotoWayPanel()
		{
		}

		public void Compose()
		{
		}

		private void UpdateStepPanel()
		{
		}

		public void EquipmentOn()
		{
		}

		public void FlyToEquip()
		{
		}
	}
}
