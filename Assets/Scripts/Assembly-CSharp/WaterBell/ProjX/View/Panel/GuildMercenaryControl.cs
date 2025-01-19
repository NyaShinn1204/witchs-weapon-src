using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildMercenaryControl : UIPanelBase
	{
		public ButtonEx servantsBtn;

		public ButtonEx servantsOwnBtn;

		public ButtonEx cannelBtn;

		public ButtonEx confirmBtn;

		public UIScrollView mercenaryScroll;

		public UIGrid mercenaryGrid;

		public OwnServantControl[] boxs;

		public Transform GuildListPanel;

		public Transform OwnListPanel;

		public UIScrollView myScroll;

		public UIGrid myGrid;

		public Transform selectMyServantPanel;

		public UILabel goldValue;

		public static GuildMercenaryControl current;

		public GuildMercenaryManagerView view;

		private GameObject servantPrefab;

		private GameObject servantMercenaryPrefab;

		private GameObject SelectMercenarySvPrefab;

		public List<long> selectID;

		public List<long> selectWPID;

		private List<long> sv;

		private List<long> wp;

		private List<GuildMercenarySv> MercenaryList;

		private List<ObservableSingleServant> MyList;

		public Transform SelectMyServantPanel;

		public ModelCollection<GuildMercenarySv> MercenaryServantList
		{
			get
			{
				return null;
			}
		}

		public ModelCollection<GuildMercenarySv> OwnServantList
		{
			get
			{
				return null;
			}
		}

		private ObservableCollection<ObservableSingleServant> MyServantList
		{
			get
			{
				return null;
			}
		}

		public int ServantNum
		{
			get
			{
				return 0;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void AddServant()
		{
		}

		public void RemoveServant(long id)
		{
		}

		public void GetReward()
		{
		}

		private void ResetGolidValue()
		{
		}

		public void DrawSelectedServants()
		{
		}

		public void OpenMyServantList()
		{
		}

		private void GetMyServantsData()
		{
		}

		private void BindMyServants()
		{
		}

		private void OpenMercenaryServants()
		{
		}

		private void GetMercenaryServantsData()
		{
		}

		private void BindMercenaryServants()
		{
		}

		private void AddEvent()
		{
		}

		public void SaveSelectID(long _id, long _wp, bool isClickServant)
		{
		}

		private bool isExsitID(long _id, List<long> _list)
		{
			return false;
		}
	}
}
