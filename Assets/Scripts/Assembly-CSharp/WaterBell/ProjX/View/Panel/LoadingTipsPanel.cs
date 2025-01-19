using System;

namespace WaterBell.ProjX.View.Panel
{
	public class LoadingTipsPanel : UIPanelSingle
	{
		public static LoadingTipsPanel current;

		public UILabel tipsLabel;

		protected override void OnDestroy()
		{
		}

		public void OpenPanel()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public static LoadingTipsPanel GetInstance()
		{
			return null;
		}
	}
}
