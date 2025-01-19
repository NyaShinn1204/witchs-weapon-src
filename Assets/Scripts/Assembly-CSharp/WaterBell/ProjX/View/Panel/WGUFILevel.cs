using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WGUFILevel : UIPanelSingle
	{
		[Space]
		public UILabel chapterLabel;

		public UILabel levelNameLabel;

		public UIImageNGUI levelIcon;

		private WGUFILevelData lData;

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}
	}
}
