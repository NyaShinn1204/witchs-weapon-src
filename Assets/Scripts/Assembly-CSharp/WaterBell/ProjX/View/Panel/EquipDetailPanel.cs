using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class EquipDetailPanel : UIPanelSingle
	{
		private static EquipDetailPanel current;

		public static int? serviceDuct;

		public static long rootEquipId;

		public EquipInfo equipInfoPanel;

		public ForgeStep forgeStepPanel;

		public ButtonEx closeButton;

		public ButtonEx bgCloseButton;

		public ButtonEx wayButton;

		public ButtonEx useButton;

		public ButtonEx formulaButton;

		public SingleServantEquipComposeView singleServantEquipComposeView;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static EquipDetailPanel GetInstance()
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void OpenPanel(long equipId, int? serviceDuct = null, Transform trsPos = null, bool sBGClose = false)
		{
		}

		private void DirectClosePanel()
		{
		}

		public void ComposeSucc()
		{
		}

		public void UseEuipSucc()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
