using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SgcClothItem : UIPanelSingle
	{
		public UISprite icon;

		public UILabel stateLabel;

		public GameObject lockIcon;

		public UISprite activityIcon;

		public GameObject select;

		public Action<long> OnClickEvent;

		public Transform img;

		private long discountEndTime;

		public override void UpdatePanel()
		{
		}

		private void ReFreshEndTime()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnClick()
		{
		}

		public void SetSelectState(bool isSelected)
		{
		}
	}
}
