using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class SelectExpeditionViewControl : UIPanelBase
{
	public Transform IsGuildView;

	public UIScrollView isGuildMyScroll;

	public UIGrid isGuildMyGrid;

	public UIScrollView isGuildMercenaryScroll;

	public UIGrid isGuildMercenaryGrid;

	public UILabel isServantCountText;

	public UILabel isMercenaryCountText;

	public Transform NoGuildView;

	public UIScrollView noGuildScroll;

	public UIGrid noGuildGrid;

	public UILabel noGuildCountText;

	[HideInInspector]
	public GameObject ExpeditionServant;

	public static SelectExpeditionViewControl current;

	public SetTeamPanelControl team;

	public HireMercenaryView view;

	public bool IsGuild
	{
		get
		{
			return false;
		}
	}

	private int MyServantCount
	{
		get
		{
			return 0;
		}
	}

	private int MercenaryServantCount
	{
		get
		{
			return 0;
		}
	}

	public List<MercenaryServant> GetMercenaryServantIDs
	{
		get
		{
			return null;
		}
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void ExpeditionInit()
	{
	}

	private void SetIsMercenaryServantList()
	{
	}

	private void SetNoMercenaryServantList()
	{
	}

	private ObservableSingleServant GetMyServantData(long _sid)
	{
		return null;
	}

	private void SetMyExpeditonServants(UIScrollView _scroll, UIGrid _grid)
	{
	}

	private void SetMercenaryServant()
	{
	}
}
