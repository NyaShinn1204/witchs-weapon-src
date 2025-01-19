using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class SettlementBuyItemPanel : UIPanelSingle
	{
		public UIRandomAnim randomSelectItem;

		public UIPanelSingleContainer itemContainer;

		public ButtonEx chooseButton;

		public UILabel currencyLabel;

		public GameObject currentSelectBox;

		public GameObject money;

		[SerializeField]
		private long currentRandomLootID;

		[SerializeField]
		private List<long> rawList;

		private WeaponDailyMode mode;

		[SerializeField]
		private List<bool> buyStateList;

		private Transform currentSelectItem;

		private bool isSelectRunning;

		[SerializeField]
		private bool isDebug;

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void UpdateBuyState()
		{
		}

		private void OnBuyButtonClick()
		{
		}

		private void GetChooseResult()
		{
		}
	}
}
