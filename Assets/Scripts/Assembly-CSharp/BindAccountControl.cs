using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class BindAccountControl : UIPanelBase
{
	public ButtonEx closePanelBtn;

	public ButtonEx JPBindFBBtn;

	public ButtonEx JPBindTWBtn;

	public ButtonEx JPBindGoogleBtn;

	public ButtonEx JPBindGameCenterBtn;

	public GameObject JPBindFBGameObject;

	public GameObject JPBindTWGameObject;

	public GameObject JPBindGoogleGameObject;

	public GameObject JPBindGameCenterGameObject;

	public static BindAccountControl current;

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void CloseNow()
	{
	}

	private void AddEvent()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void ClickJPBindFBBtn()
	{
	}

	private void ClickJPBindTWBtn()
	{
	}

	private void ClickJPBindGoogleBtn()
	{
	}

	private void ClickJPBindGameCenterBtn()
	{
	}
}
