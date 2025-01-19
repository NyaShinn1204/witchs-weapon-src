using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AP5_ExchangeKey : UIPanelSingle
	{
		public enum ItemKinds
		{
			Src = 0,
			Dest = 1
		}

		public ItemKinds itemKind;

		public Transform icon;

		public UILabel numLabel;

		protected LotteryLoot lotteryLoot;

		public GameObject select;

		private ButtonEx button;

		public Action<AP5_ExchangeKey> OnClick;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetSelectState(bool isSelect)
		{
		}

		public void SetNumState(bool isActive)
		{
		}

		public void UpdateNum()
		{
		}

		public void SetAlpha(float alpha)
		{
		}
	}
}
