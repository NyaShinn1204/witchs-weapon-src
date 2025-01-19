using System.Runtime.InteropServices;
using UnityEngine;

public class ServantWpIconInfo : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void BtnClick(long _id);

	public UISprite WPIcon;

	public UISprite WPRankBg;

	public UISprite WPType;

	public UISprite WPRare;

	public Transform LockSprite;

	public Transform selecWpIcon;

	public ButtonEx btn;

	public long wID;

	public BtnClick delegateBtnClick;

	public UISprite remindImg;

	private void Awake()
	{
	}

	public void SetWpIconInfo()
	{
	}

	public void SetWpIconInfo(long _wID, int _weaponSpellPromoteLv, int _weaponCurSkin)
	{
	}

	public void SetWpIconInfo(long _wID, int _weaponSpellPromoteLv, int _weaponCurSkin, bool _unLock)
	{
	}

	public void SetWpIconInfo(long _wID, int _weaponSpellPromoteLv, int _weaponCurSkin, bool _unLock, bool _canCompose, bool _canPromote)
	{
	}

	private void SetIsLock(bool _unlock)
	{
	}
}
