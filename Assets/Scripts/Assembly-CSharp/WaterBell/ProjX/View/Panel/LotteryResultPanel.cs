using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LotteryResultPanel : UIPanelSingle
	{
		public static LotteryResultPanel current;

		public GameObject gold;

		public UILabel goldLabel;

		public GameObject diamond;

		public UILabel diamondLabel;

		private LotteryUniverse lotteryUniverse;

		public UITexture universeRT;

		public UILabel residueNumLabel;

		public UILabel redrawLabel;

		public GameObject bg;

		public UILabel goldTotalLabel;

		public UILabel drawCurrencyLabel;

		public UILabel getDrawCurrencyLabel;

		public GameObject getDrawCurrency;

		public UILabel guaranteesTimeCountLabel;

		public GameObject guaranteesInfo;

		public LoadUIPanelSingle lotteryUniverseLoader;

		public UIPanelSingleContainer lootsContainer;

		public Vector3 lootsShowPos;

		private Vector3 lootsInitPos;

		public UIPanelSingleContainer resolveContainer;

		public Transform resolveMain;

		public ButtonEx closeButton;

		public ButtonEx confirmButton;

		public ButtonEx redrawButton;

		public ButtonEx directShowResultButton;

		public ButtonEx storeButton;

		private List<LotteryLootData> lotteryLootDataList;

		private float redrawTime;

		private DrawSystemManagerView drawView;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnSelectStar(int count)
		{
		}

		private void OnConnectComplete()
		{
		}

		public void JPDrawFinishExecuted()
		{
		}

		public void CheckClose()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void OnDrawFinish(List<LotteryLootData> lotteryLootDataList, List<Star> starList)
		{
		}

		private void OnShowLootDetail(LotteryLootData lotteryLootData)
		{
		}

		public void OnShowLootDetailComplete(List<LotteryLootData> lotteryLootDataList, List<Star> starList)
		{
		}

		private void OnLootAnimComplete()
		{
		}

		[DebuggerHidden]
		private IEnumerator ShowResolveItem(LotteryResultResolve resolve, LotteryLoot loot, float delay)
		{
			return null;
		}

		private void Redraw()
		{
		}

		protected override void AddConfigItem()
		{
		}
	}
}
