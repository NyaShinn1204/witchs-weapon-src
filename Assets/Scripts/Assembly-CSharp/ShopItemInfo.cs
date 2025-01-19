using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class ShopItemInfo : UIPanelBase
{
	public UILabel itemName;

	public UILabel type;

	public Transform UIspriteObj;

	public Transform priceType1;

	public Transform priceType2;

	public UISprite goldIcon1;

	public UISprite goldIcon2;

	public UILabel goldValue1;

	public UILabel goldValue2;

	public Transform resouceType;

	public UILabel resouceDesc;

	public UILabel resouceNumber;

	public Transform equipType;

	public Transform equipPoint;

	public UILabel equipNumber;

	public UILabel equipSellValue;

	public UILabel equipDesc;

	public Transform itemType;

	public UILabel itemNumber;

	public UILabel itemSellValue;

	public UILabel itemDesc;

	public UILabel itemText;

	public UILabel numText;

	public Transform bag;

	public UIScrollView scroll;

	public UIGrid grid;

	private GameObject bagItem;

	public UILabel buyNum;

	public Transform headType;

	public UILabel isLockText;

	public UILabel activityHeadText;

	public Transform monthcardType;

	public UILabel mouthDayValue;

	public UILabel remainDayValue;

	public UIScrollView monthScroll;

	public UIGrid monthGrid;

	public GameObject monthText;

	public Transform actionType;

	public UILabel isLockActionText;

	public UILabel activityActionText;

	public UILabel actionDesc;

	public Transform kanbanType;

	public UILabel isLockKanBanText;

	public UILabel activityKanBanText;

	public Transform imageType;

	public UILabel isLockImageText;

	public UILabel activityImageText;

	public UITexture img;

	public UILabel imageName;

	public UILabel painter;

	public UISprite activityIcon;

	public Transform titleType;

	public UILabel isLockTitleText;

	public UILabel activityTitleText;

	public UILabel sellGold;

	public GameObject buyButton;

	public UILabel item_descText;

	public UILabel equip_descText;

	public UILabel descItemText;

	public Transform goldIcon;

	public long itemId;

	public long shopId;

	public long setId;

	private int price1;

	private int price2;

	private int num1;

	private int num2;

	private UIAtlas atlas;

	public Transform itemPoint;

	public UILabel tip;

	public Transform servantIcon;

	public ButtonEx closeBtn;

	public GameObject buyBtn;

	public UISprite btnTopSprite;

	public Transform longBg;

	public Transform shortBg;

	private UILootItemSpriteEx spEx;

	private GameObject prefab;

	private int itemNum;

	private int maxNumber;

	public Transform sliderWidget;

	public UILabel buyNumber;

	public UISlider slider;

	private bool IsOpenSlider
	{
		get
		{
			return false;
		}
	}

	public int CurrentNumber
	{
		get
		{
			return 0;
		}
	}

	private int MaxNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void setID(long _setID, long _shopID, long _itemID)
	{
	}

	private void SetBgBox(bool _isLong)
	{
	}

	private string GetResouceTips(int _type, long _itemID)
	{
		return null;
	}

	private long GetPlayerResouceValue(GlobalEnum.ResType _type)
	{
		return 0L;
	}

	private void SetItem(GoodInfo _info, long _shopID)
	{
	}

	private void SetEquip(GoodInfo _info, long _shopID)
	{
	}

	private void SetResouceType(GoodInfo _info, long _shopID, GlobalEnum.ResType _type)
	{
	}

	private void SetHeadType(GoodInfo _info, long _shopID, GlobalEnum.ResType _type)
	{
	}

	private void SetMonthCardType(GoodInfo _info, long _shopID)
	{
	}

	private void SetAction(GoodInfo _info, long _shopID)
	{
	}

	private void SetKanBan(GoodInfo _info, long _shopID)
	{
	}

	private void SetImageType(GoodInfo _info, long _shopID)
	{
	}

	private void SetTitleType(GoodInfo _info, long _shopID)
	{
	}

	public void SetInfo(GoodInfo info, long shop_id)
	{
	}

	private void Drag()
	{
	}

	private void ChangeCurrentValue()
	{
	}

	private string RealDiamondTitle()
	{
		return null;
	}

	private void GetMaxNumber()
	{
	}

	private long GetCurrentPriceNumber(int _type)
	{
		return 0L;
	}

	private void SetGoPrice(GoodInfo info, long shop_id)
	{
	}

	private void CheckBagType(int _type, long _id, long _value)
	{
	}

	private int CheckTypeForNum(int _type, int _num)
	{
		return 0;
	}

	private void SetEquipProperty(long _id)
	{
	}

	private List<LotteryLootData> GetBagItemDatas(long _bagID)
	{
		return null;
	}
}
