using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SellConfirmPanel : UIPanelSingle
{
	public ButtonEx cannelBtn;

	public ButtonEx confirmBtn;

	private static SellConfirmPanel current;

	public Transform items;

	public UILabel goldValue;

	public UILabel titleText;

	public UILabel bodyText;

	public static SellConfirmPanel GetInstance()
	{
		return null;
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void CloseNow()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void AddEvent()
	{
	}

	private void Sell()
	{
	}

	private void SetItems()
	{
	}
}
