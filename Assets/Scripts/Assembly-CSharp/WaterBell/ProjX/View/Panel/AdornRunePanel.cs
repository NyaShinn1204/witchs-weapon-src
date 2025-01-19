using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AdornRunePanel : UIPanelSingle
	{
		public static AdornRunePanel current;

		public ButtonEx selectIntensifyButton;

		public ButtonEx selectEquipButton;

		public ARPRuneDetail selectRuneDetail;

		public ButtonEx adornIntensifyButton;

		public ButtonEx adornDischargeButton;

		public ARPRuneDetail adornRuneDetail;

		public UISprite selectRune;

		public UIPanelSingleContainer runesContainer;

		public UISprite selectSlot;

		public UIPanelSingleContainer equipWithRunesContainer;

		public ButtonEx backButton;

		private long selectSuitId;

		private long selectRuneId;

		private List<long> suitsList;

		private List<SlotsItemData> equipWithRunesDataList;

		private List<RuneItemData> runesDataList;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void AddConfigItem()
		{
		}

		private void BackButtonClick(GameObject go)
		{
		}

		private void SelectIntensifyClick(GameObject go)
		{
		}

		private void SelectEquipClick(GameObject go)
		{
		}

		private void AdornIntensifyClick(GameObject go)
		{
		}

		private void AdornDischarge(GameObject go)
		{
		}

		public void SlotClick(long slotId)
		{
		}

		public void RuneClick(long runeId)
		{
		}

		public void AdornClick()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void BindUFrame()
		{
		}

		private void OnRuneClick(RuneItem runeIcon)
		{
		}

		private void OnSlotsItemClick(SlotsItem slotsItem)
		{
		}

		private void SelectRune(long id)
		{
		}

		private void SelectSlot(long index)
		{
		}
	}
}
