using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class VipPanel : UIPanelBase
{
	public Transform mainView;

	public Transform developView;

	public UISprite level;

	public UILabel nextLevel;

	public UILabel exp;

	public UILabel point;

	public UISprite slider;

	public Transform[] lvs;

	public ButtonEx LookBtn;

	public ButtonEx returnBtn;

	public ButtonEx goShopBtn;

	public GameObject closeShopTitle;

	public Transform finishedView;

	public Transform willView;

	public UIScrollView finishScroll;

	public UIScrollBar finishBar;

	public UIScrollView willScroll;

	public Transform finishedLine;

	public Transform willLine;

	public UILabel[] texts;

	public ButtonEx returnVipMainBtn;

	public Transform anim;

	public UILabel payValue;

	public UILabel payText;

	private float startY;

	private float endY;

	public static VipPanel current;

	public UserPlayerManagerView view;

	private GameObject finishPoint;

	private GameObject finishSmallPoint;

	public ButtonEx lastBtn;

	public ButtonEx nextBtn;

	private int _exp;

	public UILabel remindValue;

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void InitFinishedView()
	{
	}

	private int GetLimit(int _level)
	{
		return 0;
	}

	private void Init()
	{
	}
}
