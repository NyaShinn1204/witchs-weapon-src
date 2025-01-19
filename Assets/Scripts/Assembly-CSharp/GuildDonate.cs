using System;
using WaterBell.ProjX.View.Panel;

public class GuildDonate : UIPanelBase
{
	public ButtonEx ClosePanelBtn;

	public ButtonEx GoldDonateBtn;

	public ButtonEx DiamondDonateBtn;

	public UILabel donateNumber;

	public UILabel goldDonateValue;

	public UILabel goldGuildValue;

	public UILabel diamondDonateValue;

	public UILabel diamondGuildValue;

	public UILabel needGoldValue;

	public UILabel needDiamondValue;

	protected override void Awake()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void SetInit()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}
}
