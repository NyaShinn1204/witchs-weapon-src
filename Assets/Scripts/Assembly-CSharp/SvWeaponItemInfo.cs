using System.Runtime.InteropServices;
using UnityEngine;

public class SvWeaponItemInfo : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void BtnClick(long _id);

	public UITexture weaponIcon;

	public UISprite rare;

	public GameObject awakeIcon;

	public Transform selecWpIcon;

	public ButtonEx btn;

	public long wID;

	public BtnClick delegateBtnClick;

	public UILabel derbisNumLabel;

	private void Awake()
	{
	}

	public void SetWpIconInfo()
	{
	}

	public void SetWpIconInfo(long _wID, int _weaponSpellPromoteLv, int _weaponCurSkin, bool _unLock)
	{
	}
}
