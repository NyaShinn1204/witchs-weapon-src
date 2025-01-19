using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Level;

namespace WaterBell.LevelDesign
{
	public class WaveAttr : MonoBehaviour
	{
		public WaveShowMode showMode;

		public float SpawnDelay;

		public List<WaveTrigger> NextWaveTriggers;

		public int sec2NextWave;

		public int kill2NextWave;

		public List<MonsterAttr> GetAllMonstersInThisWave(bool includeSubWave)
		{
			return null;
		}
	}
}
