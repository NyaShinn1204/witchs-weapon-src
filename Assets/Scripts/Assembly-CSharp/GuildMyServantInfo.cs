using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class GuildMyServantInfo : MonoBehaviour
{
	public UILabel level;

	public UITexture servantIcon;

	public Transform servantStar;

	public Transform[] wpWidgets;

	public Transform selectIcon;

	public UILabel nameText;

	private GameObject weaponIcon;

	public ButtonEx Btn;

	private long currentWID;

	private long currentSID;

	public long[] weaponID;

	public static GuildMyServantInfo current;

	public UISprite servant_rank_icon;

	public UILabel servant_rank;

	private void Awake()
	{
	}

	public void SetMyServantInfo(ObservableSingleServant _sv)
	{
	}

	private void SelectWp(long _wid)
	{
	}

	private void ServantClickEvent()
	{
	}

	public void SelectedUI()
	{
	}

	public void unSelectedUI()
	{
	}

	public void SelectedWpUI(long _wp)
	{
	}

	private void UpdateServantRank(int _rank)
	{
	}

	private void UpdateServantStar(int _star)
	{
	}

	private void UpdateServantWeapon(ObservableSingleServant _sv)
	{
	}
}
