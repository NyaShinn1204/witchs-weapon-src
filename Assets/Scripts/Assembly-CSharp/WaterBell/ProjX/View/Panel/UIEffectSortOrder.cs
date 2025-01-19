using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIEffectSortOrder : MonoBehaviour
	{
		public const int SORT_ORDER_INTERVAL = 10;

		public const int SORT_ORDER_MAX = 9;

		public const int SORT_ORDER_MIN = 0;

		public const int START_QUEUE = 3000;

		public int depthOffset;

		private int cacheDepthOffset;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetSortOrder()
		{
		}

		private bool IsValid<T>(T obj) where T : Component
		{
			return false;
		}
	}
}
