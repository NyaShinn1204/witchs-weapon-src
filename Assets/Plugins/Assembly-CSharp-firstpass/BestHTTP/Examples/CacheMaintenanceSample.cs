using UnityEngine;

namespace BestHTTP.Examples
{
	public sealed class CacheMaintenanceSample : MonoBehaviour
	{
		private enum DeleteOlderTypes
		{
			Days = 0,
			Hours = 1,
			Mins = 2,
			Secs = 3
		}

		private DeleteOlderTypes deleteOlderType;

		private int value;

		private int maxCacheSize;

		private void OnGUI()
		{
		}
	}
}
