using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	internal class CreaseShading : PostEffectsBase
	{
		public float intensity;

		public int softness;

		public float spread;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
