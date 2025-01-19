using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class EquipInfo : UIPanelBase
	{
		public static EquipInfo current;

		[Space]
		public Article forgeTarget;

		public UILabel equipName;

		public UILabel levelLimit;

		public UILabel count;

		public UILabel desc;

		public UIPanelSingleContainer propContainer;

		public ForgeStep forgeStepPanel;

		public ButtonEx wayButton;

		public ButtonEx formulaButton;

		public ButtonEx useButton;

		public ButtonEx closeButton;

		private ForgeInfo forgeInfo;

		private int? slotNO;

		public SingleServantEquipComposeView singleServantEquipComposeView;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void OpenPanel(long id, int? slotNO = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void CloseForgStep()
		{
		}

		public void RefreshPanel()
		{
		}

		public void OpenForgeStepPanel()
		{
		}

		private void HideAllButton()
		{
		}

		public void Use()
		{
		}

		private bool hasEquip()
		{
			return false;
		}
	}
}
