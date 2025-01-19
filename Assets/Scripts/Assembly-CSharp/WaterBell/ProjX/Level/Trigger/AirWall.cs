using UnityEngine;
using WaterBell.ProjX.Level.Event;

namespace WaterBell.ProjX.Level.Trigger
{
	public class AirWall : MonoBehaviour
	{
		public bool canByPass;

		private int areaIdx;

		private int zoneIdx;

		private bool isWallTurnOn;

		private Transform tf_mainNode;

		private string myName;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPlayerEnterZone(PlayerEnterZoneEvent e)
		{
		}

		private void OnMonsterInZoneClear(MonsterInZoneClearEvent e)
		{
		}

		private void TurnOnWall()
		{
		}

		private void TurnOffWall(bool sIsSettingLoop = true)
		{
		}

		private void TurnOffVisibleWall()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDestory()
		{
		}
	}
}
