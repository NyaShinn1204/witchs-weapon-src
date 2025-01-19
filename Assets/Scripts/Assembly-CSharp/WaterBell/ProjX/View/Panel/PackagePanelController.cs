using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class PackagePanelController : UIPanelBase
	{
		public static PackagePanelController current;

		public UIResSpriteExGrid uiresprite;

		public GameObject scroll;

		public GameObject scroll_bar;

		public GameObject left;

		public GameObject top_item;

		public GameObject center;

		public GameObject bottom;

		public bool isAction;

		public ItemInfoView infoView;

		public GameObject go_pitchon;

		public GameObject SellingPanel;

		public ButtonEx returnViewButton;

		public ButtonEx[] TabBtns;

		public ButtonEx[] EquipBtns;

		public Transform equipTab;

		public Transform[] grids;

		private Transform currentGrid;

		public long selectedID;

		private List<UIPkgItemData> allList;

		private List<UIDataBase> currentList;

		public GameObject m_NullStr;

		protected override void AddConfigItem()
		{
		}

		protected override void Awake()
		{
		}

		public void Selling()
		{
		}

		public void ReFresh()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void CloseInfoView()
		{
		}

		private int Comparison<T>(T x, T y)
		{
			return 0;
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void Return()
		{
		}

		private List<UIDataBase> GetCurrentList(int index)
		{
			return null;
		}

		private void OpenTab(int index)
		{
		}

		private void SetUI(Transform grid)
		{
		}

		public void FreshGrid()
		{
		}

		public void Change(UIPkgItemData data)
		{
		}

		public void Add(UIPkgItemData data)
		{
		}

		public void Remove(UIPkgItemData data)
		{
		}

		private int GetDatasIndex<T>(UIDataBase data, List<T> dataList) where T : UIDataBase
		{
			return 0;
		}

		public void OnSelected(Transform tran)
		{
		}

		public void DeSelected()
		{
		}

		private void Sell()
		{
		}
	}
}
