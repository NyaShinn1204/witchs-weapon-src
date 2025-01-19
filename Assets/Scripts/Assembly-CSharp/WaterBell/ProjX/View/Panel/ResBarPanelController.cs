using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.UIFrame;

namespace WaterBell.ProjX.View.Panel
{
	public class ResBarPanelController : CommonScenePanel
	{
		public UserPlayerManagerView user;

		[HideInInspector]
		public GameObject gold;

		[HideInInspector]
		public GameObject vit;

		[HideInInspector]
		public GameObject rmb;

		[HideInInspector]
		public GameObject draw;

		[HideInInspector]
		public GameObject maze;

		[HideInInspector]
		public GameObject association;

		[HideInInspector]
		public GameObject contribution;

		[HideInInspector]
		public GameObject vip;

		[HideInInspector]
		public GameObject activityStamina;

		[HideInInspector]
		public GameObject story;

		[HideInInspector]
		public GameObject activityStory;

		[HideInInspector]
		public GameObject prestige;

		[HideInInspector]
		public GameObject drawItem;

		[HideInInspector]
		public GameObject Fashion;

		[HideInInspector]
		public GameObject ActivitySpeedUp;

		[HideInInspector]
		public GameObject ActivityCurrency;

		[HideInInspector]
		public GameObject ActivityCurrency2;

		[HideInInspector]
		public GameObject RecycleCurrency;

		public UITable barTable;

		private GameObject resBarPrefab;

		private GameObject resBarPrefab1;

		public static ResBarPanelController current;

		[HideInInspector]
		public GameObject vitTips;

		[HideInInspector]
		public GameObject goldTips;

		[HideInInspector]
		public GameObject activityVitTips;

		[HideInInspector]
		public GameObject diamondTips;

		[HideInInspector]
		public GameObject drawTips;

		private float server_updatetime;

		private float all_server_updatetime;

		private float activity_updatatime;

		private string str;

		private string total;

		public ButtonEx ClosePanelButton;

		public AddVit AddVitPanel;

		public AddActivityVit addActivityVit;

		public UILabel numText;

		public Transform phone;

		private GameObject telphone;

		public Animator NewRemind;

		public ButtonEx returnBtn;

		public ButtonEx goMainBtn;

		public Transform bigBg;

		public Transform smallBg;

		private List<Action> Actions;

		private List<UISceneID> UISceneIDs;

		private List<UISceneID> UISceneIDsOfNewBar;

		public UISceneID UISceneID;

		private int GetMaxResouceCount
		{
			get
			{
				return 0;
			}
		}

		private int NowVit
		{
			get
			{
				return 0;
			}
		}

		private int NowLevel
		{
			get
			{
				return 0;
			}
		}

		private int MaxVit
		{
			get
			{
				return 0;
			}
		}

		private int NowVip
		{
			get
			{
				return 0;
			}
		}

		private long NowGold
		{
			get
			{
				return 0L;
			}
		}

		private long NowDiamond
		{
			get
			{
				return 0L;
			}
		}

		private int BuyVitNumber
		{
			get
			{
				return 0;
			}
		}

		private int FinishBuyVitNumber
		{
			get
			{
				return 0;
			}
		}

		private int LimitStrength
		{
			get
			{
				return 0;
			}
		}

		private void UnBind()
		{
		}

		public void AddAciton(Action _action)
		{
		}

		public void PhoneRemind(bool _isPlay)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void SetResouceItems(MoneyUIData _data)
		{
		}

		private void SetActivityBar()
		{
		}

		public void HeroPanelSetRessouce()
		{
		}

		public void MainSceneSetResouce()
		{
		}

		public void ActivityStorySetResouce()
		{
		}

		public void SetResBar(bool _showPhone, bool _showComeBackMainScene, bool _showComeBack, List<GlobalEnum.ResouceType> _list = null, bool _showBigBg = false, bool _showSmallBg = true)
		{
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		public void ReSetRecycleCurrency()
		{
		}

		public void ReSetDraw()
		{
		}

		public void ReSetVit()
		{
		}

		public void ReSetGold()
		{
		}

		public void ReSetRmb()
		{
		}

		public void ReSetFashion()
		{
		}

		public void ReSetStory()
		{
		}

		public void ReSetActivityStory()
		{
		}

		public void ReSetActivitySpeedUp()
		{
		}

		public void ReSetActivityCurrency()
		{
		}

		public void ReSetActivityCurrency2()
		{
		}

		public void ReSetActivityStamina()
		{
		}

		public void SetVit()
		{
		}

		public void Return()
		{
		}

		public void OpenVitTips()
		{
		}

		public void OpenActivityVitTips()
		{
		}

		private void SetActivityVitTime()
		{
		}

		private void SetVitTime()
		{
		}

		private void SetAllViteTime()
		{
		}

		private void InitObj()
		{
		}

		public void HideAllAddButton()
		{
		}

		private void SetResouce(List<GlobalEnum.ResouceType> _types)
		{
		}

		private int GetBuyStrengthNeedDiamond(int number)
		{
			return 0;
		}

		private int GetBuyStrength(int number)
		{
			return 0;
		}
	}
}
