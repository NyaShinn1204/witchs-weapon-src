using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class SelectActivityViewControl : UIPanelBase
{
	public static SelectActivityViewControl current;

	public HireMercenaryView view;

	public UIScrollView scroll;

	public UIGrid grid;

	private GameObject mecrenaryServant;

	public List<MercenaryServant> mercenaryServants;

	public ButtonEx hireBtn;

	public ButtonEx disHireBtn;

	public ButtonEx returnBtn;

	private List<HireArgu> argu;

	public UIToggle checkbox;

	public UIToggle sortDefult;

	public UIToggle sortRid;

	private bool isShow;

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

	private void ReturnAction()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void Hire()
	{
	}

	public void OpenSelectMercenaryView(bool _isFresh = true)
	{
	}

	private List<MercenaryServant> IsSelectList(List<MercenaryServant> _list)
	{
		return null;
	}

	public void SetHireBtnUI()
	{
	}
}
