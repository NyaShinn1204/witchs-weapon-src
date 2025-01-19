using System.Text;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;

namespace NodeCanvas.GuideLessonTrees
{
	[DoNotList]
	public class GuideRound : GuideTask
	{
		public enum RoundExecMode
		{
			onlyCMDList = 0,
			basedOnEvent = 1,
			basedOnUserAction = 2,
			skipUserAction = 3
		}

		public enum RoundExecState
		{
			unassign = 0,
			wait4Trigger = 1,
			runB4CMD = 2,
			wait4Action = 3,
			runA4CMD = 4
		}

		public int recPoint;

		public int allowTriggerDelay;

		private RoundExecMode execRuntimeMode;

		[SerializeField]
		private RoundExecMode execMode;

		[SerializeField]
		private ActionEvent evtType;

		[SerializeField]
		private UIBtnType triggerType;

		[SerializeField]
		private long triggerTypeKey;

		private string _triggerID;

		[SerializeField]
		private GuideTaskList _b4cmdActionList;

		[SerializeField]
		private GuideTaskList _a4cmdActionList;

		private RoundExecState execState;

		private int currentActionIndex;

		private StringBuilder sb;

		private static bool isDebug;

		private bool isAllowRunningWait4Action;

		private bool isA4CMDRunning;

		private ActionEvent _waitActionEvnt;

		private static GameObject currTriggerObj;

		private static Transform currTriggerObjTF;

		private static Vector3 pos;

		private static Vector3 scale;

		private static int frameCountAfterFirstCheck;

		private static Vector3 UIRoot_offset;

		private static float ContentScreenW;

		public RoundExecMode p_execMode
		{
			get
			{
				return default(RoundExecMode);
			}
			set
			{
			}
		}

		public string triggerID
		{
			get
			{
				return null;
			}
		}

		public GuideTaskList b4cmdList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GuideTaskList a4cmdList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Task b4cmdTask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Task a4cmdTask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public ActionEvent waitActionEvnt
		{
			get
			{
				return default(ActionEvent);
			}
		}

		public static string ComposeTriggerID(UIBtnType type, long typeKey)
		{
			return null;
		}

		public bool IsTriggerAsButtonEx()
		{
			return false;
		}

		public void B4CmdAddAction(GuideTask action)
		{
		}

		public void A4CmdAddAction(GuideTask action)
		{
		}

		public RoundExecState GetExecState()
		{
			return default(RoundExecState);
		}

		public void SetExecModeAsOnlyRunA4CMD()
		{
		}

		public string GetSummary()
		{
			return null;
		}

		private bool isA4cmdListEmpty()
		{
			return false;
		}

		private static void DebugLog(string str)
		{
		}

		private static void DebugLogError(string str)
		{
		}

		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		protected override void OnExecute()
		{
		}

		private void AutoReset()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnStop()
		{
		}

		private void AutoCheck()
		{
		}

		private void JudgeRoundExecState()
		{
		}

		private Status ExecB4CMDActions()
		{
			return default(Status);
		}

		private Status ExecA4CMDActions()
		{
			return default(Status);
		}

		public void EndWaitAction()
		{
		}

		public static void SetTriggerObjNull()
		{
		}

		public static bool IsTriggerObjValid()
		{
			return false;
		}

		public static GameObject GetCurrTriggerObj()
		{
			return null;
		}

		private static Vector3 ReCaculateWidget(UIWidget widgetObj)
		{
			return default(Vector3);
		}

		public static Vector3 GetCurrTriggerObjRelativeLocalPos()
		{
			return default(Vector3);
		}

		public void CloseRecvPlayerAction()
		{
		}

		private void OnUpdateWait4Trigger()
		{
		}

		private static bool IsCatchStableTriggerObj(string triggerID)
		{
			return false;
		}

		private static bool IsTriggerObjStable()
		{
			return false;
		}

		private void OnUpdateWait4Action()
		{
		}

		public void RoundClear()
		{
		}
	}
}
