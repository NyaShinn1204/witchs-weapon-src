using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildRequestPanel : UIPanelBase
	{
		public enum BtnType
		{
			request = 1,
			seek = 2
		}

		public ButtonEx requestBtn;

		public ButtonEx requestingBtn;

		public ButtonEx disRequestBtn;

		public ButtonEx seekBtn;

		public ButtonEx testRequestBtn;

		public ButtonEx openCreatePanelBtn;

		public ButtonEx closeCreatePanelBtn;

		public ButtonEx requestListBtn;

		public ButtonEx createBtn;

		public ButtonEx disCreateBtn;

		public ButtonEx closeRequestViewBtn;

		public UIInput seekLabel;

		public UIInput requestLabel;

		public UIInput createNameLabel;

		public UIInput createTalkLabel;

		public UIScrollBar bar;

		public UIScrollView seekScroll;

		public Transform seekGrid;

		public Transform requestGrid;

		public Transform CreatePanel;

		public UILabel needDiamond;

		public Transform requestView;

		public UILabel numberText;

		public Transform seekRemindText;

		public ButtonEx clearBtn;

		[HideInInspector]
		public static GuildRequestPanel current;

		public GuildRequestView view;

		public SelectGuildImgControl guildImgPanel;

		private GameObject seekPrefab;

		[HideInInspector]
		public string currentRequestGuildID;

		private int count;

		[HideInInspector]
		public string currentCannelRequestGuildID;

		public GuildSelectedInfoView infoView;

		public SelectSortingControl sortPanel;

		public UIToggle toggle;

		public ButtonEx lastBtn;

		public ButtonEx nextBtn;

		public UILabel pageText;

		public int pageIndex;

		private bool IsRequestRemainTime
		{
			get
			{
				return false;
			}
		}

		private string SeekText
		{
			get
			{
				return null;
			}
		}

		public ModelCollection<GuildSimple> SeekList
		{
			get
			{
				return null;
			}
		}

		public ModelCollection<GuildSimple> RequestList
		{
			get
			{
				return null;
			}
		}

		private long LastLeaveGuildTime
		{
			get
			{
				return 0L;
			}
		}

		public int GuildOpResult
		{
			get
			{
				return 0;
			}
		}

		private string TestRequestId
		{
			get
			{
				return null;
			}
		}

		private string CreateGuildNameText
		{
			get
			{
				return null;
			}
		}

		private string CreateGuildTalkText
		{
			get
			{
				return null;
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void InitPageIndex()
		{
		}

		private void Seek()
		{
		}

		private void SeekClear()
		{
		}

		private void Create()
		{
		}

		private void Request()
		{
		}

		private void TestRequest()
		{
		}

		private void CannelRequest()
		{
		}

		public void ShowRequestList()
		{
		}

		public void ShowSeekList()
		{
		}

		private ModelCollection<GuildSimple> GetCanJoinList(ModelCollection<GuildSimple> _list)
		{
			return null;
		}

		public void ReFreshSeekList()
		{
		}

		private List<GuildSimple> GetList(ModelCollection<GuildSimple> list, SelectSortingControl.SortGuild sort)
		{
			return null;
		}

		public void ReFreshRequestList()
		{
		}

		private void BindSeekListData(List<GuildSimple> list, Transform _grid, int _type)
		{
		}

		private void OnDisable()
		{
		}

		public void OpenInfoView(string _id, GuildSimple _info)
		{
		}

		private void RemainTime()
		{
		}

		private void SetRequestBtn(int _count, string _id)
		{
		}

		private void CloseInfoView()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void AddBtnEvent()
		{
		}

		private void SelectLastPage()
		{
		}

		private void SelectNextPage()
		{
		}

		private void OpenCreatePanel()
		{
		}

		private void SetCreateBtnUI()
		{
		}

		private void SetCreateBtn(bool unLock)
		{
		}

		public bool IsRequest(string _id)
		{
			return false;
		}

		public bool CanRequest(int _count)
		{
			return false;
		}
	}
}
