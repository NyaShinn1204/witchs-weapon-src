using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Core.Manager.Audio;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class Lottery : UIPanelSingle
	{
		private const int PROGRESS_WEAPON_COUNT_MAX = 6;

		public static Lottery current;

		public static int state;

		private static int freeGoldInterval;

		private static int freeGoldMax;

		private static int freeGoldCount;

		private static int freeDiamondCount;

		private static int freeDiamondMax;

		public static long needGold;

		public static long needGoldMultiply;

		public static long needDiamond;

		public static long needDiamondMultiply;

		public GameObject cupBroken;

		public UILabel goldFreeTimeLabel;

		public GameObject goldFreeSprite;

		public UILabel diamondFreeTimeLabel;

		public GameObject diamondFreeSprite;

		public UILabel needGoldLabel;

		public UILabel needGoldMultiplyLabel;

		public UILabel needDiamondLabel;

		public UILabel needDiamondMultiplyLabel;

		private DateTime freeGoldTime;

		private DateTime freeDiamondTime;

		private bool isGoldFree;

		private bool isDiamondFree;

		public ButtonEx returnButton;

		public ButtonEx goldDrawButton;

		public ButtonEx goldDrawTenButton;

		public ButtonEx diamondDrawButton;

		public ButtonEx diamondDrawTenButton;

		public ButtonEx closeGoldButton;

		public ButtonEx closeDiamondButton;

		public ButtonEx openGoldButton;

		public ButtonEx openDiamondButton;

		public Animator progressAnim;

		public GameObject[] weaponEffs;

		public List<GameObject> weaponCenterEffsList;

		public List<GameObject> itemCenterEffsList;

		public GameObject goldCup;

		public GameObject diamondCup;

		public Camera girlCamera;

		public LotteryResultPanel resultPanel;

		public DrawSystemManagerView drawView;

		private ObservablePlayer playerInfo;

		private AudioPlay waitingSound;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnDrawButtonClick(GameObject go)
		{
		}

		public void DrawFinish()
		{
		}

		public void OpenResultPanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void SetGoldButton(bool isOpen)
		{
		}

		private void SetDiamondButton(bool isOpen)
		{
		}

		public void ReDraw()
		{
		}

		public void GetResultByGold(int count)
		{
		}

		public void GetResultByDiamond(int count)
		{
		}

		public void PlayWaitingSound()
		{
		}

		public void StopWaitingSound()
		{
		}

		[DebuggerHidden]
		private IEnumerator UpdateFreeTime()
		{
			return null;
		}

		public void SyncData()
		{
		}

		private DateTime ToDateTime(long timeStamp)
		{
			return default(DateTime);
		}

		private string TimeString(TimeSpan time)
		{
			return null;
		}
	}
}
