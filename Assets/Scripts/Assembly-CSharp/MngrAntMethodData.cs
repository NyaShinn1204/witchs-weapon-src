using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;
using WaterBell.ProjX.View.Panel;

public class MngrAntMethodData
{
	public class IMngrAntMethod_ShowAward : MngrAntMethod.IMngrAntMethod
	{
		private static GetAwardsPanel view;

		private List<LotteryLootData> dataList;

		private Action onCloseEvent;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowAward(List<LotteryLootData> s_dataList, Action s_onCloseEvent = null)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_ShowStarUp : MngrAntMethod.IMngrAntMethod
	{
		private LoadUIPanelSingle loadingUIPanelSign;

		private StarUpSuccPanel view;

		private int StarLevel;

		private TypeCsvServantStarInfo data;

		private TypeCsvServantStarInfo beforedata;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowStarUp(LoadUIPanelSingle s_loadingUIPanelSign, int sStarLevel, TypeCsvServantStarInfo s_data, TypeCsvServantStarInfo s_beforeData)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_Sweep : MngrAntMethod.IMngrAntMethod
	{
		private long instanceID;

		private SweepPanel.SweepTypes sweepType;

		private Action onCloseEvent;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_Sweep(long instanceID, SweepPanel.SweepTypes sweepType, Action onCloseEvent)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_ShowRankUp : MngrAntMethod.IMngrAntMethod
	{
		private LoadUIPanelSingle loadingUIPanelSign;

		private UIPanelSingle view;

		private RankUpPanelData data;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowRankUp(LoadUIPanelSingle s_loadingUIPanelSign, RankUpPanelData s_data)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_ShowLevelUP : MngrAntMethod.IMngrAntMethod
	{
		private static GameObject view;

		private int BeforeLv;

		private int AfterLv;

		private int StaminaBefore;

		private int StaminaAfter;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowLevelUP(int sBeforeLv, int sAfterLv, int sStaminaBefore, int sStaminaAfter)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_ShowGuide : MngrAntMethod.IMngrAntMethod
	{
		private LessonTrigger trigger;

		private bool isDone;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowGuide(LessonTrigger trigger)
		{
		}

		public void Done()
		{
		}
	}

	public class IMngrAntMethod_ShowUnlockNotificationPanel : MngrAntMethod.IMngrAntMethod
	{
		private bool m_IsDoneOver;

		private UnlockNotificationPanelData m_Data;

		public float SortID
		{
			get
			{
				return 0f;
			}
		}

		public bool IsDoneOver
		{
			get
			{
				return false;
			}
		}

		public bool IsRunInBattle
		{
			get
			{
				return false;
			}
		}

		public IMngrAntMethod_ShowUnlockNotificationPanel(UnlockNotificationPanelData data)
		{
		}

		public void Done()
		{
		}
	}
}
