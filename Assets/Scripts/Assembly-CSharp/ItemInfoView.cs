using UnityEngine;

public class ItemInfoView : MonoBehaviour
{
	public UILabel itemName;

	public UILabel itemNumber;

	public UILabel sellGold;

	public UILabel itemType;

	public long itemId;

	public ButtonEx sellBtn;

	public ButtonEx useBtn;

	public ButtonEx openBtn;

	public ButtonEx goBtn;

	public Transform itemPoint;

	public Transform equipPoint;

	public UILabel item_descText;

	public UILabel equip_descText;

	public UILabel descItemText;

	public Transform goldIcon;

	public Transform UIspriteObj;

	private int itemSubType;

	public Transform itemContainer;

	public Transform equipContainer;

	public UIScrollView itemScroll;

	public UIScrollView equipScroll;

	private void Awake()
	{
	}

	public void ReSetNumber()
	{
	}

	public void SetItemView(PackageItemViewModel info)
	{
	}

	private void SetEquipProperty(long _id)
	{
	}

	private string GetResouceTips(long _itemID)
	{
		return null;
	}

	private void SetItemType(int ItemType)
	{
	}

	private string GetColor(PackageItemViewModel info)
	{
		return null;
	}
}
