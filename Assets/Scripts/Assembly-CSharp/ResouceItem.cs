using System.Runtime.InteropServices;
using UnityEngine;

public class ResouceItem : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DelegateClickAdd();

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DelegateClickShow();

	public ButtonEx addBtn;

	public ButtonEx showVitTips;

	public Transform vitTips;

	public UILabel vitTipsRemind;

	public Transform activityVitTips;

	public UILabel valueText;

	public UISprite icon;

	private DelegateClickAdd _action;

	private DelegateClickShow _show;

	public ButtonEx activityVitBtn;

	private GlobalEnum.ResType currentType;

	private long currentID;

	public Transform diamondTips;

	public UILabel diamondText1;

	public UILabel diamondText2;

	public Transform drawTips;

	public UILabel drawText1;

	public UILabel drawText2;

	private void OnPress(bool isPressed)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetInfo(GlobalEnum.ResouceType _type)
	{
	}

	private void ExGetActivityVit()
	{
	}

	public void SetActivityVitBtn()
	{
	}

	private void IsShowAddBtn(bool _isShow)
	{
	}

	private void ShowTips()
	{
	}

	private void ShowActivityVitTips()
	{
	}

	private void GoldAction()
	{
	}

	private void VitAction()
	{
	}

	private void DiamondAction()
	{
	}

	private void DrawAciton()
	{
	}

	private void OpenActivityVit()
	{
	}

	private void ShowDiamondTips()
	{
	}

	private void ShowDrawTips()
	{
	}
}
