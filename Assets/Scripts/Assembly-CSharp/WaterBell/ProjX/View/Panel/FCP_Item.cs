using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class FCP_Item : UIPanelSingle
	{
		private static readonly Dictionary<long, string> iconDict;

		public UILabel titleLabel;

		public UILabel descLabel;

		public UILabel descLabel2;

		public UISprite icon;

		public override void UpdatePanel()
		{
		}
	}
}
