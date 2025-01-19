using System.Collections.Generic;
using LitJson;
using WaterBell.ProjX.Level.Model;

namespace WaterBell.ProjX.Level
{
	public class WaveTriggerManager
	{
		private static WaveTriggerManager instance;

		public List<WaveTrigger> Triggers;

		public List<List<WaveTrigger>> SubWaveTriggers;

		public List<SubWaveStatus> SubWaveStatuses;

		private WaveTriggerManager()
		{
		}

		public static WaveTriggerManager GetInstance()
		{
			return null;
		}

		public void SaveWaveTriggers(JsonWriter jw)
		{
		}

		public void RestoreWaveTriggers(JsonData jsonWaveTriggerStatus, JsonData jsonSubWaveStatus)
		{
		}

		public void StartWaveTrigger(Wave waveInfo, int CurrentAreaIdx, int CurrentZoneIdx, int CurrentWaveIdx)
		{
		}

		public int CheckTriggers()
		{
			return 0;
		}

		public int CheckSubWaveTriggers(int subWaveIdx)
		{
			return 0;
		}

		private void UpdateTrigger(WaveTrigger trigger)
		{
		}

		public void OnMonsterKilled(MonsterBornInfo bornInfo)
		{
		}

		public static List<WaveTrigger> GenerateTriggersFromWaveInfo(List<WaveTriggerModel> triggerList, List<MonsterInfo> waveMonsterList, bool inEditor)
		{
			return null;
		}

		internal float GetSec2NextWave()
		{
			return 0f;
		}
	}
}
