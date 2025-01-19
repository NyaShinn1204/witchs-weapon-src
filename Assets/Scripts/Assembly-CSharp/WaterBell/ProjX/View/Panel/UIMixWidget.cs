using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIMixWidget : UIBasicSprite
	{
		private int cacheFinalRQ;

		private Material m_EmptyMat;

		private UIMixDepthControl depthControl;

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void OnRender(Material mat)
		{
		}

		protected override void OnEnable()
		{
		}

		public void UpdateChildrenDepth(bool isRefreshNow = true)
		{
		}

		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}
	}
}
