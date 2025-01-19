using UnityEngine;
using WaterBell.ProjX.Level.Event;

namespace WaterBell.ProjX.Guide.Content
{
	public class ClickHintAdaptor : MonoBehaviour
	{
		public int slotIdx;

		private Transform selfTF;

		private GameObject self;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnPause(PauseEvent e)
		{
		}

		private void OnUISkillChangeHD(GUtilListenerEvent sEvent)
		{
		}

		private void OnChangeWeaponHD(GUtilListenerEvent sEvent)
		{
		}

		private void OnPlayerExitBattleFieldFromArea(PlayerExitBattleFieldFromAreaEvent e)
		{
		}

		public void OnDestroy()
		{
		}
	}
}
