using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityBillboardRankingDetailPanel : UIPanelSingle
	{
		private static ActivityBillboardRankingDetailPanel s_Current;

		public ButtonEx closeButton;

		public LDL_Item detail;

		protected override void Awake()
		{
		}

		public static ActivityBillboardRankingDetailPanel GetInstance()
		{
			return null;
		}

		public void OpenPanel(LDL_ItemData data)
		{
		}

		private void Close()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}
	}
}
