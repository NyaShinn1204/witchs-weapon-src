using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class MyServantsInfoExpedition : MonoBehaviour
{
	public UILabel svLevel;

	public UILabel wpLevel;

	public UILabel hpLabel;

	public UILabel readyLabel;

	public Transform iconWidget;

	public Transform lockIcon;

	private GameObject ServantIconPrefab;

	public ButtonEx Btn;

	private long weaponID;

	private SelectedServant servant;

	private void Awake()
	{
	}

	public void SetInfo(ObservableSingleServant _servant)
	{
	}

	private void SetInfoBase(ObservableSingleServant sv)
	{
	}

	private void ServantOnClick()
	{
	}

	private void SetServantIcon(long _id, int _rank, int _star, int _serial)
	{
	}
}
