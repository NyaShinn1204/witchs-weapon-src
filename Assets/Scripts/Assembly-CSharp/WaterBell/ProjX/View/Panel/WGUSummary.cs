using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class WGUSummary : UIPanelSingle
	{
		public static WGUSummary current;

		public EquipSlots equipmentContainer;

		public GameObject rankUpBtnEff;

		public GameObject rakUpEquipEff;

		public WGUS_UseEquipEffect useEquipEffect;

		public UIPanelSingleContainer rankUpEquipmentContainer;

		public UIPanelSingle rankUpEquipment;

		private bool isRankUpEquipOpen;

		public LoadUIPanelSingle rankUpPanelLoader;

		public ButtonEx rankUpButton;

		public ButtonEx equipOnAllButton;

		public ButtonEx showButton;

		public UILabel rankLabel;

		public UILabel rankLabelLimit;

		public UISprite rankIcon;

		private SingleServantEquipView singleServantEquipView;

		private long servantCardID;

		private int rank;

		private bool canUse;

		private List<EquipSlotsItemData> equipSlotsItemDataList;

		private SingleWeaponInfo weaponInfo;

		private SingleServantInfo servantInfo;

		public Transform EquipDetailPos;

		[NonSerialized]
		public int selcetIndex;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public override void UpdatePanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void OpenEquipDetailPanel(long equipId, int? serviceDuct = null)
		{
		}

		public void UpdateAttribute()
		{
		}

		public void UpdateEquips()
		{
		}

		public void RefreshEquipOnAllButton()
		{
		}

		private void EquipOnAll()
		{
		}

		private void RankUp()
		{
		}

		private void RankUpAnim()
		{
		}

		private void SwitchRankUpEquip()
		{
		}

		public void SetRankUpEquip(bool isOpen)
		{
		}

		public void UseEquipFinish()
		{
		}

		public void UseAllEquipFinish()
		{
		}

		public void BingUFrame()
		{
		}

		public void UpdateRankInfo()
		{
		}
	}
}
