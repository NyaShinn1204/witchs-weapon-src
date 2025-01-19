using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;

namespace WaterBell.ProjX.Level
{
	public class BattleFieldManager
	{
		private const string AreaNamePrefix = "Area_";

		private static BattleFieldManager _instance;

		public int currAreaIdx;

		private ZoneState currZoneStateInBattle;

		public List<bool> areaArrivedList;

		private List<List<ZoneState>> zsPool;

		public List<Transform> areaNodeList;

		public static readonly string ItemNodeName;

		public bool isInBattle
		{
			get
			{
				return false;
			}
		}

		private BattleFieldManager()
		{
		}

		public static BattleFieldManager GetInstance()
		{
			return null;
		}

		public void OnLoadIn(InstanceSettingData LevelInfo, Transform tf_parentNode, bool isUsingSavedData = false)
		{
		}

		private void LoadInteractiveObjects(InteractiveObjInfo[] interactiveObjInfo, Transform parent)
		{
		}

		private void AssignPRS(Transform tf_obj, double[] PRS, float height)
		{
		}

		public void OnRestart(InstanceSettingData LevelInfo, Transform tf_parentNode, bool isUsingSavedData = false)
		{
		}

		private void LoadAreaAndZoneIntoField(EnemyInfo eInfo, Transform tf_parentNode)
		{
		}

		public void OnRestart()
		{
		}

		public ZoneState GetZoneInBattle()
		{
			return null;
		}

		public void SetZoneInBattle(ZoneState zs)
		{
		}

		public void ResetAllArea()
		{
		}

		private void ResetAllZone()
		{
		}

		public void AddListener()
		{
		}

		public void RmListener()
		{
		}

		private void OnPlayerEnterArea(PlayerEnterAreaEvent e)
		{
		}

		private void OnPlayerSwapArea(PlayerSwapAreaEvent e)
		{
		}

		public void OnMonsterKill(MonsterBornInfo mbInfo)
		{
		}

		public List<List<ZoneState>> GetZonePool()
		{
			return null;
		}

		public void LeveSL_LoadAreaAndZoneIntoField(EnemyInfo eInfo, Transform tf_parentNode)
		{
		}

		public void LoadItemIntoField(ItemInfo[] items, Transform transform)
		{
		}

		private void AssignPRS(Transform tf_obj, double[] PRS)
		{
		}
	}
}
