using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CTLD_LevelButton : UIPanelSingle
	{
		private const string ICON = "Badge_Difficulty_";

		private const string NAME = "Text_Difficulty_";

		private const string PRESENT = "Frame_Difficulty_Present";

		private const string NORMAL = "Frame_Difficulty_Normal";

		public UISprite bg;

		public UISprite icon;

		public UILabel nameLabel;

		public GameObject closeMask;

		public GameObject select;

		public GameObject lockIcon;

		public UILabel levelLabel;

		public UILabel remindLabel;

		public UITable table;

		private GameObject pref;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
