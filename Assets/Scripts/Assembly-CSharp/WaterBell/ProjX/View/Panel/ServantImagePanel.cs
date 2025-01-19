using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantImagePanel : UIPanelSingle
	{
		public ButtonEx openButton;

		public ButtonEx closeButton;

		public GameObject container;

		public ServantGiftCloth servantGiftCloth;

		public WGUPhoto photo;

		private ServantDevelopMainInfoView servantDevelopMainInfoView;

		public UILabel painter;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		private void SwitchState(bool isOpen)
		{
		}

		public void SetPainterName()
		{
		}
	}
}
