using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class TaskPanelController : CommonScenePanel
	{
		public TaskMode currentMode;

		public static TaskPanelController current;

		public QuestData data;

		public Transform Current_Grid;

		public GameObject left;

		public UILabel taskName;

		public UILabel taskDesc;

		public UILabel taskDescNum;

		public Transform rewardPoint;

		public UILabel tips;

		public GameObject getBtn;

		public GameObject goBtn;

		public GameObject finishedBtn;

		public GameObject notFinishBtn;

		public UIScrollView rewardScroll;

		public UIGrid rewardGrid;

		private long id;

		public UIScrollView scroll;

		public GameObject scroll_bar;

		public GameObject IconOn;

		public ButtonEx returnViewButton;

		public ButtonEx buttonFinish;

		public ButtonEx buttoneGo;

		public Transform red;

		public Transform yellow;

		public Transform blue;

		public Transform green;

		public Transform bottom;

		public Transform dailyPoint;

		public Transform mainPoint;

		public Transform activityPoint;

		public Transform activityDailyPoint;

		public ButtonEx[] tabBtns;

		public Transform[] grids;

		public ButtonEx GoShopBtn;

		public bool isGuide;

		public Transform UItask;

		public Transform UIachievement;

		public UIGrid UIAchievGrid;

		public UIScrollView UIAchieScorll;

		public Transform UIAchieRedPoint;

		public UIScrollBar UIAchieBar;

		public Transform remindText;

		public ButtonEx getAllBtn;

		public GameObject NullStr;

		private int taskType;

		private Color color1;

		private Color color2;

		public int ActivityDailyIndex
		{
			get
			{
				return 0;
			}
		}

		protected override void Awake()
		{
		}

		public void SetUIAchievRedPoint(bool _isShow)
		{
		}

		protected override void AddConfigItem()
		{
		}

		public void ShowFallPanel(List<DrawResultData> datas)
		{
		}

		public void ShowFallPanel(int _bLV, int aLV, int bVIT, int aVIT, List<DrawResultData> datas)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void CheckTaskMode()
		{
		}

		private void Init()
		{
		}

		public void SetGetAllBtn()
		{
		}

		private void OpenTab(int index)
		{
		}

		public void GetReward()
		{
		}

		private void GoTo()
		{
		}

		public void SetIconOn(Transform tran)
		{
		}

		private void SetGrids(Transform _grid)
		{
		}

		public void SetReward(QuestData _info, Transform rewardContainerTrans)
		{
		}

		public void ReFreshGrid(Transform _grid, bool _isFresh = false)
		{
		}

		public void ReFreshAchieGrid()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void Return()
		{
		}

		public string GetFinishNumber(QuestInfoViewModel achie)
		{
			return null;
		}

		private int Comparison<T>(T x, T y)
		{
			return 0;
		}

		private int AchievComparison<T>(T x, T y)
		{
			return 0;
		}

		private List<LotteryLootData> GetLootResult(ModelCollection<DrawResultData> _datas)
		{
			return null;
		}

		public void SetAfterQusetAction(long _id)
		{
		}
	}
}
