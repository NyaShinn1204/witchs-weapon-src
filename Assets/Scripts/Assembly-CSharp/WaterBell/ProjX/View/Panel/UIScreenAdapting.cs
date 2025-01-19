using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class UIScreenAdapting : MonoBehaviour
	{
		public enum PivotAdaptingTypes
		{
			Adaptive = 0,
			Fixed = 1
		}

		public enum SizeAdaptingTypes
		{
			Adaptive = 0,
			Fixed = 1
		}

		private static Vector2 EditorModeScreen;

		public PivotAdaptingTypes pivot;

		public SizeAdaptingTypes size;

		private UIRect uiRect;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
