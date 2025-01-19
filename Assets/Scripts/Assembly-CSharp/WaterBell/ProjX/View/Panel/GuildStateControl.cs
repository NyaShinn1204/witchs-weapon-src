using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildStateControl : UIPanelBase
	{
		public static GuildStateControl current;

		public GuildInfoView view;

		public GuildDonate donatePanel;

		public GuildSelectBuff buffPanel;

		public GuildChangeSlogan sloganPane;

		public ButtonEx QuitBtn;

		public ButtonEx DisbandedBtn;

		public ButtonEx DonateBtn;

		public ButtonEx DisDonateBtn;

		public ButtonEx ActiveBtn;

		public ButtonEx ChangeBtn;

		public ButtonEx LookBtn;

		public ButtonEx ResetSloganBtn;

		public ButtonEx GoShopBtn;

		public UILabel Name;

		public UILabel BossLv;

		public UILabel GuildBoss;

		public UILabel GuildSlogan;

		public Transform imgWidget;

		public UILabel GuildMemberCount;

		public UILabel GuildFighting;

		public UILabel GuildTotalValue;

		public UILabel TodayValue;

		public UILabel TotalValue;

		public UILabel DonateNumber;

		public UISprite Slider;

		public UILabel otherTime;

		public UILabel buffText;

		public UISprite buffIcon;

		private GameObject go;

		private Dictionary<string, List<GuildLogData>> logs;

		private List<string> logsKeys;

		public UIScrollView scroll;

		public UIScrollBar bar;

		public UILabel scrollText;

		public UILabel CurrencyValue;

		private long _buffTime;

		public int OperationResult
		{
			get
			{
				return 0;
			}
		}

		public GuildOpArgu Argu
		{
			get
			{
				return null;
			}
		}

		private GuildMember GetPresident
		{
			get
			{
				return null;
			}
		}

		public List<GuildBuffData> buffs
		{
			get
			{
				return null;
			}
		}

		public List<GuildBuff> buffStates
		{
			get
			{
				return null;
			}
		}

		public GuildBuff GetExsitBuff
		{
			get
			{
				return null;
			}
		}

		private List<GuildLogAndTime> GetGuildLog
		{
			get
			{
				return null;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void ReSetDonateUI()
		{
		}

		private void SetGuildInfoUI()
		{
		}

		private void Init()
		{
		}

		public void SetBuffUI()
		{
		}

		public void ReSetSlogan()
		{
		}

		public void ExChangeSlogan(string _slogan)
		{
		}

		public void ExGoldDonate()
		{
		}

		public void ExDiamondDonate()
		{
		}

		public void ExActiveBuff(long _id)
		{
		}

		private void OnDisable()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Quit()
		{
		}

		private void DisbandedConfirm()
		{
		}

		private void Disbanded()
		{
		}

		private void SetBtnUI(bool _IsBuff)
		{
		}

		private void SetOhterTime(bool _IsBuff)
		{
		}

		private void SetBuffTime()
		{
		}

		private void SetGuildLogUI()
		{
		}

		private void RefreshLog()
		{
		}

		private void GetDictionary()
		{
		}
	}
}
