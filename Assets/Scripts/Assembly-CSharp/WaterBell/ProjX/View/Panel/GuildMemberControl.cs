using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildMemberControl : UIPanelBase
	{
		public enum ListState
		{
			member = 0,
			request = 1
		}

		public ButtonEx removeBtn;

		public ButtonEx changeBtn;

		public ButtonEx advanceBtn;

		public ButtonEx reduceBtn;

		public ButtonEx memberBtn;

		public ButtonEx requestBtn;

		public ButtonEx agreeBtn;

		public ButtonEx refuseBtn;

		public ButtonEx removeSpecialBtn;

		public ButtonEx disRemoveSpecialBtn;

		public ButtonEx DismissBtn;

		public ButtonEx DismissingBtn;

		public UIScrollView memberScroll;

		public UIScrollBar memberBar;

		public Transform memberGrid;

		public UILabel RequestBtnNormalText;

		public UILabel RequestBtnDisabledText;

		public GuildInfoView view;

		public MemberInfoViewPanelControl memberInfoView;

		public static GuildMemberControl current;

		private long selectID;

		private GuildMember memberInfo;

		private RequestMember requestInfo;

		private int selectPrivilege;

		private GameObject prefab;

		public long remainValue;

		private long dismissValue;

		public UILabel remainTime;

		public UILabel dismissTime;

		public UILabel memberCount;

		[HideInInspector]
		public bool IsRemove;

		[HideInInspector]
		public bool IsChange;

		[HideInInspector]
		public bool IsAdvance;

		[HideInInspector]
		public bool IsReduce;

		[HideInInspector]
		public bool IsRemoveSpecial;

		public ListState currentList;

		private int n;

		public ModelCollection<RequestMember> RequestList
		{
			get
			{
				return null;
			}
		}

		public ModelCollection<GuildMember> MemberList
		{
			get
			{
				return null;
			}
		}

		public ModelCollection<long> AdminList
		{
			get
			{
				return null;
			}
		}

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

		public GlobalEnum.GuildPrivilege GetCurrentType
		{
			get
			{
				return default(GlobalEnum.GuildPrivilege);
			}
		}

		public int SelectPrivilege
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsDismissing
		{
			get
			{
				return false;
			}
		}

		public long RecallTime
		{
			get
			{
				return 0L;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void Remove()
		{
		}

		private void Change()
		{
		}

		private void Advance()
		{
		}

		private void Reduce()
		{
		}

		private void Dismiss()
		{
		}

		private void Approve()
		{
		}

		private void Refuse()
		{
		}

		private void Disbanded()
		{
		}

		private void ShowTips()
		{
		}

		private void AddBtnEvent()
		{
		}

		public void ExMember()
		{
		}

		public void ExRequest()
		{
		}

		public void ReFreshMemberList()
		{
		}

		private void BindMemberData()
		{
		}

		private void BindRequestData()
		{
		}

		public void ReFreshRequestList()
		{
		}

		private bool IsAdmins(long _id)
		{
			return false;
		}

		public void SetInfo(long _id, GuildMember _memberInfo, RequestMember _requestInfo)
		{
		}

		public void UpdateInfo()
		{
		}

		private void DismissRemainTime()
		{
		}

		private void RemainTime()
		{
		}

		private void OnDisable()
		{
		}

		public void OpenInfoView()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void CloseInvoke()
		{
		}

		private void SetPresidentIsDismiss()
		{
		}

		public void SetRemindPoint(int _number)
		{
		}
	}
}
