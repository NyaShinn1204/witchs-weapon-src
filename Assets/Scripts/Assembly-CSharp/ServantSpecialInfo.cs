using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class ServantSpecialInfo : MonoBehaviour
{
	public enum ServantType
	{
		servant = 0,
		servantMercenary = 1
	}

	public Transform NullType;

	public Transform ExsitType;

	public UISprite typeBg1;

	public UISprite typeBg2;

	public Transform iconWidget;

	private GameObject servantPrefab;

	public UILabel svLevel;

	public UILabel wpLevel;

	public UILabel hp;

	public UILabel readyLabel;

	public UISprite energySlider;

	public GameObject selectIcon;

	public GameObject useIcon;

	public long id;

	public long rid;

	public long wid;

	public ButtonEx selectBtn;

	public ButtonEx addServantBtn;

	public ServantType currentType;

	private bool IsMercenaryMaxCount
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	public void SetExpeditionInfo(ObservableSingleServant sv)
	{
	}

	public void SetExpeditionMercenaryInfo(MercenaryServant sv)
	{
	}

	public void SetNull()
	{
	}

	public void SetMercenaryNull()
	{
	}

	private void ServantOnClick()
	{
	}

	private void AddServant()
	{
	}

	private void SetServantIcon(long _id, int _rank, int _star, int _serial)
	{
	}

	private bool IsFull()
	{
		return false;
	}

	private int GetEnergy(long _id)
	{
		return 0;
	}

	private void SetInfo(long _id, int _rank, int _star, int _fashion, int _level, long _rid, long _wid, int _wpLv)
	{
	}
}
