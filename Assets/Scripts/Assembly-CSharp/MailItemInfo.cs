using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class MailItemInfo : UIPanelBase
{
	public UILabel tittle;

	public UILabel sender;

	public UILabel date;

	public UILabel bodyText;

	public Transform Bottom;

	public UISprite img;

	public Transform rewards;

	public MailContentInfoViewModel _info;

	public ButtonEx rewardBtn;

	public ButtonEx removeBtn;

	public UIScrollView RewardScroll;

	public UIGrid RewardGrid;

	public UIScrollBar bar;

	private GameObject item;

	protected override void Awake()
	{
	}

	public void SetInfo(MailContentInfoViewModel info, GlobalEnum.MainItemType type)
	{
	}

	public void GetReward()
	{
	}

	private void Remove()
	{
	}
}
