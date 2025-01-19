using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SBIP_Item : UIPanelSingle
	{
		public Transform itemIconContainer;

		public UILabel priceLabel;

		public GameObject unlockState;

		public GameObject lockState;

		public UISprite lockMask;

		public override void UpdatePanel()
		{
		}

		public void SetMaskState(bool isActive)
		{
		}
	}
}
