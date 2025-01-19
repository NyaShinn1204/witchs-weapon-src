using UnityEngine;

public class UIWeaponSpellTipController : MonoBehaviour
{
	public UILabel labelInfo;

	public UILabel labelName;

	public UILabel labelType;

	public UILabel labelTips;

	public UIScrollBar scrollBar;

	public UIScrollView scrollView;

	public Transform viewArrow;

	public ButtonEx buttonClose;

	public ButtonEx buttonCloseBG;

	private bool _isAwaysArrow;

	private GameObject _arrowTarget;

	private void Awake()
	{
	}

	public void Show(long sID, GameObject sObject, int sSpellType, bool sIsAwaysArrow = false)
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
