using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class PropItem : UIPanelSingle
	{
		[Space]
		public UILabel propName;

		public UILabel propValue;

		public UISprite icon;

		public string valuePrefix;

		private PropItemData pData;

		public override void UpdatePanel()
		{
		}
	}
}
