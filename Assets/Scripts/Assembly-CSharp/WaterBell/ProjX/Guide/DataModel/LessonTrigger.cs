using WaterBell.ProjX.Guide.Event;

namespace WaterBell.ProjX.Guide.DataModel
{
	public class LessonTrigger
	{
		public static readonly int MinMainRecID;

		public static readonly int RenameMainRecID;

		public static readonly int MainRecID_5;

		public static readonly int MainRecID_6;

		public static readonly int MainRecID_7;

		public static readonly int MainRecID_8;

		public static readonly int MainUIBegin_MainRecID;

		public static readonly int GuideDraw_MainRecID;

		public static readonly int MaxMainRecID;

		public static readonly int RecOverState;

		public static readonly int RecActiveState;

		private TypeCsvLessonTrigger _rawData;

		private int _recState;

		public readonly UIEvtType uiEvtType;

		private long[] _questList;

		private const int guideJobFinishedStatus = 0;

		public TypeCsvLessonTrigger rawData
		{
			get
			{
				return null;
			}
		}

		public long[] questList
		{
			get
			{
				return null;
			}
		}

		public int recID
		{
			get
			{
				return 0;
			}
		}

		public string storyID
		{
			get
			{
				return null;
			}
		}

		public string uiEvtParam
		{
			get
			{
				return null;
			}
		}

		public string fileSubffixName
		{
			get
			{
				return null;
			}
		}

		public int roleLvConstrain
		{
			get
			{
				return 0;
			}
		}

		public string uiEvtID
		{
			get
			{
				return null;
			}
		}

		public int recState
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool allowAutoTrigger
		{
			get
			{
				return false;
			}
		}

		public bool isRecFinished
		{
			get
			{
				return false;
			}
		}

		public int maxRecState
		{
			get
			{
				return 0;
			}
		}

		public int nextID
		{
			get
			{
				return 0;
			}
		}

		public LessonTrigger(TypeCsvLessonTrigger csvTrigger)
		{
		}

		private void GenerateQuestList()
		{
		}

		public void UpdateRecState()
		{
		}

		public void UpdateRecByQuestID(long questID)
		{
		}

		public bool isFinishedAccordingLocalPref()
		{
			return false;
		}

		public void TrySave2LocalPrefAsFinish()
		{
		}

		public bool IsAllConditionPassed()
		{
			return false;
		}
	}
}
