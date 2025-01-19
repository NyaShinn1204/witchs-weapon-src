using UnityEngine;

namespace WaterBell.ProjX.Level.Trigger
{
	public class Protal : MonoBehaviour
	{
		public MapData nextMap;

		public float EnterTime;

		public const float nextTime = 0.8f;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		public void DoWipeMessage(int i)
		{
		}
	}
}
