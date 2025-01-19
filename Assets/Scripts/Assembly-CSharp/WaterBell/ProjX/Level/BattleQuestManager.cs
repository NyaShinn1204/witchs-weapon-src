using System.Collections.Generic;
using LitJson;
using WaterBell.ProjX.Level.Config;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;
using unit;

namespace WaterBell.ProjX.Level
{
	public class BattleQuestManager
	{
		public enum QuestTriggerType
		{
			Undefined = 0,
			TimeLimit = 1,
			EnemyKill = 2,
			Protection = 3,
			HeroDamageStats = 4,
			HeroPerish = 5,
			AllZoneClear = 6
		}

		public enum LevelBonusType
		{
			None = 0,
			Time = 1,
			HPLeft = 2,
			VIPHpLeft = 3,
			DamageCount = 4
		}

		public enum LevelObjectiveType
		{
			KillAll = 0,
			Decapitation = 1,
			Survive = 2,
			DamageCount = 3,
			ProtectVIP = 4,
			ProtectAll = 5,
			ClearAllZones = 6,
			DamageCountInLimitTime = 7,
			ProtectNPCAllTheWay = 8
		}

		public enum DamageStatusOptions
		{
			BiggerOrEqualThanTargetDamage = 0,
			LessThanTargetDamage = 1,
			BiggerOrEqualThanBonusDamage = 2,
			LessTanBonusDamage = 3
		}

		public class QuestTrigger
		{
			private CryptionFloat _timer;

			private CryptionFloat _timerElapsed;

			private CryptionInt _DamageStatsCurrent;

			private CryptionInt _DamageStatsThreshold;

			public QuestTriggerType Type;

			public bool EnemyKillIsAll;

			public List<MonsterStats> EnemyKillList;

			public bool ProtectiontIsAll;

			public List<MonsterStats> ProtectionList;

			public bool DamageStatsIsHeroDamageDealt;

			public DamageStatusOptions DamageStatOption;

			public Dictionary<string, bool> ZoneStates;

			public bool HeroKilled;

			public float Timer
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float TimerElapsed
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public int DamageStatsCurrent
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int DamageStatsThreshold
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public QuestTrigger()
			{
			}

			public QuestTrigger(QuestTriggerType type)
			{
			}
		}

		public class MonsterStats
		{
			public string name;

			public string ui_name;

			public bool killed;
		}

		public enum QuestEntityType
		{
			NON_NPC = 0,
			NPC_NORMAL = 1,
			NPC_FOR_PROTECTION = 2
		}

		public class DamageStatus
		{
			public int DamageStatsThreshold;

			public int DamageCurrent;

			public int DamageForSwipe;
		}

		private static BattleQuestManager _instance;

		public int WinLoseJudgementStatus;

		private List<QuestTrigger> triggers;

		private int[,] WinJudgementTriggerIndex;

		private int[,] LoseJudgementTriggerIndex;

		private LevelBonusType _levelBonusType;

		private float _levelBonusParam;

		private LevelObjectiveType _levelObjectiveType;

		private int idxTimeTrigger;

		private int idxEnemyKillTrigger;

		private int idxProtectionTrigger;

		private int idxDamageTrigger;

		private DamageStatus dms;

		private int questTotalAreaNum;

		private QuestType questType;

		private QuestCode questWinCode;

		private int questOptID;

		private string questOptName;

		private int questTime;

		private float questTimeElapsed;

		public List<int> zoneDefeatedNumInArea;

		public List<int> zoneTotalNumInArea;

		public long targetDmg;

		public long sweepDmg;

		private bool[] triggerCheck;

		private Dictionary<string, bool> monsterBornStatus;

		private int monsterKillCount;

		private int monsterTotalCount;

		public LevelObjectiveType levelObjectiveType
		{
			get
			{
				return default(LevelObjectiveType);
			}
		}

		public LevelBonusType levelBonusType
		{
			get
			{
				return default(LevelBonusType);
			}
		}

