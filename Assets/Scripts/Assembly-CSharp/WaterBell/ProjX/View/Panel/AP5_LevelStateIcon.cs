using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AP5_LevelStateIcon : UIPanelSingle
	{
		private const string CLEAR = "Activity_Icon_01";

		private const string LAST = "Activity_Icon_04";

		private const string CURRENT = "Activity_Icon_03";

		private const string GENERAL = "Activity_Icon_02";

		public UISprite icon;

		public UISprite lastIcon;

		public GameObject extraAwardIcon;

		public GameObject currentSelectIcon;

		public AP5_LevelStateIconData levelStateIconData;

		public UISprite line;

		public override void UpdatePanel()
		{
		}
	}
}
