using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class GuildSelectBuff : UIPanelBase
{
	public ButtonEx CloseBtn;

	public UIScrollView scroll;

	public UIGrid grid;

	private GameObject buffItem;

	public UILabel CDTime;

	private bool isCDTime;

	public UISprite topIcon;

	public UISprite bottomIcon;

	public UIScrollBar bar;

	private long _CDTime;

	private bool GetIsMember
	{
		get
		{
			return false;
		}
	}

	protected override void Awake()
	{
	}

	private void Drag()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void Init()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void SetItemInfo(bool _IsCD, bool _IsLook)
	{
	}

	private void SetCDTime()
	{
	}

	private void RefreshTime()
	{
	}
}
