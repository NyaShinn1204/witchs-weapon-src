using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ExpProps : UIPanelSingle
	{
		public Article article;

		public UILabel expLabel;

		public ExpPropsData expPropsData;

		public Transform ContainerPosition;

		private OnLongPressButton longPressButton;

		private ButtonEx buttonEx;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void Use()
		{
		}

		private void Use(int num)
		{
		}
	}
}
