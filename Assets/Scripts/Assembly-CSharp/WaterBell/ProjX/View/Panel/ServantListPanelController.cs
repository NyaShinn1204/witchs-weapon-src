using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantListPanelController : CommonScenePanel
	{
		public static ServantListPanelController current;

		public GameObject servant_Scroll;

		public GameObject servant_ScrollBar;

		public GameObject grid;

		public ButtonEx returnViewButton;

		public long currentServantID;

		private List<Transform> list;

		public UILabel witchCount;

		public UILabel witchTotal;

		public UILabel witchTotalFighting;

		public UILabel weaponCount;

		public UILabel weaponTotal;

		public UIButton[] sortType;

		public GameObject sortSelect;

		private int _sortIndex;

		private string key;

		public Transform svItem;

		private UIScrollBar bar;

		private UIScrollView scroll;

		private int sortIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void AddConfigItem()
		{
		}

		protected override void Awake()
		{
		}

		private int sComparison<T>(T x, T y)
		{
			return 0;
		}

		private void Start()
		{
		}

		private void DrawSortButton()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void FreshGrid()
		{
		}

		public void SelectServantPreview(long id)
		{
		}

		public void SelectServantDevelop(long id)
		{
		}

		public void ComposeWp(long sID, long wID)
		{
		}

		private void SetNormalState()
		{
		}

		private void SetScrollView()
		{
		}
	}
}
