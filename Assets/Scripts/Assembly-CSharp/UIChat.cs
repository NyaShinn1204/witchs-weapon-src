using System.Collections.Generic;
using UnityEngine;

public class UIChat : GUtilUISuper
{
	private class UIChatItem
	{
		private ServerDataChatMngr.ServerDataChatItem _data;

		private GameObject _view;

		private UISprite _viewIcon;

		private UISprite _viewIconBack;

		private UILabel _labelName;

		private UILabel _labelInfo;

		private UILabel _labelTime;

		private UILabel _labelLv;

		private UISprite _viewPop;

		private float _height;

		public GameObject view
		{
			get
			{
				return null;
			}
		}

		public float height
		{
			get
			{
				return 0f;
			}
		}

		public ServerDataChatMngr.ServerDataChatItem data
		{
			get
			{
				return null;
			}
		}

		public UIChatItem(GameObject sView, ServerDataChatMngr.ServerDataChatItem sData)
		{
		}

		public void DrawViewTime(ServerDataChatMngr.ServerDataChatItem sPreData)
		{
		}

		public void Destory()
		{
		}
	}

	private class UIChatItemList
	{
		private List<UIChatItem> _listItem;

		private GameObject _viewCenter;

		private UIButton _button;

		public GameObject button
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public UIChatItemList(GameObject sViewCenter, UIButton sButton)
		{
		}

		public void AddItem(UIChatItem sItem)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public UIChatItem GetItem(string sID)
		{
			return null;
		}
	}

	private UISprite _centerBack;

	private UIInput _input;

	private UILabel _inputLabel;

	private GameObject _item;

	private GameObject _itemSelf;

	private GameObject _itemSys;

	private GameObject _btnSend;

	private UILabel _btnSendLabel;

	private GameObject _btnMsg;

	private GameObject _btnMsgView;

	private UILabel _btnMsgLabel;

	private GameObject _btnClose;

	private GameObject _btnGuild;

	private GameObject _scrollView;

	private GameObject _scrollCollider;

	private UIScrollBar _scrollVertical;

	private ServerDataChatMngr _serverDataChatMngr;

	private GameObject _viewLeftOffset;

	private GameObject _viewBottomLeft;

	private GameObject _viewBtnCloseBack;

	private bool _isShowChat;

	private Dictionary<ServerDataChatMngr.ServerDataChatType, UIChatItemList> _chatTypeDic;

	private ServerDataChatMngr.ServerDataChatType _chatType;

	private string _btnMsgHideHD;

	private double _timeTeampWorld;

	public static bool IsShowChat
	{
		get
		{
			return false;
		}
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	private void Update()
	{
	}

	private static void chatHD(GUtilListenerEvent sEvent)
	{
	}

	private void btnMsgShow(ServerDataChatMngr.ServerDataChatItem sData = null)
	{
	}

	private void btnMsgHideHD()
	{
	}

	private void btnMsg()
	{
	}

	private void btnMsgView()
	{
	}

	private void btnType(string[] sArg)
	{
	}

	private void NoMsgCheck()
	{
	}

	private void btnSend()
	{
	}

	private void btnClose()
	{
	}

	private void btnClose2()
	{
	}

	private void btnHead(string[] sArgs)
	{
	}

	private void btnHeadHDUnOpen(GUtilListenerEvent sEvent)
	{
	}

	private void btnHeadHDGuildJoin(GUtilListenerEvent sEvent)
	{
	}

	private void btnGuild()
	{
	}

	private void btnGuildHD(GUtilListenerEvent sEvent)
	{
	}

	public void HideChat(bool sIsInit = false)
	{
	}

	private void HideChatTweenHD()
	{
	}

	public void ShowChat()
	{
	}

	public void ShowMain()
	{
	}

	public void HideMain()
	{
	}

	private void DrawBtnMsgView()
	{
	}
}