		public List<QuestTrigger> Triggers
		{
			get
			{
				return null;
			}
		}

		public bool[] TriggerStatus
		{
			get
			{
				return null;
			}
		}

		public static string GetMonsterUIName(long id)
		{
			return null;
		}

		public void SaveTriggerStatusToJSON(JsonWriter jw)
		{
		}

		public void RestoreTriggerStatusFromJSON(JsonData tiggersData, InstanceSettingData eData)
		{
		}

		public QuestEntityType GetEnityLogicType(Entity e)
		{
			return default(QuestEntityType);
		}

		public int GetQuestRemainningTime()
		{
			return 0;
		}

		public int GetQuestElapsedTime()
		{
			return 0;
		}

		public int GetQuestTotalTime()
		{
			return 0;
		}

		public List<MonsterStats> GetMonsterKillListForUI()
		{
			return null;
		}

		public List<MonsterStats> GetProtectionListForUI()
		{
			return null;
		}

		public DamageStatus GetDamageStatusForUI()
		{
			return null;
		}

		public Dictionary<string, int> GetAliveNPC()
		{
			return null;
		}

		public string GetBonusUnlockMessage()
		{
			return null;
		}

		public static string GetSweepUnlockMessage(LevelBonusType bonusType, float bonusParam)
		{
			return null;
		}

		public static BattleQuestManager GetInstance()
		{
			return null;
		}

		public void OnLoadIn(InstanceSettingData eData)
		{
		}

		public void OnRestart(InstanceSettingData eData)
		{
		}

		private void ResetQuestSetting(InstanceSettingData eData)
		{
		}

		public void AddListener()
		{
		}

		public void RmListener()
		{
		}

		public int AnalyzeQuestAchievedStar()
		{
			return 0;
		}

		public void PatchDamage(long targetDmg, long sweepDmg)
		{
		}

		public static List<QuestTrigger> GenerateTriggersFromLevelData(InstanceSettingData eData, bool DataUseforEditor)
		{
			return null;
		}

		private static List<MonsterStats> GenerateMonsterStatusList(InstanceSettingData eData, string[] data)
		{
			return null;
		}

		private static MonsterInfo GetMonsterInfoFromName(InstanceSettingData data, string key)
		{
			return null;
		}

		public string[] GetJudgementDetails(bool WinLose, int which)
		{
			return null;
		}

		public void CheckAllTriggers()
		{
		}

		private bool CheckTrigger(QuestTrigger t)
		{
			return false;
		}

		private int CheckExpressionValue(int[,] objectiveIdxArray, bool[] check)
		{
			return 0;
		}

		private void OnLoseObjective(int which, bool[] check)
		{
		}

		private void OnWinObjective(int which, bool[] check)
		{
		}

		public void TriggerStats_OnZoneFinish(ZoneState zs)
		{
		}

		public void TriggerStats_OnMonsterPerished(MonsterBornInfo bInfo)
		{
		}

		public void TriggerStats_OnHeroKilled()
		{
		}

		public void TriggerStats_OnDamagae(bool isHeroDamage, int damage)
		{
		}

		public void TriggerStats_OnMonsterBorn(MonsterBornEvent mbe)
		{
		}

		public bool IsCombaseLoseByHeroKilled(QuestFailedEvent e)
		{
			return false;
		}

		public bool JudgeIfSwipeUnlocked(bool isWin)
		{
			return false;
		}

		private void Protection_Init()
		{
		}

		public int[] GetMonsterCount()
		{
			return null;
		}

		private void ProtectionCheck_MonsterBorn(MonsterEntity e)
		{
		}

		private void ProtectionCheck_MonsterPerish(MonsterBornInfo bInfo)
		{
		}

		public void OnFirstMonsterBorn()
		{
		}

		public void OnAllMonsterKilled()
		{
		}

		private void StatInfo()
		{
		}
	}
}
