using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace WaterBell.ProjX.View.Panel
{
	public class SweepPanel : UIPanelSingle
	{
		public enum SweepTypes
		{
			General = 0,
			Activity = 1
		}

		private static SweepPanel m_Current;

		public UITable uiTabel;

		public UIScrollView uiScrollView;

		public DoTweenLabel expTweenLabel;

		public DoTweenLabel goldTweenLabel;

		public UIPanelSingleContainer lootResultContainer;

		public UIPanelSingleContainer container;

		public LoadUIPanelSingle ChapterLevelUpPanelLoad;

		public ButtonEx closeButton;

		public ButtonEx skipAnimButton;

		private ProgressSystemSweepView progressSystemSweepView;

		private ApLevelDetailView apLevelDetailView;

		private List<SweepLootItemData> lootItemDataList;

		private long gold;

		private long goldTotal;

		private long exp;

		private long expTotal;

		private long instanceId;

		private SweepTypes sweepType;

		private Action onCloseEvent;

		private int NeedShowSweepBeforeLv;

		private int NeedShowSweepAfterLv;

		private int NeedShowStaminaBefore;

		private int NeedShowStaminaAfter;

		public static bool IsClose
		{
			get
			{
				return false;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static SweepPanel GetInstance()
		{
			return null;
		}

		public void OpenPanel(long instanceID, SweepTypes sweepType, Action onCloseEvent)
		{
		}

		private void ActivitySweepSuccful()
		{
		}

		private void SweepSuccessful()
		{
		}

		private void ShowResult(List<SweepLootItemData> loots)
		{
		}

		private void DirectClosePanel()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		[DebuggerHidden]
		private IEnumerator CreatResultItem(float delay, int resultIndex)
		{
			return null;
		}

		private void SkipAnim()
		{
		}

		private void CheckChapterLevelUp()
		{
		}

		private void ChapterLevelUp()
		{
		}
	}
}
