using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class WGU_CvItem : UIPanelSingle
	{
		private static readonly string lockIcon;

		private static readonly string soundIcon;

		private static List<WGU_CvItem> itemList;

		public UISprite icon;

		public UILabel nameLabel;

		public float speed;

		public bool isPlay;

		private ButtonEx button;

		private WGU_CvItemData cvItemData;

		protected override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void Stop()
		{
		}

		private void PlaySound()
		{
		}

		public void UpdateLayer()
		{
		}
	}
}
