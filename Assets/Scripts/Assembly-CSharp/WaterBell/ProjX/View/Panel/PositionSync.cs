using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class PositionSync : MonoBehaviour
	{
		private static Camera s_UICamera;

		private static float s_Dist;

		[Space]
		public Transform target;

		public Camera targetByCamera;

		public float tweenTime;

		public float rawDistance;

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void Follow(bool isTween)
		{
		}
	}
}
