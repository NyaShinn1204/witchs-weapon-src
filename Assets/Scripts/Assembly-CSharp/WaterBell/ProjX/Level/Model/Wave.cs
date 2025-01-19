using System.Collections.Generic;

namespace WaterBell.ProjX.Level.Model
{
	public class Wave
	{
		public string name { get; set; }

		public int showMode { get; set; }

		public double spawnDelay { get; set; }

		public int sec { get; set; }

		public int kill { get; set; }

		public List<WaveTriggerModel> NextWaveTriggers { get; set; }

		public List<SubWave> SubWaves { get; set; }

		public List<MonsterInfo> monsters { get; set; }
	}
}
