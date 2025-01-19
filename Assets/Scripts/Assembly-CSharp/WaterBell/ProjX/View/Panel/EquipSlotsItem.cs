using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class EquipSlotsItem : UIPanelSingle
	{
		public enum TipsStates
		{
			Own = 0,
			CanForge = 1,
			CanUse = 2,
			NoOne = 3
		}

		public int slotNO;

		public GameObject full;

		public Article article;

		public GameObject empty;

		public UISprite articleDark;

		public UILabel tipLabel;

		public UISprite tipSprite;

		public TipsStates tipsState;

		private EquipSlotsItemData equipSlotsItemData;

		protected override void Start()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}

		private void Update()
		{
		}
	}
}
