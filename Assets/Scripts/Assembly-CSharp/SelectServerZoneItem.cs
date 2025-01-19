using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class SelectServerZoneItem : RegAndLoginSubView
{
	public UILabel ZoneName;

	public GameObject ZoneState;

	public UILabel StateText;

	public ButtonEx ZoneBtn;

	public string zid;

	public UISprite BG;

	public UISprite SelectBG;

	public GameObject RoleIcon;

	public string zoneState;

	public bool haveRole;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	public void SetZoneStatus(SvrZone sz)
	{
	}

	public void SetSelectState(int state)
	{
	}

	public void ShowRoleIcon()
	{
	}

	public void ShowOldDirectLoginError()
	{
	}
}
