using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using WaterBell.ProjX.Level.Model;
using WaterBell.ProjX.Playmode;
using unit;

namespace WaterBell.ProjX.Level
{
	public class MonsterManager
	{
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		internal struct ExtraInjectInfo4Master
		{
			internal int waveIdx;

			internal int seqIdx;

			internal int powerRank;
		}

		public class MonsterInjectInfo
		{
			internal static MonsterInfo currMonsterToBeInjected;

			internal static string currAZWInfoToBeInjected;

			internal static ZoneState currZoneStateToBeInjected;

			internal static ExtraInjectInfo4Master currMonsterMasterInfoToBeJinjected;

			internal static int currMonsterSequenceIndexToBeInjected;

			internal static bool isCurrMonsterNeedExtraRecord;

			internal static int currMonsterSubWaveIndexToBeInjected;

			internal static void clear()
			{
			}
		}

		private class LevelSL_InjectInfo
		{
			internal static ZoneState currZoneToBeInjected;

			internal static MonsterInfo currMonsterToBeInjected;

			internal static int currMonsterSequenceIndexToBeInjected;

			internal static ExpeditionMode.MonsterSavedDataItem currMonsterMSDToBeInjected;

			internal static bool isCurrMonsterNeedExtraRecord;

			internal static void clear()
			{
			}
		}

		private static MonsterManager _instance;

		private ArrayList dustbin;

		private Dictionary<string, GameObject> prefabCache;

		private Dictionary<int, MonsterStatVO> monsterInfoDict;

		private Dictionary<List<MonsterInfo>, string> azwInfoCache;

		public Dictionary<int, GroupState> groupStateDict;

		public int mobIdxWhenShowInFlow;

		public bool isInSpawningWave;

		public bool inFlowSpawn;

		public bool isResetEnemysFinished;

		public static MonsterManager GetInstance()
		{
			return null;
		}

		public int GetkilledNum(Entity unit)
		{
			return 0;
		}

		public bool isGroupInBattle(int gpID)
		{
			return false;
		}

		public void NotifyGroupToBattle(int gpID)
		{
		}

		public bool CheckPlaymodeState()
		{
			return false;
		}

		public void LoadMonstersOfSubWaveInBattleZone(ZoneState battleZone, int SubWaveIdx)
		{
		}

		public void SpawnListFromSubwave(List<MonsterInfo> mList, ZoneState battleZone, int SubWaveIdx)
		{
		}

		public string GetAZWInfo(ZoneState battleZone)
		{
			return null;
		}

		public void LoadMonstersOfCurrentWaveInBattleZone(ZoneState battleZone)
		{
		}

		public GameObject TryLoadNPC(MonsterInfo mi, int SeqId, bool enable)
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator LoadMobInFlow(List<MonsterInfo> mList, ZoneState battleZone)
		{
			return null;
		}

		public bool isNoMonsterInFlow()
		{
			return false;
		}

		private List<MonsterInfo> GetAllMonsterInfos(EnemyInfo eInfo, NPCInfo[] npcInfo)
		{
			return null;
		}

		private Dictionary<string, int> CalculateMobMaxAppearance(EnemyInfo eInfo, NPCInfo[] npcInfo)
		{
			return null;
		}

		private Dictionary<string, int> CalculateMobMaxAppearanceInBattleZone(Zone battleZone)
		{
			return null;
		}

		private void CountMonstersAppearance(List<MonsterInfo> monsters, Dictionary<string, int> MaxMobAppearanceList)
		{
		}

		private void CalculateSummonMonsterAppearance(MonsterVO parent, int parentCount, Dictionary<string, int> spawnMobAppearance)
		{
		}

		private void CountSummonMonster(string aiTreeName, int count, Dictionary<string, int> spawnMobAppearance)
		{
		}

		public void ResetAITree(EnemyInfo eInfo, NPCInfo[] npcInfo)
		{
		}

		public void Clear()
		{
		}

		[DebuggerHidden]
		public IEnumerator ResetEnemysPrefabSetting2(EnemyInfo eInfo, NPCInfo[] npcInfo, BattlePreloadingData data)
		{
			return null;
		}

		public void LoadMonsterPrefab(string opn, Vector3 faraway)
		{
		}

		public bool InjectMonsterPosAndVO(MonsterEntity cb)
		{
			return false;
		}

		private void AssignTags(MonsterInfo m, MonsterEntity cb)
		{
		}

		public void OnMonsterKilled(MonsterBornInfo mbInfo)
		{
		}

		public void OnQuestFailed()
		{
		}

		public void SpawnSingleMonster(MonsterInfo m)
		{
		}

		private bool LevelSL_CheckFirstWaveMaybeCorrupted(ZoneState currBattleZone)
		{
			return false;
		}

		private void LevelSL_LoadMonstorsOfCurrWaveInBattleZone(ZoneState currBattleZone)
		{
		}

		private void LevelSL_SpawnEnemyList(List<MonsterInfo> mList, ZoneState currBattleZone)
		{
		}

		[DebuggerHidden]
		private IEnumerator LevelSL_LoadMobInFlow(List<MonsterInfo> mList, ZoneState battleZone)
		{
			return null;
		}

		internal bool LevelSL_IsCurrentWaveNeedSpecialInject()
		{
			return false;
		}

		public bool LevelSL_InjectMonsterPosAndVO(MonsterEntity cb)
		{
			return false;
		}

		internal void LevelSL_InjectMonsterHPIfNeeded(MonsterEntity cb)
		{
		}
	}
}
