using System.Collections.Generic;

namespace WaterBell.ProjX.Level.Model
{
	public class SubWave
	{
		public bool SpawnWaveForBossSkill;

		public List<WaveTriggerModel> EntryTriggers;

		public List<MonsterInfo> monsters;

		public double spawnDelay { get; set; }
	}
}
