using UnityEngine;

public class DailyItem : MonoBehaviour
{
	public UISprite itemImg;

	public UILabel itemName;

	public UILabel itemDesc;

	public Transform itemSelect;

	public long itemID;

	public UILabel lockText;

	private bool isOpen;

	public ButtonEx btn;

	public static DailyItem current;

	private void Awake()
	{
	}

	public void SetInfo(long _id, bool _select, bool _isOpen, int _type)
	{
	}

	public void UnSelect()
	{
	}

	public void Select()
	{
	}

	public void SetSelect()
	{
	}

	private string GetDesc(int _type, long _id)
	{
		return null;
	}

	private string CanDo(string _key)
	{
		return null;
	}
}
