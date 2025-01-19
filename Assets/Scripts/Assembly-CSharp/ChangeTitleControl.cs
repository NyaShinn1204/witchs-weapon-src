using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class ChangeTitleControl : UIPanelBase
{
	public UIScrollView scroll;

	public UIGrid grid;

	public ButtonEx confirmBtn;

	public ButtonEx closePanelBtn;

	public UILabel titleDescText;

	public UISprite titleActivityIcon;

	private long titleID;

	public static ChangeTitleControl current;

	private GameObject titleItem;

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void CloseNow()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void Init()
	{
	}

	public void SetCurrentSelectTitle(long _id, bool unLock)
	{
	}

	private void AddEvent()
	{
	}
}
