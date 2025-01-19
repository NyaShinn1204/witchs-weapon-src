using UnityEngine;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;

namespace WaterBell.ProjX.Level.Trigger
{
	public class ColliderTrigger : MonoBehaviour
	{
		public bool isAutoHide;

		public ColliderTriggerType ctType;

		private bool isAllConditionPassed;

		private int areaIdx;

		private int zoneIdx;

		public bool allowSkillPenetration;

		public bool TriggerCameraFocusOnFirstMob;

		public float TriggerCameraFocusOnFirstMobDuration;

		public MonsterInfo CameraFocusMonster;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnPlayerEnterZone(PlayerEnterZoneEvent e)
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
