using System.Runtime.InteropServices;
using UnityEngine;

public class UserIconPrefab : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DelegateBtnClick();

	public UISprite Icon;

	public UISprite Frame;

	public ButtonEx Btn;

	public UISprite Bg;

	public UILabel RidText;

	public DelegateBtnClick BtnClick;

	private void Awake()
	{
	}

	public void SetInfoRid()
	{
	}

	public void SetInfo()
	{
	}

	public void SetInfo(long _head, long _head_box)
	{
	}
}
