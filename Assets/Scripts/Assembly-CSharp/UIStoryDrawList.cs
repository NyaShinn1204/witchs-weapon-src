using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.NetIO;

public class UIStoryDrawList
{
	public class UIStoryDrawListAddItem
	{
		private GMathBezier.BezierData bezierData;

		private int _moveIndex;

		private float _time;

		private GameObject _baseView;

		private GameObject _cloneView;

		public UIStoryDrawListAddItem(GameObject sBaseView)
		{
		}

		public void CloneView()
		{
		}

		public bool PlayAnim(float sMul)
		{
			return false;
		}
	}

	private Transform _viewDraw;

	private Transform _viewDrawList;

	private UIPanel _scrollMiniPanel;

	private bool _isMini;

	private List<GameObject> _listItem;

	private Dictionary<long, GameObject> _hashItem;

	private Transform _item;

	private UIScrollView _scrollView;

	private UISprite _scrollCollider;

	private UIScrollBar _scrollBar;

	private UISprite _scrollBG;

	private Transform _btnMiniLeft;

	private Transform _btnMiniRight;

	private UILabel _labelTime;

	private UIStoryDrawPanel _drawPanel;

	private List<UIStoryDrawListAddItem> _animAddItem;

	private NetMsgBase _netmsg;

	public bool isMini
	{
		get
		{
			return false;
		}
	}

	public static Activity ServerActivity
	{
		get
		{
			return null;
		}
	}

	public UIStoryDrawList(Transform sViewDraw, Transform sViewDrawList, UIStoryDrawPanel sPanel)
	{
	}

	private void InitView()
	{
	}

	public void Update()
	{
	}

	public void SwitchMini()
	{
	}

	public void ReDrawItemList(bool sIsAnim = false)
	{
	}
}
