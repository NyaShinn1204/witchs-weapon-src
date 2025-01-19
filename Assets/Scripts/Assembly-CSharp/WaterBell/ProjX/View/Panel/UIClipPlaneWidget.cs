using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	[ExecuteInEditMode]
	public class UIClipPlaneWidget : UIWidget
	{
		public bool runOnlyOnce;

		public Camera cam;

		public float dist;

		public bool isSideCut;

		protected override void OnUpdate()
		{
		}

		public void Resize()
		{
		}
	}
}
