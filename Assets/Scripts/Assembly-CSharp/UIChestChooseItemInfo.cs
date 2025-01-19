using UnityEngine;

public class UIChestChooseItemInfo : MonoBehaviour
{
	public UILabel itemName;

	public UILabel itemNumber;

	public UILabel sellGold;

	public UILabel itemType;

	public long itemId;

	public UILabel descItemText;

	public Transform goldIcon;

	public Transform UIspriteObj;

	public ButtonEx confirmBtn;

	public ButtonEx cannelBtn;

	private int chestNum;

	public ButtonEx addBtn;

	public ButtonEx reduceBtn;

	public ButtonEx maxBtn;

	public ButtonEx minBtn;

	public UILabel numText;

	private int max;

	private void Awake()
	{
	}

	public void SetInfo(long _id)
	{
	}

	private string GetColor(long _id)
	{
		return null;
	}

	private string GetResouceTips(long _itemID)
	{
		return null;
	}
}
