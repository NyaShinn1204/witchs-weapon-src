using System.Runtime.InteropServices;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SellDelegate();

	private int StartNumber;

	public int NowNumber;

	public GameObject slider;

	public GameObject label;

	public bool slider_switch;

	public int sigleValue;

	public string Item_id;

	public GlobalEnum.ResType SellType;

	public int ItemNumber;

	public int ItemType;

	public GameObject gold;

	public GameObject AddButton;

	public GameObject MinishButton;

	public UILabel PackageItemNumber;

	public UISprite Icon;

	public UILabel titleText;

	public UILabel bodyText;

	public ButtonEx sellBtn;

	public ButtonEx cannelBtn;

	public ButtonEx useBtn;

	public SellDelegate sell;

	private UILabel sellBtnText;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void InitInfo(int _sigleValue, long _num, long _id, int _type)
	{
	}

	public void ChangeLabel()
	{
	}

	private void ChangeSlider()
	{
	}

	public void ChangeNowNumber()
	{
	}

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	private void Use()
	{
	}

	private void ReSetUI()
	{
	}
}
