using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class AddVit : UIPanelBase
{
	private enum Selected
	{
		Item1 = 0,
		Item2 = 1
	}

	public UILabel DiamondValue;

	public UILabel VitValue;

	public UILabel numText;

	public ButtonEx diamondBtn;

	public UISprite item1Icon;

	public UISprite item2Icon;

	public UILabel item1Count;

	public UILabel item2Count;

	public UILabel item1GetVit;

	public UILabel item2GetVit;

	public Transform select1;

	public Transform select2;

	public ButtonEx item1Btn;

	public ButtonEx item2Btn;

	public ButtonEx itemBtn;

	private Selected SelectItem;

	private long item1ID;

	private long item2ID;

	private Color color1;

	private Color color2;

	private int BuyVitNumber
	{
		get
		{
			return 0;
		}
	}

	private int FinishBuyVitNumber
	{
		get
		{
			return 0;
		}
	}

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Fresh()
	{
	}

	private void ItemBtn()
	{
	}

	public void FreshItem(bool isCare = false)
	{
	}

	private int GetItemCount(long _id)
	{
		return 0;
	}

	private void OpenConfirm()
	{
	}

	private void DiamondBuy()
	{
	}

	public void FreshDiamond()
	{
	}

	private int GetBuyStrengthNeedDiamond(int number)
	{
		return 0;
	}

	private int GetBuyStrength(int number)
	{
		return 0;
	}
}
