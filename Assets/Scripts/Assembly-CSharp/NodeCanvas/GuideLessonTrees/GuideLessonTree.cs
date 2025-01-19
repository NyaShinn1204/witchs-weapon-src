using System;
using System.Collections.Generic;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;
using WaterBell.ProjX.Guide.Event;

namespace NodeCanvas.GuideLessonTrees
{
	[GraphInfo]
	public class GuideLessonTree : Graph
	{
		[Serializable]
		private struct DerivedSerializationData
		{
			public ClaimInfo claimInfo;

			public string sentenceFName;
		}

		public enum RunningMode
		{
			unassign = 0,
			normalMode = 1,
			continueMode = 2,
			storyPlayMode = 3,
			debugStoryMode = 4,
			guideTaskMode = 5
		}

		private static bool isDebug;

		[SerializeField]
		private ClaimInfo _claimInfo;

		[SerializeField]
		private string sentenceFileName;

		[SerializeField]
		private long _defaultBGM;

		[NonSerialized]
		public List<string> sentenceList;

		[NonSerialized]
		public Dictionary<string, string> sentenceAllList;

		private RunningMode runningMode;

		[NonSerialized]
		public int recID;

		private bool hasStory;

		[NonSerialized]
		public string storyID;

		private long previousBGM;

		[NonSerialized]
		private bool isAllowReadSelectedSvCache;

		[NonSerialized]
		private bool isAllowIngoreEmptySlotWarning;

		private bool isAddAutoOut2RoleSpeak;

		private bool isAllowSkipMngrAnt;

		private bool isRunningAsContinuePlay;

		private List<int> continuePlayPlan;

		private int continuePlayIdx;

		private Dictionary<int, GuideRound> playerActionDict;

		private Dictionary<int, GuideRound> responsiveActionDict;

		public ClaimInfo claimInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GLTNode currentNode { get; set; }

		public static GuideLessonTree currentDialogue { get; private set; }

		public static GuideLessonTree previousDialogue { get; private set; }

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return false;
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return false;
			}
		}

		public override bool autoSort
		{
			get
			{
				return false;
			}
		}

		public override bool useLocalBlackboard
		{
			get
			{
				return false;
			}
		}

		public static event Action<GuideLessonTree> OnDialogueStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<GuideLessonTree> OnDialoguePaused
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<GuideLessonTree> OnDialogueFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
		{
			add
			{
			}
			remove
			{
			}
		}

		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		public override void OnDerivedDataDeserialization(object data)
		{
		}

		public void Init(int recID, string storyID, RunningMode mode)
		{
		}

		private void OpenStageTransition()
		{
		}

		public bool IsRunningStoryMode()
		{
			return false;
		}

		public RunningMode GetRunningMode()
		{
			return default(RunningMode);
		}

		public bool HasStoryConversation()
		{
			return false;
		}

		private void HandleInitialBGM()
		{
		}

		public void TryRecoverPreviousBGM()
		{
		}

		public int FindConversationEndNodeID()
		{
			return 0;
		}

		public void TryExecSkipActionOnEndRound(int nodeID)
		{
		}

		public bool IsAllowReadSelectedSvCache()
		{
			return false;
		}

		public void SetAllowReadSelectedSvCache(bool val)
		{
		}

		public bool IsIgnoreEmptySlotWarning()
		{
			return false;
		}

		public void SetIngoreEmptySlotWarning(bool val)
		{
		}

		public void TryLoadSentenceFile()
		{
		}

		public static string CurrentLanguageOrigLine(string sOrigLine)
		{
			return null;
		}

		public void ExecSkipNodesStory(int targetNodeID)
		{
		}

		private void Jump2Node(int targetNodeID, bool isOnlyRunA4Cmd = false)
		{
		}

		public void EnterNode2(GLTNode node)
		{
		}

		public int TryInitContinuePlan(int state)
		{
			return 0;
		}

		public GLTNode GetLastIDNode()
		{
			return null;
		}

		public void Continue(int index = 0)
		{
		}

		public void EnterNode(GLTNode node)
		{
		}

		public static void RequestSubtitles(SubtitlesRequestInfo info)
		{
		}

		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUnpaused()
		{
		}

		protected override void OnGraphStoped()
		{
		}

		protected override void OnGraphPaused()
		{
		}

		public void BindPlayerAction(int triggerKey, GuideRound round)
		{
		}

		public void BindRespEventAction(int respEvtKey, GuideRound round)
		{
		}

		public void ResetAction()
		{
		}

		public bool IsValidButtonExObj(ButtonEx btnExObj)
		{
			return false;
		}

		public bool GetIsWait4SpecifiedAction(ActionEvent actionEvt)
		{
			return false;
		}

		public void CloseLesson()
		{
		}

		public void OnBtnUIEvt(BtnUIEvent btnEvt)
		{
		}

		public void OnResponsiveEvt(ResponsiveEvent respEvt)
		{
		}

		private static void DebugLog(string str)
		{
		}

		private static void DebugLogError(string str)
		{
		}

		public bool IsAllowSkipMngrAnt()
		{
			return false;
		}

		public void SkipMngrAnt()
		{
		}
	}
}
