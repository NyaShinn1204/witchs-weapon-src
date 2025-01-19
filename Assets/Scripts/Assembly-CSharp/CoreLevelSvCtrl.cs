using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class CoreLevelSvCtrl : MonoBehaviour
{
	private static CoreLevelSvCtrl _instance;

	private GameObject servant;

	private UIAtlas atlasSVHead;

	public GameObject svPickup;

	public GameObject svAdjSlots;

	public UIButton updateDataBtn;

	public RoleLvAdjSlot roleLvAdjSlot;

	public UILabel roleHPValLabel;

	private int pickedNum;

	private int pickedMaxNum;

	public long[] sidUsingArr;

	public long[] weaponIdUsingArr;

	public int[] indexUsingArr;

	public int[] hpArr;

	private int limitedHP;

	public static CoreLevelSvCtrl GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ClearAllSVEnergy()
	{
	}

	public void FillData()
	{
	}

	private void OnCancelPickedSvClick(GameObject canceledSVSlot)
	{
	}

	private void CheckSvAdjDirty()
	{
	}

	private void OnUpdateDataBtnClick()
	{
	}

	private string prepareSvUpdateStr(int star, int rank, int lv, int eq)
	{
		return null;
	}

	private int GetNextAvailablePickSlotIdx()
	{
		return 0;
	}

	private string GetWeaponType(int num)
	{
		return null;
	}

	private int GetEqLevel(ObservableSingleServant svBasic)
	{
		return 0;
	}

	private int GetLimitedHP()
	{
		return 0;
	}

	private void updateRoleHP()
	{
	}

	internal void SetSelect()
	{
	}

	internal void SetSelect(long[] weapons, long[] cads)
	{
	}
}
