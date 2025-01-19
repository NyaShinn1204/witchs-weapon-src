using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class ReadyFightingControl : UIPanelBase
	{
		public enum ReadyState
		{
			Selected = 0,
			Setting = 1
		}

		public ButtonEx[] selects;

		public List<HireArgu> argus;

		public List<long> myIDS;

		public List<GuildMercenarySv> mercenarys;

		public ButtonEx MyServantsBtn;

		public ButtonEx GuildServantsBtn;

		public ButtonEx ConfirmBtn;

		public ButtonEx ReturnBtn;

		public ButtonEx ContinueBtn;

		public static ReadyFightingControl current;

		public List<long> saveMySelects;

		public List<long> saveGuildSelects;

		public List<long> Rids;

		public List<long> Sids;

		public List<long> Times;

		public List<long> save_rids;

		public List<long> save_sids;

		public List<long> save_times;

		public Transform Step1;

		public Transform Step2;

		public ButtonEx SettingBtn;

		public ReadyState currentState;

		public List<long> GetServantIDs
		{
			get
			{
				return null;
			}
		}

		public List<MercenaryServant> GetMercenaryServantIDs
		{
			get
			{
				return null;
			}
		}

		private int ReadyCount
		{
			get
			{
				return 0;
			}
		}

		private int MercenaryCount
		{
			get
			{
				return 0;
			}
		}

		public int SelectMercenaryCount
		{
			get
			{
				return 0;
			}
		}

		public int SelectServantCount
		{
			get
			{
				return 0;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void ClearList()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void Init()
		{
		}

		private ObservableSingleServant GetMyServantData(long _sid)
		{
			return null;
		}

		private void SetMyServantsUI()
		{
		}

		private MercenaryServant GetGuildServantData(long _sid, long _rid)
		{
			return null;
		}

		private void SetGuildServantUI()
		{
		}

		private void SetSaveMyServantUI()
		{
		}

		private void SetSaveGuildServantUI()
		{
		}

		private MercenaryServant GetSaveGuildServantData(int index)
		{
			return null;
		}

		public void OnConfirm()
		{
		}

		private void AddEvent()
		{
		}

		private void Continue()
		{
		}

		private void Confirm()
		{
		}

		public void ClearSaveInfo(bool isInit)
		{
		}

		public void AddSaveServant(long _rid, long _sid, long _addTime)
		{
		}

		public void ConfirmAddServant()
		{
		}

		public bool IsExist(long _id, List<long> _ids)
		{
			return false;
		}

		private int GetIndex(long _id, List<long> _ids)
		{
			return 0;
		}

		public void GoSelected()
		{
		}

		public void GoSetting()
		{
		}
	}
}
