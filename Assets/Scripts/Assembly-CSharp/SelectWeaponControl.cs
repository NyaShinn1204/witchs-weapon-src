using UnityEngine;

public class SelectWeaponControl : MonoBehaviour
{
	public WeaponWidePrefabInfo weaponClone;

	public ButtonEx closeFrameBg;

	public ButtonEx[] wpWidgets;

	public Transform weapon;

	private int index;

	private long sv;

	private long wp;

	private GameObject weaponWidePrefab;

	private void Awake()
	{
	}

	public void OpenSelectView(long _sv, long _wp, int _index)
	{
	}

	private void SetInfo()
	{
	}
}
