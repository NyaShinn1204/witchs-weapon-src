using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;
using WaterBell.ProjX.Guide.Event;

namespace WaterBell.ProjX.Guide.Content
{
	public class Lesson
	{
		public enum RunningMode
		{
			unassign = 0,
			normalMode = 1,
			continueMode = 2,
			storyMode = 3,
			debugStoryMode = 4
		}

		public enum RoundExecState
		{
			unassign = 0,
			wait4Trigger = 1,
			runB4CMD = 2,
			wait4Action = 3,
			recvAction = 4,
			runA4CMD = 5
		}

		private static bool isDebug;

		public LessonSettingData data;

		public GameObject currTriggerObj;

		public bool isCurrTriggerCatched;

		private Dictionary<int, RoundInfo> playerActionDict;

		private Dictionary<int, RoundInfo> combatActionDict;

		private int recID;

		private int currRoundNum;

		private RunningMode currRunningMode;

		private RoundExecState currRoundState;

		private List<int> continuePlayPlanList;

		private int continuePlayPlanIndex;

		private int continue2TargeRoundIdx;

		private bool isStory;

		private RecPointPrepareInfo recPointPrepareInfo;

		private const string ScreenMaskID = "screenmask";

		private const string CombatSysID = "combat";

		private ActionEvent waitActionEvnt;

		private bool isScreenMaskAsTrigger;

		private long previousBGM;

		private Coroutine delayNextRoundTask;

		private Vector3 pos;

		private Vector3 scale;

		private int frameCountAfterFirstCheck;

		public GameObject CurrTrigger
		{
			get
			{
				return null;
			}
		}

		public string CurrTriggerName
		{
			get
			{
				return null;
			}
		}

		public Lesson()
		{
		}

		public Lesson(int progressRecID, string suffixName)
		{
		}

		private static void DebugLog(string str)
		{
		}

		private static void DebugLogError(string str)
		{
		}

		public int GetCurrRoundNum()
		{
			return 0;
		}

		public RunningMode GetRunningMode()
		{
			return default(RunningMode);
		}

		public bool GetIsStory()
		{
			return false;
		}

		public int GetNextRecState(int oldRecState)
		{
			return 0;
		}

		public List<int> GetRoundIndexSeq2TargetRound(int targetRoundIndex)
		{
			return null;
		}

		public void BeginRound(int RoundNum = 0, RunningMode mode = RunningMode.normalMode)
		{
		}

		private void HandleInitialBGM()
		{
		}

		private void OpenStageTransition()
		{
		}

		public void BeginRoundFromRecState(int currRecState)
		{
		}

		public void NextRound()
		{
		}

		[DebuggerHidden]
		private IEnumerator Try2DoNextRound()
		{
			return null;
		}

		private void DoNextRound()
		{
		}

		public void EndLesson()
		{
		}

		public void TryRecoverPreviousBGM()
		{
		}

		private void RenderRound(int roundIdx)
		{
		}

		public void TryPrepareRecPoint(RoundInfo rInfo)
		{
		}

		private void RenderRound(RoundInfo rInfo)
		{
		}

		public bool GetIsWait4SpecifiedAction(ActionEvent actionEvt)
		{
			return false;
		}

		public RecPointPrepareInfo GetCurrRecPointPrepareInfo()
		{
			return null;
		}

		public void ClearCurrRecPointPrepareInfo()
		{
		}

		public bool IsValidButtonExObj(ButtonEx btnExObj)
		{
			return false;
		}

		private void ExecRoundActions(RoundInfo rInfo)
		{
		}

		public void TryExecSkipActionOnEndRound(int rInfoIdx)
		{
		}

		public void ExecSkipActions(int rInfoIdx)
		{
		}

		[DebuggerHidden]
		public IEnumerator WaitForTrigger(Lesson currLesson, RoundInfo rInfo)
		{
			return null;
		}

		private void ExecB4CMDActions(RoundInfo rInfo, bool isWait4PlayAction)
		{
		}

		private void RunB4CMD(RoundInfo rInfo)
		{
		}

		public void OnBtnUIEvt(BtnUIEvent btnEvt)
		{
		}

		public void OnCombatEvt(ResponsiveEvent combatEvt)
		{
		}

		public void PushRecPointIfWin(int recPointState)
		{
		}

		private void ExecA4CMDAction(RoundInfo rInfo)
		{
		}

		public void WaitInteractiveAction(RoundInfo rInfo)
		{
		}

		private void PrepareAndClear4RoundActions()
		{
		}

		private string ConvertArgs2String(object[] args)
		{
			return null;
		}

		public void MarkPassed()
		{
		}

		internal void cancelInterrupt()
		{
		}

		internal void doInterrupt()
		{
		}

		public void WaitForSecAndExeAfterTriggerCmd(int sec)
		{
		}

		[DebuggerHidden]
		private IEnumerator WaitForSec(int sec, Lesson currLesson, RoundInfo rInfo)
		{
			return null;
		}

		public int FindConversationEndRound()
		{
			return 0;
		}
	}
}
