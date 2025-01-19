using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.Level
{
	public class ZoneState
	{
		private static readonly int ZoneCheckFinishBufferFrameAmount;

		private static readonly string ZoneNamePrefix;

		public static readonly int KillAllCode;

		public static bool isAnyZoneInFight;

		private Zone zoneInfo;

		private Transform zoneNode;

		private Transform wavesNode;

		private Transform wallsNode;

		private Transform triggersNode;

		private int areaIdx;

		private int zoneIdx;

		private int prevZoneIdx;

		private int totalWavesNum;

		private List<int> monster2KillTotalNumInWave;

		private bool isInBattle;

		private bool isActived;

		private int waveIdx;

		private int monsterKilledNumInZone;

		private int bufferFrameCounter;

		private List<List<SubWave>> BossSkillWavesInZone;

		private int currentBossSkillGroupIdx;

		public Wave currWaveInBattle
		{
			get
			{
				return null;
			}
		}

		public ZoneState(int aIdx, int zIdx, Zone zInfo, Transform parentNode, int prev_zIdx = -1)
		{
		}

		public ZoneState(int aIdx, int zIdx, Zone zInfo, Transform parentNode, ExpeditionMode mode, int prev_zIdx = -1)
		{
		}

		public int GetAreaIdx()
		{
			return 0;
		}

		public int GetZoneIdx()
		{
			return 0;
		}

		public int GetCurrWaveIdx()
		{
			return 0;
		}

		public int GetTotalWavesNum()
		{
			return 0;
		}

		public int GetKilled()
		{
			return 0;
		}

		public int GetToKill()
		{
			return 0;
		}

		public int GetNextWaveSec()
		{
			return 0;
		}

		public bool IsInBattle()
		{
			return false;
		}

		public Transform GetWavesNodeTransform()
		{
			return null;
		}

		private bool IsKillFinishedInCurrWave()
		{
			return false;
		}

		private void AddWalls(Transform tf_wallsNode)
		{
		}

		private void AddTriggers(Transform tf_triggersNode)
		{
		}

		private void AssignPRS(Transform tf_obj, double[] PRS, float Y = 0f)
		{
		}

		public void SpawnMonsterOfCurrWave()
		{
		}

		private void SpawnSubWaveMonsters(int subWaveIdx)
		{
		}

		[DebuggerHidden]
		private IEnumerator LoadMonstersOfSubWaveInBattleZoneDelay(float delayTime, int wIdx, int SubWaveIdx)
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator LoadMonstersOfWaveInBattleZoneDelay(float delayTime)
		{
			return null;
		}

		public void OnCheckFightState()
		{
		}

		public void OnMosterKill(MonsterBornInfo bornInfo)
		{
		}

		public void Reset()
		{
		}

		private void ResetStatInfo()
		{
		}

		public void Init()
		{
		}

		public void SpawnBossSkillWave(Entity entity, int bossSkillWaveIdx = 0)
		{
		}

		private void initBossSkillWaves()
		{
		}

		private void AddListeners()
		{
		}

		private void OnPlayerEnterZone(PlayerEnterZoneEvent e)
		{
		}

		private void OnMonsterInZoneClear(MonsterInZoneClearEvent e)
		{
		}

		public Zone GetZoneInfo()
		{
			return null;
		}
	}
}
