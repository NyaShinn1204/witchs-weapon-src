using System.Collections.Generic;
using Apmod;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Playmode
{
	public class BasicActivityPlayMode : NormalMode
	{
		protected static List<WaterBell.ProjX.Data.Entity.RankData> rankDatas;

		private List<SingleServantSimple> cacheMercenary;

		public ActivityPlayModeRuleType RuleType;

		protected int currentLevelIndex;

		protected int currentBuffIndex;

		protected int currentR5RoundType;

		protected long currentR5BuffID;

		private int floorBeforeBattle;

		private int buffCountBeforeBattle;

		public virtual int FloorBeforeBattle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int BuffCountBeforeBattle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int APMultTimes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public BasicActivityPlayMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		public SingleServantSimple GetCacheMercenaryByID(long ID)
		{
			return null;
		}

		public static List<WaterBell.ProjX.Data.Entity.RankData> GetRankData()
		{
			return null;
		}

		public static WaterBell.ProjX.Data.Entity.RankData GetRankDataByType(int type)
		{
			return null;
		}

		public static void SetRankDatas(RankDatas rawData)
		{
		}

		public virtual void SetLevel(int levelIndex, int r5RoundType = 0)
		{
		}

		public virtual void SetBuff(int buffIndex)
		{
		}

		public void SetR5BuffID(long currentR5BuffID)
		{
		}

		public virtual int GetFloor()
		{
			return 0;
		}

		public virtual int CurrentR5RoundType()
		{
			return 0;
		}

		public virtual long GetBuffID()
		{
			return 0L;
		}

		protected override void Init()
		{
		}

		public virtual int GetCurrentFloor(int r5RoundType = 0)
		{
			return 0;
		}

		public virtual int GetMaxFloor(int r5RoundType = 0)
		{
			return 0;
		}

		public virtual List<ActivityPlayModeLevelInfo> GetCurrentFloorLevelInfo()
		{
			return null;
		}

		public virtual List<ActivityPlayModeBuffInfo> GetBuffStatus()
		{
			return null;
		}

		public virtual List<bool> GetBuffFinishState()
		{
			return null;
		}

		public virtual ActionResult CanGetReward(int r5RoundType = 0)
		{
			return default(ActionResult);
		}

		public virtual ActionResult CanGotoNextFloor(int r5RoundType = 0)
		{
			return default(ActionResult);
		}

		public virtual List<ActivityPlayModeBuffInfo> CurrentLevelBuff(int r5roundType = 0)
		{
			return null;
		}

		public virtual long GetResetCD()
		{
			return 0L;
		}

		public virtual ActionResult CanReset()
		{
			return default(ActionResult);
		}

		public void ClearCache()
		{
		}

		public int GetR5DifficultByRoundType(int r5RoundType)
		{
			return 0;
		}

		public bool GetR5IsSpByType(int r5RoundType)
		{
			return false;
		}

		public override void ParseInstanceSettingData(string jsonStr)
		{
		}

		public override ActionResult IsAllow2Fight()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAble2SelectCard()
		{
			return default(ActionResult);
		}

		public override void OnCombatRestart()
		{
		}

		public override void OnTryStartBegin()
		{
		}
	}
}
