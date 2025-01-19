using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Level.Model;

namespace WaterBell.LevelDesign
{
	public class HierarchyTool
	{
		public Dictionary<string, int> mobDict;

		public MobDesignStat mobStat;

		private static HierarchyTool _instance;

		private float currentZoneLevelHeight;

		public static string checkLevelResultMsg;

		public static HierarchyTool GetInstance()
		{
			return null;
		}

		public static Transform SearchLevelLayer(string nodeName)
		{
			return null;
		}

		public bool TryInitLevelStruct(long levelID, MobLvRange rng)
		{
			return false;
		}

		public void ScanMobs()
		{
		}

		public void ScanMobsAndLimitMobLevel(MobLvRange lvRng)
		{
		}

		public void ClearMobs(string mobPrefabname)
		{
		}

		private bool RecountInvalidMob(GameObject node)
		{
			return false;
		}

		private bool RecountMob(GameObject node)
		{
			return false;
		}

		private void ClearNode(GameObject node)
		{
		}

		public void AppendZone(Transform tf_areaNode, int wavePerZoneNum = 3, int zoneIdx = -1)
		{
		}

		public void InsertZoneEntryMarker(Transform tf_zoneNode)
		{
		}

		public void AppendWaves(Transform tf_zoneNode, int wavePerZoneNum = 3)
		{
		}

		public void AppendWave(Transform tf_wavesNode, int waveIdx = -1)
		{
		}

		public void AppendSubWave(Transform tf_waveNode, bool isBossSkillWave, int swIdx = -1)
		{
		}

		private void GenerateLevel(long levelID, MobLvRange rng, int areaNum = 1, int zoneNum = 3, int wavePerZoneNum = 3)
		{
		}

		public void LoadMobsFromMobFilterList()
		{
		}

		public void LoadNPCFromMobFilterList()
		{
		}

		public void RebuildLevelLayer(InstanceSettingData levelSettingData)
		{
		}

		private GameObject RebuildMob(MonsterInfo mInfo, Transform tf_Wave)
		{
			return null;
		}

		private void FillSubWaveAttribute(SubWaveAttr swAttr, SubWave subWaveInfo)
		{
		}

		private void FillWaveAttribute(WaveAttr wAttr, Wave waveInfo)
		{
		}

		private void AssignPRS(Transform tf_obj, double[] PRS, float floorHeight = 0f)
		{
		}

		private GameObject LoadMobAssetIntoHierarchy(Transform parentNode, string mobModelName, MobDataRow dr)
		{
			return null;
		}

		private static bool CheckZone(Transform tf_zone)
		{
			return false;
		}
	}
}
