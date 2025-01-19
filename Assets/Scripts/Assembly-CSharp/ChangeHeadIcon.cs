using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class ChangeHeadIcon : UIPanelBase
{
	public enum TabState
	{
		frameTab = 0,
		iconTab = 1
	}

	public ButtonEx cannelBtn;

	public ButtonEx confirmBtn;

	public ButtonEx unConfirmBtn;

	public ButtonEx frameBtn;

	public ButtonEx iconBtn;

	public ButtonEx randomBtn;

	public UISprite mainIcon;

	public UISprite mainFrame;

	private long mainIconID;

	private long mainFrameID;

	public UILabel headName;

	public UILabel frameName;

	public UILabel descLabel;

	public UISprite activityIcon;

	public UIScrollView scroll;

	public UIGrid grid;

	public static ChangeHeadIcon current;

	private GameObject heroIconPrefab;

	private TabState currentState;

	private bool isRandom;

	public bool iconUnlock;

	public bool frameUnlock;

	private List<HeadIcon> GetHeadList
	{
		get
		{
			return null;
		}
	}

	private List<HeadIconBox> GetHeadBoxList
	{
		get
		{
			return null;
		}
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void Init()
	{
	}

	public void DrawHead(TabState _state, long _id, string _resource, bool _unlock)
	{
	}

	private void ClickTab(TabState _tab)
	{
	}

	private void RandomIcon()
	{
	}

	private void SetRandomSelect(long _id)
	{
	}

	private void SetMainHead(string _icon, string _frame, long _iconID, long _frameID)
	{
	}

	public void SetNameLabel(long _id, string _name, string _desc, TabState _state)
	{
	}

	private void SwitchConfirmBtn()
	{
	}

	private void RandomBtnAnim()
	{
	}

	private void RandomBtnAnimBack()
	{
	}

	private void SetIsRandom()
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

	private void ExDraw()
	{
	}

	private void ShowTip()
	{
	}
}
