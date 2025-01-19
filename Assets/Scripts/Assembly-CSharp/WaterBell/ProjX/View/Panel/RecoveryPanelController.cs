using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class RecoveryPanelController : UIPanelBase
	{
		public RecycleView view;

		public ButtonEx sellAllBtn;

		public ButtonEx goShopBtn;

		public static RecoveryPanelController current;

		private GameObject item;

		public UIScrollView scroll;

		public UIGrid grid;

		public ChangePanel changePanel;

		private UIRecoveryItemData selectData;

		public UILabel sellDesc1;

		public UILabel sellDesc2;

		public Transform infoPanel;

		public UILabel itemName;

		public UILabel itemNumber;

		public UILabel sellGold;

		public UILabel itemType;

		public long itemId;

		public ButtonEx sellBtn;

		public UILabel sellBtnText;

		public UILabel item_descText;

		public UILabel descItemText;

		public UIScrollView dropDesc;

		public Transform goldIcon;

		public Transform UIspriteObj;

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void AddEvent()
		{
		}

		public void FreshItems(bool _fresh = false)
		{
		}

		public void ShowItemInfo(UIRecoveryItemData _data)
		{
		}

		private void GetShopData()
		{
		}

		private void Sell()
		{
		}

		private void SellAll()
		{
		}

		private void SellAllEvent()
		{
		}

		private void OpenSellPanel()
		{
		}

		private string GetResouceTips(long _itemID)
		{
			return null;
		}
	}
}
