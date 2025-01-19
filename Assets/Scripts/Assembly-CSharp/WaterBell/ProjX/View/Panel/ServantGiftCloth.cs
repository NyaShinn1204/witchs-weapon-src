using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantGiftCloth : UIPanelSingle
	{
		public UITexture image;

		public UITexture bg;

		public UIMixWidget dynamicImage;

		public Vector2 bgCenter;

		public ServantGiftClothData servantGiftClothData;

		public string svImagePath;

		protected override void OnDisable()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
