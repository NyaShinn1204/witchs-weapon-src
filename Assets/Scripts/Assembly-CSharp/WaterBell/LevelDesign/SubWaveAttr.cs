using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Level;

namespace WaterBell.LevelDesign
{
	public class SubWaveAttr : MonoBehaviour
	{
		public List<WaveTrigger> EntryTriggers;

		public float SpawnDelay;

		public bool SpawnWaveForBossSkill;

		public int[] SpawnGroupSpliterIndecies;

		public List<string[]> SplitedGroupDataForBossSkill;

		public bool RandomSpawn;

		internal List<MonsterAttr> GetAllMonstersInThisSubWave()
		{
			return null;
		}
	}
}
