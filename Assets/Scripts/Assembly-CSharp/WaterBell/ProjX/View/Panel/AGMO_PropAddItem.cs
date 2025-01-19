using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMO_PropAddItem : AGMO_PropItem
	{
		private static readonly Color greenCol;

		public ButtonEx addButton;

		public ButtonEx reduceButton;

		public UILabel levelLabel;

		public UILabel propNameLabel;

		public UILabel priceLabel;

		[SerializeField]
		private AGMO_PropAddItemData propAddItemData;

		public Action<AGMO_PropAddItem, int> OnAdd;

		public Action<AGMO_PropAddItem, int> OnReduce;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
