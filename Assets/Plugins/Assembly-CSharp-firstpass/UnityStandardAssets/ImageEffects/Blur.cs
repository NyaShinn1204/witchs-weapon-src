using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		public int iterations;

		public float blurSpread;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				return null;
			}
		}

		protected void OnDisable()
		{
		}

		protected void Start()
		{
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
