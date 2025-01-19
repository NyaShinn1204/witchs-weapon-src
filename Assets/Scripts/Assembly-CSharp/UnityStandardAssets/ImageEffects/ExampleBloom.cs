using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class ExampleBloom : ExampleEffectsBase
	{
		public enum Resolution
		{
			Low = 0,
			High = 1
		}

		public enum BlurType
		{
			Standard = 0,
			Sgx = 1
		}

		public float threshold;

		public float intensity;

		public float blurSize;

		private Resolution resolution;

		public int blurIterations;

		public BlurType blurType;

		private Material fastBloomMaterial;

		public Shader fastBloomShader
		{
			get
			{
				return null;
			}
		}

		public override bool CheckResources()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
