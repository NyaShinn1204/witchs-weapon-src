using System;
using System.Collections;
using System.Diagnostics;
using NodeCanvas.GuideLessonTrees;
using WaterBell.ProjX.Guide.Content;
using WaterBell.ProjX.Guide.DataModel;

namespace WaterBell.ProjX.Guide
{
	public class GuideLessonExecutor
	{
		public enum ExtraAction
		{
			Empty = 0,
			FireGuideEvent = 1,
			BeginGuideCombatBackGuide = 2,
			BeginGuideCombatBackMain = 3,
			StartTargetLesson = 4,
			Back2MainScene = 5
		}

		public static Lesson CurrentLesson;

		public static GuideLessonTree CurrentLessonTree;

		private static GuideLessonExecutor _instance;

		private string lessonAssetBasePath;

		private bool isLessonRunning;

		private bool isCanStartNextLesson;

		private bool isStartEndLesson;

		private GuideLessonTree tmpOldTree;

		public bool isRunning
		{
			get
			{
				return false;
			}
		}

		public static GuideLessonExecutor GetInstance()
		{
			return null;
		}

		public static bool IsTriggerReady()
		{
			return false;
		}

		public static bool IsCurrTriggerAsButtonEx()
		{
			return false;
		}

		public bool IsEnableReadSelectedSvCache()
		{
			return false;
		}

		public bool IsIgnoreEmptySlotWarning()
		{
			return false;
		}

		private void Init()
		{
		}

		public void StartForceGuideLesson(int recID)
		{
		}

		public bool IsStoryExist(long storyID)
		{
			return false;
		}

		public void StartStoryLesson(long storyID, Action<bool> callback = null, Function sFailed = null, Function sCancel = null)
		{
		}

		public void StartDebugStoryLesson(string lessonSubffixName)
		{
		}

		public void StartGuideTaskLesson(string lessonSubffixName)
		{
		}

		public void ContinueForceGuideLesson(LessonTrigger lessonTrigger)
		{
		}

		private void LoadAndStartLesson(string fileSuffixName, GuideLessonTree.RunningMode mode, int recID = -1, string storyID = "", Action<bool> callback = null)
		{
		}

		[DebuggerHidden]
		private IEnumerator TryStartLesson(string fileSuffixName, GuideLessonTree.RunningMode mode, int recID, string storyID, Action<bool> callback = null)
		{
			return null;
		}

		private void LoadAndContinueLesson(string fileSuffixName, GuideLessonTree.RunningMode mode, int state, int recID = -1, string storyID = "")
		{
		}

		public void StartTestLessonTree()
		{
		}

		public bool TestLoadAndStartLesson(string inputFileSuffixName)
		{
			return false;
		}

		public void EndAndClear(ExtraAction action = ExtraAction.Empty, object[] cmdArgs = null)
		{
		}

		public bool IsEndLessonFinished()
		{
			return false;
		}

		[DebuggerHidden]
		private IEnumerator TryEndLesson(ExtraAction action, object[] cmdArgs)
		{
			return null;
		}

		private void DoExtraAction(ExtraAction action, object[] cmdArgs)
		{
		}

		public void TryExtraSwitch(object[] cmdArgs)
		{
		}

		public void TryEndLessonOnInterrupted()
		{
		}

		public void ClearResidualUIBeforeVictoryOrDefeat()
		{
		}
	}
}
