using System.Collections.Generic;
using LitJson;
using UnityEngine;
using WaterBell.ProjX.Level;
using WaterBell.ProjX.Level.Model;

namespace WaterBell.LevelDesign
{
	public class FileTool
	{
		public enum IOResult
		{
			Succ = 0,
			InvalidRootNode = 1,
			InvalidFileName = 2,
			Cancel = 3
		}

		private static FileTool _instance;

		private readonly string _questInfoName;

		private readonly string _mapInfoName;

		private readonly string _aiConfigName;

		private HashSet<string> statSet;

		private string levelID;

		private string sceneName;

		public static FileTool GetInstance()
		{
			return null;
		}

		public static bool FolderExists(string folderPath)
		{
			return false;
		}

		public static void CreateFolder(string filePath)
		{
		}

		public void WriteTxtFile(string txtFile, string levelId, MapInfo mapInfo, QuestInfo qInfo, HashSet<string> mobSet)
		{
		}

		private void WriteJsonFile(GameObject root, string jsonFile, QuestInfo info, MapInfo info2, AIInfo ai_info)
		{
		}

		private void BuildNPCJson(JsonWriter json, Transform rootTransform)
		{
		}

		private void BuildInteractiveJson(JsonWriter json, Transform rootTransform)
		{
		}

		private void BuildQuestJson(JsonWriter json, QuestInfo info)
		{
		}

		private void BuildMapJson(JsonWriter json, MapInfo info)
		{
		}

		private void BuildAIJson(JsonWriter json, AIInfo info)
		{
		}

		private void BuildEnemyAndAreaJson(JsonWriter json, Transform parentNodeTransform)
		{
		}

		private void BuildEnemyZonesJson(JsonWriter json, Transform areaNodeTransform, int areaIdx)
		{
		}

		private void BuildZoneEntryPR(JsonWriter json, Transform parentNodeTransform)
		{
		}

		private void BuildZoneNavP(JsonWriter json, Transform parentNodeTransform)
		{
		}

		private void BuildZoneWavesJson(JsonWriter json, Transform parentNodeTransform, int areaIdx, int zoneIdx)
		{
		}

		private void WriteWaveTriggers(JsonWriter json, List<WaveTrigger> triggers, bool isSubWave)
		{
		}

		private void BuildWaveMonstersJson(JsonWriter json, Transform parentNodeTransform, int areaIdx, int zoneIdx, int waveIdx)
		{
		}

		private void BuildWaveSubWavesJson(JsonWriter json, Transform parentNodeTransform, int areaIdx, int zoneIdx, int waveIdx)
		{
		}

		private void BuildZoneWallsJson(JsonWriter json, Transform zoneWallsNodeTransform, int areaIdx, int zoneIdx)
		{
		}

		private void BuildZoneTriggersJson(JsonWriter json, Transform zoneTiggersNodeTransform, int areaIdx, int zoneIdx)
		{
		}

		private double trimFloat(float f)
		{
			return 0.0;
		}

		private void BuildMonsterObjJson(JsonWriter json, Transform currMonsterTransform, int areaIdx, int zoneIdx, int waveIdx, bool isNPC)
		{
		}

		private void BuildWallObjJson(JsonWriter json, Transform currWallTransform, int areaIdx, int zoneIdx)
		{
		}

		private void BuildTriggerObjJson(JsonWriter json, Transform currWallTransform, int areaIdx, int zoneIdx)
		{
		}

		private void BuildItemsJson(JsonWriter json, Transform transform)
		{
		}

		private void BuildVoidArray(JsonWriter json, string arrayName)
		{
		}

		public InstanceSettingData ParseLevelJsonFile(string levelJsonFilePath)
		{
			return null;
		}

		public GameObject GetIORootNode()
		{
			return null;
		}
	}
}
