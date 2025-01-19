using System.Collections.Generic;
using UnityEngine;

public class UIStoryList
{
	private TypeCsvStoryGroup _group;

	private UIStoryView _ring;

	private GameObject _view;

	private GameObject _viewItem;

	private UIScrollView _scrollView;

	private UISprite _scrollCollider;

	private UIScrollBar _scrollBar;

	private Transform _viewBGLine;

	private Transform _viewBG;

	private Transform _viewBGBottom;

	private Transform _viewReward;

	private Transform _viewCost;

	private Transform _viewLimit;

	private GameObject _btnClose;

	private UIButton _viewLockBtnUnlock;

	private int _widthViewLockBtnUnlock;

	private GameObject _viewLockInfo;

	private GameObject _viewLockInfoItem;

	private UISprite _viewLockIcon;

	private List<GameObject> _listShow;

	private List<GameObject> _listHide;

	private bool _isShow;

	private int _depthItem;

	private int _widthViewBG;

	private int _heightViewBGBottom;

	private int _frame;

	private float _frameTime;

	public bool IsShow
	{
		get
		{
			return false;
		}
	}

	public UIStoryList(GameObject sView)
	{
	}

	private void InitView()
	{
	}

	public void Update()
	{
	}

	public void Hide()
	{
	}

	public void Show(UIStoryView sStoryViewRing, long sIDSelectStory)
	{
	}

	public void ReDrawButtonStyle()
	{
	}

	private GameObject GetLockInfoItem(GameObject sItem, int sIndex, Vector3 offset, string sInfo)
	{
		return null;
	}

	private GameObject GetButton(TypeCsvStory sCsvStroy)
	{
		return null;
	}
}
