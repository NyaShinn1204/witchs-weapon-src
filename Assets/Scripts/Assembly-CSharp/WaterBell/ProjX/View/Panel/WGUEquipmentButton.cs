using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WGUEquipmentButton : UIPanelSingle
	{
		public enum EmptyButtonTypes
		{
			NoOne = 0,
			CanComposite = 1,
			CanDress = 2
		}

		public bool isOwn;

		[Space]
		public Article article;

		[Space]
		public GameObject emptybutton;

		public UILabel tipsLabel;

		public EmptyButtonTypes stateType;

		public override void UpdatePanel()
		{
		}

		protected void SetEmptyButton()
		{
		}

		private void OnClick()
		{
		}

		public void OpenDetail()
		{
		}
	}
}
