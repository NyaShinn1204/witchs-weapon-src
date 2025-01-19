using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIStencilWidget : UIBasicSprite
	{
		public enum Kinds
		{
			AddMask = 0,
			ClearMask = 1
		}

		private Material m_EmptyMat;

		[SerializeField]
		private Kinds m_Kind;

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

		protected override void OnEnable()
		{
		}

		private void OnRender(Material mat)
		{
		}

		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}
	}
}
