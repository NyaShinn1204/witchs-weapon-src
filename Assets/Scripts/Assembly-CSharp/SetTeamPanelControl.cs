using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class SetTeamPanelControl : UIPanelBase
{
	public ButtonEx myServantTabBtn;

	public ButtonEx mercenaryServantTabBtn;

	public ButtonEx returnBtn;

	public ButtonEx confirmBtn;

	public ButtonEx disConfirmBtn;

	public ButtonEx goMainBtn;

	public UIToggle checkbox;

	public UIToggle sortDefult;

	public UIToggle sortRid;

	public Transform selectMyServantView;

	public UIScrollView myScroll;

	public UIGrid myGrid;

	public Transform selectMercenaryServantView;

	public UIScrollView mercenaryScroll;

	public UIGrid mercenaryGrid;

	public UIScrollView selectedScroll;

	public Transform selectedGrid;

	public Transform isGuildTitle;

	public UILabel isGuildServantCount;

	public UILabel isGuildMercenaryCount;

	public Transform noGuildTitle;

	public UILabel noGuildServantCount;

	public Transform TabListBtn;

	public Transform sortCheckboxs;

	public List<SelectedServant> myServants;

	public List<SelectedServant> mercenaryServants;

	private GameObject myServant;

	private GameObject mecrenaryServant;

	public static SetTeamPanelControl current;

	private List<HireArgu> argus;

	private bool isShow;

	public bool isMyServantView;

	public UILabel titleName;

	private GameObject selectItem;

	public List<MercenaryServant> GetMercenaryServantIDs
	{
		get
		{
			return null;
		}
	}

	public bool IsGuild
	{
		get
		{
			return false;
		}
	}

	public int MaxCount
	{
		get
		{
			return 0;
		}
	}

	public int MyServantMaxCount
	{
		get
		{
			return 0;
		}
	}

	public int MercenaryMaxCount
	{
		get
		{
			return 0;
		}
	}

	public bool IsShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	public void BackView()
	{
	}

	private void AddEvent()
	{
	}

	private void OnConfirm()
	{
	}

	private void Init()
	{
	}

	private void ReturnAction()
	{
	}

	public void ReSetSelected(SelectedServant _sv)
	{
	}

	private void SetTitle()
	{
	}

	private void SetConfirmBtnUI()
	{
	}

	public void SetSelectedViewUI()
	{
	}

	public void OpenSelectMyView()
	{
	}

	public void OpenSelectMercenaryView()
	{
	}

	private List<MercenaryServant> IsSelectList(List<MercenaryServant> _list)
	{
		return null;
	}

	private ObservableSingleServant GetMyServantData(long _sid)
	{
		return null;
	}

	private void SetSelectedBox()
	{
	}

	private bool IsExsitServant(long _id)
	{
		return false;
	}

	private bool IsExsitMercenray(long _id)
	{
		return false;
	}

	private void FreshView()
	{
	}
}
