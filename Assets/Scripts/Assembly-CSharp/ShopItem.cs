using UnityEngine;

public class ShopItem : MonoBehaviour
{
	public long _goodID;

	public long _setID;

	public long _shopID;

	public UILabel _name;

	public UISprite _icon;

	public UISprite _iconRank;

	public UILabel _itemGold;

	public Transform goldIcon;

	public GameObject selectIcon;

	public UISprite _iconFrame;

	public UILabel _num;

	public GoodInfo _info;

	public Transform priceType1;

	public Transform priceType2;

	public UISprite goldIcon1;

	public UISprite goldIcon2;

	public UILabel goldValue1;

	public UILabel goldValue2;

	private int price1;

	private int price2;

	private int num1;

	private int num2;

	public int rank;

	public UISprite img;

	private UIAtlas atlas;

	private void Start()
	{
	}

	public void SetIDS(long setid, long shopid, long goodid)
	{
	}

	public void SetInfo(GoodInfo info, long shop_id)
	{
	}

	private void OnClick()
	{
	}

	private void SetItemType(int ItemType, int rank)
	{
	}
}
