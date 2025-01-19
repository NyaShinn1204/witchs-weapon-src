using System.Collections.Generic;

namespace WaterBell.ProjX.Level
{
	public class WaveTrigger
	{
		public bool Check;

		public WaveTriggerType Type;

		public List<WaveTriggerMonsterStats> EnemyKillList;

		public float CountDownTime;

		public float CountDownTimeElapsed;

		public int CountDownTimeMode;

		public int KillCountCurrent;

		public int KillCountTheshold;

		public float WaveHPTheshold;

		public List<WaveTriggerMonsterStats> WaveHPList;

		public float WaveHpRefValue;

		public WaveTrigger()
		{
		}

		public WaveTrigger(WaveTriggerType t)
		{
		}
	}
}
