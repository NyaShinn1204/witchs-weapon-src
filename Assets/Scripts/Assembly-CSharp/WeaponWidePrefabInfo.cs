using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class WeaponWidePrefabInfo : MonoBehaviour
{
	public Transform exsitType;

	public Transform nullType;

	public UISprite rune;

	public UISprite type;

	public UITexture icon;

	public Transform selectIcon;

	public Transform useIcon;

	public Transform lockIcon;

	public void SetInfo(long _wid, int _wpLv, int _wpPromote)
	{
	}

	public void SetInfo(ObservableServantWeapon WeaponInfos, bool UnLock, bool canAcitonSelect)
	{
	}

	public void SetNull()
	{
	}
}
