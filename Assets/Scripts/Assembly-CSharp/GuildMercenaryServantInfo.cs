using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class GuildMercenaryServantInfo : MonoBehaviour
{
	public UILabel Level;

	public UILabel Name;

	public UILabel HP;

	public Transform ServantIconWidget;

	public Transform WeaponIconWidget;

	private GameObject servantIcon;

	private GameObject weaponIcon;

	public Transform lockClose;

	public Transform lockIcon;

	public UILabel lockLevelText;

	public ButtonEx btn;

	public SelectedServant servant;

	public Transform SelectIcon;

	private void Awake()
	{
	}

	public void SetServantInfo(GuildMercenarySv _sv)
	{
	}

	public void SetServantInfo(MercenaryServant _servant)
	{
	}

	public void SetActivityServantInfo(MercenaryServant _servant)
	{
	}

	private void Click()
	{
	}
}
