using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIShopItemSpriteEx : UIResSpriteEx
	{
		private UIShopItemData itemData;

		public int dataSort;

		private UISprite soldoutSprite;

		private UISprite bgSprite;

		private UILabel goodNameLabel;

		private Transform extraImg;

		private UILabel ohterNumber;

		private UILabel extraDesc;

		private UISprite p1IconSprite;

		private UILabel p1ValLabel;

		private UILabel p1RealDiamondLabel;

		private UISprite p2IconSprite;

		private UILabel p2ValLabel;

		private UILabel otherTimeLabel;

		private UILabel itemText;

		private UILabel vipText;

		private UISprite discountSprite;

		private UILabel discountValue;

		private Transform presellSprite;

		private UISprite tagIcon;

		private UILabel tagLabel;

		private UILabel caphText;

		private UILabel caphValue;

		private long _startTimestamp;

		private long _endTimestamp;

		private long _time;

		protected override void Awake()
		{
		}

		protected override void BindChildrenNode()
		{
		}

		protected override void InitConfig()
		{
		}

		protected override void ConfigBtnEx()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void RenderGoodSpecialAttrs()
		{
		}

		private void StyleFix()
		{
		}

		private void SetItemUI()
		{
		}

		private void SetNumberPosition()
		{
		}

		private void SetDiamond()
		{
		}

		private void SetBag()
		{
		}

		private void SetItem()
		{
		}

		private void SetCurrency()
		{
		}

		private void SetMystery()
		{
		}

		private void SetOtherTime()
		{
		}

		private void SetOhterTimeLabel()
		{
		}

		private long GetTime(long _endTime)
		{
			return 0L;
		}

		private void RenderCountOrExtraImg()
		{
		}

		private void CheckOwned()
		{
		}

		private bool CheckBagType(int _type, long _id, long _value)
		{
			return false;
		}

		private void RenderPrice()
		{
		}

		private void AdjustPricePos(bool isOnlyShowPrice1)
		{
		}

		protected override void OnClickAction()
		{
		}

		private void CheckTag(long _goodID)
		{
		}
	}
}
