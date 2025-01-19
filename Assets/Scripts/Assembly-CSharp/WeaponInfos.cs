using UnityEngine;

public class WeaponInfos : MonoBehaviour
{
	public GameObject weaponWidePrefab;

	private long servant;

	private long weapon;

	private int index;

	public UILabel lv;

	public Transform nullIcon;

	public void SetInfo(long _servantID, long _weaponID, Transform tran, long _rid = 0L, int _wpLv = 0, int _wpPromote = 0)
	{
	}

	private bool IsMercenaryWp()
	{
		return false;
	}

	private void OnClick()
	{
	}

	public void CloseFrameBg()
	{
	}

	public void SelectWeapon(long _weapon, Transform tran)
	{
	}
}
