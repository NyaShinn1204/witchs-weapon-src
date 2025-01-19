using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class SelectMercenarySvControl : UIPanelBase
	{
		public enum SelectMercenary
		{
			guild = 0,
			fighting = 1
		}

		public ButtonEx confirmBtn;

		public ButtonEx returnBtn;

		public ButtonEx disConfirmBtn;

		public UIGrid grid;

		public UIGrid gridSpecial;

		public UIScrollView scroll;

		public UIScrollView scrollExpediton;

		public UIScrollBar bar;

		public SelectSortingControl sortPanel;

		private List<ObservableSingleServant> MyList;

		private List<GuildMercenarySv> MyGuildList;

		private GameObject ServantPrefab;

		private bool isInit;

		public SelectMercenary myState;

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void ReturnView()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void SetConfirmBtn()
		{
		}

		public void SetDisConfirmBtn()
		{
		}

		private void OnDisConfirm()
		{
		}

		private void OnConfirm()
		{
		}

		public void OpenPanel(ObservableCollection<ObservableSingleServant> MyServantList, GameObject servantPrefab, SelectMercenary _myState)
		{
		}

		public void OpenPanel(ModelCollection<GuildMercenarySv> MyServantList, GameObject servantPrefab, SelectMercenary _myState)
		{
		}

		public void ReFreshSortList()
		{
		}

		private void GetGuildMercenaryServantsData(ModelCollection<GuildMercenarySv> _MyGuidMercenaryServantList)
		{
		}

		private List<GuildMercenarySv> GetList(List<GuildMercenarySv> arrs, SelectSortingControl.SortSelectMercenary sort)
		{
			return null;
		}

		private void GetServantsData(ObservableCollection<ObservableSingleServant> _MyServantList)
		{
		}

		private bool IsExistMyServant(long _id)
		{
			return false;
		}

		private bool IsExistGuildServant(long _id)
		{
			return false;
		}

		private bool IsSaveMyServant(long _sid)
		{
			return false;
		}

		private bool IsSaveGuildServant(long _sid, long _rid)
		{
			return false;
		}

		private void BindMyServants(SelectMercenary myState, UIGrid _grid)
		{
		}

		private void BindGuildMercenaryServants(SelectMercenary myState)
		{
		}
	}
}
