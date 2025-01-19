using System.Collections.Generic;
using WaterBell.ProjX.Guide.DataModel;
using WaterBell.ProjX.Guide.Event;

namespace WaterBell.ProjX.Guide
{
	public class GuideLessonProgressRecorder
	{
		private static GuideLessonProgressRecorder _instance;

		private Dictionary<string, string> dict;

		private Dictionary<int, LessonTrigger> recMap;

		public Dictionary<string, LessonTrigger> storyMap;

		private Dictionary<string, List<LessonTrigger>> uiEvtMap;

		private Dictionary<long, LessonTrigger> task2triggerMap;

		public static readonly int MainGuideRecID;

		private int mainRecID;

		private int mainRecCount;

		public static GuideLessonProgressRecorder GetInstance()
		{
			return null;
		}

		public bool IsAllowEnterIntoGuideScene()
		{
			return false;
		}

		public bool IsForceGuideFinish()
		{
			return false;
		}

		public bool IsProgresInfoReady()
		{
			return false;
		}

		public int GetMainRecID()
		{
			return 0;
		}

		public int GetMaxMainRecID()
		{
			return 0;
		}

		public void BuildProgressFromQuest()
		{
		}

		private void PrintProgress()
		{
		}

		private void GenerateAndUpdateTriggers()
		{
		}

		private void UpdateMainRecID(bool isInitialUpdate)
		{
		}

		public void UpdateMainRecIDWhenAutoTriggerFinish()
		{
		}

		private void ClearProgress()
		{
		}

		public LessonTrigger GetConditionPassedTriggerByUIEvt(GuideUIEvent evt)
		{
			return null;
		}

		public LessonTrigger GetLessonTriggerByRecID(int recID)
		{
			return null;
		}

		private void AddLessonTriggerRef2Dict(LessonTrigger tmpTrigger)
		{
		}

		private void AddTaskMap(LessonTrigger trigger)
		{
		}

		public void CheckAndUpdateRecState(long questJobID)
		{
		}

		private void RmLessonTriggerRef2Dict(LessonTrigger tmpTrigger)
		{
		}

		public bool IsLessonKeyExist(string key)
		{
			return false;
		}
	}
}
