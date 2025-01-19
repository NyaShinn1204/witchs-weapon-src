using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cscmod;
using Levelmod;
using LitJson;
using Lootmod;
using WaterBell.ProjX.Data.NetIO;
using WaterBell.ProjX.Level;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;
using unit;

namespace WaterBell.ProjX.Playmode
{
	public class ExpeditionMode : BasicPlayMode
	{
		public class ExpeditionInfoStruct
		{
			private int InBattleHP;

			private int[] Energy;

			public int GetInBattleHP()
			{
				return 0;
			}

			public int[] GetEnergy()
			{
				return null;
			}

			private void refreshEnergyData()
			{
			}

			private int GetEnergy(long _id)
			{
				return 0;
			}

			internal void UpdateForBattle(CscCombatInfo roleCombatInfo)
			{
			}
		}

		public class MonsterSavedDataItem
		{
			public int AreaId;

			public int ZoneId;

			public int WaveId;

			public int SubWaveId;

			public int SeqId;

			public float hp;

			public string extData;
		}

		public ExpeditionInfoStruct ExpeditionInfo;

		private bool isWin;

		public static string JSONKEY_MONSTERS_CURRWAVE;

		public static string JSONKEY_MONSTERS_OLDWAVE;

		public static string JSONKEY_MONSTERS_DIED;

		public static string JSONKEY_MONSTERS_NOTSPAWNED;

		public static string JSONKEY_NPC_CURRENT;

		public bool UseLevelState;

		private bool isLevelStateLoaded;

		private int data_current_areaId;

		private int data_current_zoneId;

		private int data_current_waveId;

		private List<MonsterSavedDataItem> monsterSavedDataInCurrentWave;

		private List<MonsterSavedDataItem> monsterSavedDataInOldWave;

		private List<MonsterSavedDataItem> monsterSavedDataDied;

		private List<MonsterSavedDataItem> monsterSavedDataNotSpawned;

		private Dictionary<MonsterSavedDataItem, MonsterInfo> SummonedCache;

		private Dictionary<MonsterInfo, MonsterSavedDataItem> MonsterLookupTable;

		public JsonData LevelState;

		public JsonData GroupState;

		public JsonData ZoneDefeatedNumInArea;

		public JsonData questInfo;

		public int InterruptedAreaId
		{
			get
			{
				return 0;
			}
		}

		public int InterruptedZoneId
		{
			get
			{
				return 0;
			}
		}

		public int InterruptedWaveId
		{
			get
			{
				return 0;
			}
		}

		public List<MonsterInfo> MonsterInCurrentWave
		{
			get
			{
				return null;
			}
		}

		public List<MonsterInfo> MonsterInOldWave
		{
			get
			{
				return null;
			}
		}

		public List<MonsterInfo> MonsterDied
		{
			get
			{
				return null;
			}
		}

		public List<MonsterInfo> MonsterNotSpawned
		{
			get
			{
				return null;
			}
		}

		public ExpeditionMode(MngrCollection mngrc)
		{
		}

		public ExpeditionMode(long instID, MngrCollection mngrc)
		{
		}

		protected override void Init()
		{
		}

		public void SetInstanceID(long instID)
		{
		}

		public void Renew()
		{
		}

		public override void ParseInstanceSettingData(string jsonStr)
		{
		}

		public override ActionResult IsAllow2Fight()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAble2BeginGame()
		{
			return default(ActionResult);
		}

		protected override void OnPlayerEnterInitialArea(PlayerEnterInitialAreaEvent e)
		{
		}

		protected override void HandleLoadInCustomPart()
		{
		}

		protected override void HandleRestartCustomPart()
		{
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		[DebuggerHidden]
		private IEnumerator WaitAnimationAndShowDialog()
		{
			return null;
		}

		private void DoRestart()
		{
		}

		private void DoCommitBattleResult()
		{
		}

		private void DealGetCscBattleLootResult(Lootmod.LootResult result)
		{
		}

		public void ClearCache()
		{
		}

		public override void ParseBattleResult(Levelmod.BattleResult result)
		{
		}

		public override List<NetMsgBase> BuildInitialNetMsgList()
		{
			return null;
		}

		public override void OnCombatExit()
		{
		}

		internal bool LevelStateLoaded()
		{
			return false;
		}

		public bool IsMonsterCurrentWaveNotSpawned(MonsterSavedDataItem msdi)
		{
			return false;
		}

		public List<MonsterInfo> GetMonsterInfoList(List<MonsterSavedDataItem> SavedDataList)
		{
			return null;
		}

		private MonsterInfo GetMonsterInfo(MonsterSavedDataItem msdi)
		{
			return null;
		}

		private void updateMonsterLookUpTable(List<MonsterSavedDataItem> dataList)
		{
		}

		public MonsterSavedDataItem GetSavedDataItemFromMonsterInfo(MonsterInfo mi)
		{
			return null;
		}

		public string GenSaveData()
		{
			return null;
		}

		private bool checkMonsterValid(MonsterBornInfo bi)
		{
			return false;
		}

		private string GetExDataIfNeed(MonsterEntity m)
		{
			return null;
		}

		private void WriteMonsterItem(JsonWriter jw, int areaIdx, int zoneIdx, int waveIdx, int subWaveIdx, int seqIndex, float hp, string exData = "")
		{
		}

		private bool MonsterInPool(int SeqIdx, List<Entity> list)
		{
			return false;
		}

		public void SetLevelState(string jsonText)
		{
		}

		private void RestoreMonsterInfo()
		{
		}

		private void LoadMonstersFromJSONArray(JsonData json, List<MonsterSavedDataItem> monsterDataList)
		{
		}

		public void PatchMonsterGroupState(Dictionary<int, GroupState> dic)
		{
		}

		public void PatchQuestManagerZoneDefeatedNumInArea(List<int> list)
		{
		}
	}
}
