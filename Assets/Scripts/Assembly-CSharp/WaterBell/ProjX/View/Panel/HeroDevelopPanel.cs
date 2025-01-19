using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroDevelopPanel : UIPanelSingle
	{
		public UIPanelSingleContainer cosplayButtonsContainer;

		public ButtonEx changeRuneButton;

		public UILabel nameLabel;

		public UILabel descLabel;

		public LoadUIPanelSingle adornRunePanelLoader;

		public LoadUIPanelSingle runeIntensifyPanelLoader;

		public UIPanelSingleContainer equipWithRunesContainer;

		private List<CosplayButtonItemData> cosplayButtonItemDataList;

		private List<SlotsItemData> equipWithRunesDataList;

		private string nameStr;

		private string descStr;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void BindUFrame()
		{
		}

		private void OnChangeRuneButtonClick(GameObject go)
		{
		}

		private void OnSlotsItemClick(SlotsItem slotsItem)
		{
		}

		private void ChangeCloth(CosplayButtonItem cosplayButtonItem)
		{
		}
	}
}
